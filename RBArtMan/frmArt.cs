/* File.......: frmArt.cs
 * System.....: RBArtMan - Windows art manager for RedBubble.
 * Author.....: Dave Pearson <davep@davep.org>
 * Copyright..: Dave Pearson 2008
 * ID.........: $Id$
 * Description: Art list window.
 * Licence....: GNU General Public Licence (see below)
 *
 * RBArtMan - Windows art manager for RedBubble.
 * Copyright (C) 2008 Dave Pearson <davep@davep.org>
 *
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation; either version 2 of the license, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 675 Mass Ave, Cambridge, MA 02139, USA.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Xml.Serialization;
using System.IO;
using System.Threading;

namespace RBArtMan
{
    /// <summary>
    /// Art window.
    /// </summary>
    public partial class frmArt : Form
    {
        /// <summary>
        /// Filename for the document.
        /// </summary>
        protected string sFilename = "";

        /// <summary>
        /// Date and time of the last download.
        /// </summary>
        protected DateTime dtLastDownloaded = new DateTime( 0 );

        /// <summary>
        /// Keeps track of if we're busy or not.
        /// </summary>
        protected Boolean bBusy = false;

        /// <summary>
        /// Keeps track of if the contents of the window are "dirty" (need saving).
        /// </summary>
        protected Boolean bDirty = false;

        /// <summary>
        /// Type of a function called when the busy status changes.
        /// </summary>
        public delegate void Busyness();

        /// <summary>
        /// Busy status change event.
        /// </summary>
        public event Busyness BusyChange;

        /// <summary>
        /// Is the window busy?
        /// </summary>
        public bool Busy
        {
            get
            {
                return bBusy;
            }
            set
            {
                bBusy = value;
                if ( BusyChange != null )
                {
                    Invoke( new GeneralRefreshFunction( BusyChange ) );
                }
            }
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        public frmArt()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Type of a general refresh function.
        /// </summary>
        protected delegate void GeneralRefreshFunction();

        /// <summary>
        /// Refresh the window's title.
        /// </summary>
        protected void refreshTitle()
        {
            Text = String.Format( "Art{0} - [{1}]", 
                CanDownload ? " for " + UserID : "",
                sFilename == "" ? "Untitled" : sFilename );
        }

        /// <summary>
        /// Refresh the content of the status bar.
        /// </summary>
        protected void refreshStatusBar()
        {
            if ( ssArt.InvokeRequired )
            {
                Invoke( new GeneralRefreshFunction( refreshStatusBar ) );
            }
            else
            {
                lblLastDownload.Text = "Last Downloaded: " + ( dtLastDownloaded.Ticks == 0 ? "Never" : dtLastDownloaded.ToString() );
                lblItems.Text        = "Items: " + lvArt.Items.Count.ToString();
            }
        }

        /// <summary>
        /// Do things when the window is first shown.
        /// </summary>
        /// <param name="sender">The object sending the event.</param>
        /// <param name="e">The event being sent.</param>
        private void frmArt_Shown( object sender, EventArgs e )
        {
            // Refresh the title.
            refreshTitle();
        }

        /// <summary>
        /// Does this document have a filename?
        /// </summary>
        internal bool HasFileName
        {
            get
            {
                return sFilename.Trim() != "";
            }
        }

        /// <summary>
        /// Returns the user ID for this window.
        /// </summary>
        internal string UserID
        {
            get
            {
                return edtUserID.Text.Trim();
            }
        }

        /// <summary>
        /// Are we in a state where we can download something?
        /// </summary>
        internal bool CanDownload
        {
            get
            {
                return UserID != "";
            }
        }

        /// <summary>
        /// Are we in a state where we can export something?
        /// </summary>
        internal bool CanExport
        {
            get
            {
                return CanDownload && lvArt.Items.Count > 0;
            }
        }

        /// <summary>
        /// Populate the window based on the content of a RedBubble art document.
        /// </summary>
        /// <param name="doc"></param>
        protected void DocToWindow( RBArtDocument doc )
        {
            // Pull out the "header" items.
            edtUserID.Text   = doc.UserName;
            dtLastDownloaded = doc.LastDownloaded;

            // Pull out the "body".
            lvArt.BeginUpdate();
            try
            {
                foreach ( RBArtItem item in doc.Items )
                {
                    AddArtItemToList( item );
                }
            }
            finally
            {
                lvArt.EndUpdate();
            }
        }

        /// <summary>
        /// Return a RedBubble art document based on the content of the window.
        /// </summary>
        /// <returns></returns>
        protected RBArtDocument WindowToDoc()
        {
            // Create the document.
            RBArtDocument doc = new RBArtDocument();

            // Populate the "header" details.
            doc.UserName       = UserID;
            doc.LastDownloaded = dtLastDownloaded;

            // Populate the "body".
            foreach ( ListViewItem item in lvArt.Items )
            {
                doc.Items.Add( new RBArtItem( item.Text, item.SubItems[ 1 ].Text ) );
            }

            // Return the document.
            return doc;
        }

        /// <summary>
        /// Tell the user about download errors.
        /// </summary>
        /// <param name="e">The exception that contains the details of the download error.</param>
        protected void ReportDownloadError( Exception e )
        {
            MessageBox.Show( e.Message );
        }

        /// <summary>
        /// Type of a function that updates the status display.
        /// </summary>
        /// <param name="sStatus">The status message to display.</param>
        protected delegate void StatusUpdateFunction( string sStatus );

        /// <summary>
        /// Update the window's status.
        /// </summary>
        /// <param name="sStatus">The status message to display.</param>
        protected void UpdateStatus( string sStatus )
        {
            if ( lblStatus.InvokeRequired )
            {
                Invoke( new StatusUpdateFunction( UpdateStatus ), new Object[] { sStatus } );
            }
            else
            {
                lblStatus.Text = sStatus;
            }
        }

        /// <summary>
        /// Type of a function that adds an item of art to the art list.
        /// </summary>
        /// <param name="item">The item of art to add.</param>
        protected delegate void ArtItemAddFunction( RBArtItem item );

        /// <summary>
        /// Clear the art list.
        /// </summary>
        protected void ClearArtList()
        {
            if ( lvArt.InvokeRequired )
            {
                Invoke( new GeneralRefreshFunction( ClearArtList ) );
            }
            else
            {
                lvArt.Items.Clear();
            }
        }

        /// <summary>
        /// Allow the user's ability to edit the user ID.
        /// </summary>
        protected void AllowUserIDEdit()
        {
            if ( InvokeRequired )
            {
                Invoke( new GeneralRefreshFunction( AllowUserIDEdit ) );
            }
            else
            {
                edtUserID.ReadOnly = false;
            }
        }

        /// <summary>
        /// Stop the user's ability to edit the user ID.
        /// </summary>
        protected void StopUserIDEdit()
        {
            if ( InvokeRequired )
            {
                Invoke( new GeneralRefreshFunction( StopUserIDEdit ) );
            }
            else
            {
                edtUserID.ReadOnly = true;
            }
        }

        /// <summary>
        /// Add an item of art to the art list.
        /// </summary>
        /// <param name="item">The item to add.</param>
        protected void AddArtItemToList( RBArtItem item )
        {
            if ( lvArt.InvokeRequired )
            {
                Invoke( new ArtItemAddFunction( AddArtItemToList ), new object[] { item } );
            }
            else
            {
                // Create the ListView item that'll hold the details of the item of art.
                ListViewItem lvItem = new ListViewItem( item.ID );

                // Add the title to it.
                lvItem.SubItems.Add( item.Title );

                // Add the item to the list.
                lvArt.Items.Add( lvItem );

                // We've changed the list. Become dirty.
                bDirty = true;
            }
        }

        /// <summary>
        /// Does the work of downloading the art.
        /// </summary>
        protected void DoDownload()
        {
            // Go busy.
            Busy = true;

            // Also, don't let the user edit the user name any more.
            StopUserIDEdit();

            try
            {
                try
                {
                    // Using a downloader.
                    using ( RBDownloader art = new RBDownloader( UserID ) )
                    {
                        UpdateStatus( "Getting page count" );

                        // If it looks like the user has some art.
                        if ( art.MaxPage > 0 )
                        {
                            // Given that things look okay, clear the current list of art.
                            ClearArtList();

                            // For each page of art...
#if DEBUG
                            for ( int i = 1; i <= 1; i++ )
#else
                            for ( int i = 1; i <= art.MaxPage; i++ )
#endif
                            {
                                // Keep the user informed.
                                UpdateStatus( String.Format( "Getting page {0}/{1} of art", i, art.MaxPage ) );

                                // Get the art on the page.
                                RBArtItems items = art.GetArt( i );

                                // For each item found on the page...
                                foreach ( RBArtItem item in items )
                                {
                                    // ...add it to our list.
                                    AddArtItemToList( item );
                                }
                            }

                            // Seems to have worked. Remember when the last download took place.
                            dtLastDownloaded = DateTime.Now;

                            // Refresh the status bar.
                            refreshStatusBar();
                        }

                        // Clear the status.
                        UpdateStatus( "" );

                        // Got art?
                        if ( lvArt.Items.Count > 0 )
                        {
                            // Yes, let the user know.
                            MessageBox.Show( "Your art list has been downloaded from RedBubble.", "Art download finished", MessageBoxButtons.OK, MessageBoxIcon.Information );
                        }
                        else
                        {
                            // Let the user know there is no art.
                            MessageBox.Show( "That user appears to have no art available.", "No Art", MessageBoxButtons.OK, MessageBoxIcon.Information );
                        }
                    }
                }
                catch ( Exception e )
                {
                    // Clear the status.
                    UpdateStatus( "" );
                    // Report the error.
                    ReportDownloadError( e );
                    // Given that there is an error, assume that they might want to change the
                    // user name.
                    AllowUserIDEdit();
                }
            }
            finally
            {
                // Stop being busy.
                Busy = false;
            }
        }

        /// <summary>
        /// Download the art.
        /// </summary>
        internal void Download()
        {
            // If we're in a position to download.
            if ( CanDownload )
            {
                if ( MessageBox.Show( "Are you sure you want to download a list of your art from RedBubble?", "Download Art", MessageBoxButtons.YesNo, MessageBoxIcon.Question ) == DialogResult.Yes )
                {
                    ( new Thread( new ThreadStart( DoDownload ) ) ).Start();
                }
            }
            else
            {
                MessageBox.Show( "Not in a position to download at the moment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }

        /// <summary>
        /// Visit the profile page associated with our user.
        /// </summary>
        internal void VisitProfile()
        {
            if ( CanDownload )
            {
                Process.Start( RBUtils.RBProfileURL( UserID ).ToString() );
            }
            else
            {
                MessageBox.Show( "Not in a position to visit at the moment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }

        /// <summary>
        /// Visit the art pages associated with our user.
        /// </summary>
        internal void VisitArt()
        {
            if ( CanDownload )
            {
                Process.Start( RBUtils.ArtURL( UserID ).ToString() );
            }
            else
            {
                MessageBox.Show( "Not in a position to visit at the moment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }

        /// <summary>
        /// Visit the page associated with the current highlighted work.
        /// </summary>
        internal void VisitWork()
        {
            if ( CanDownload && lvArt.SelectedItems.Count > 0 )
            {
                Process.Start( RBUtils.WorkURL( UserID, lvArt.SelectedItems[ 0 ].Text ).ToString() );
            }
            else
            {
                MessageBox.Show( "Not in a position to visit at the moment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }

        /// <summary>
        /// Visit the edit page associated with the current highlighted work.
        /// </summary>
        internal void EditWork()
        {
            if ( CanDownload && lvArt.SelectedItems.Count > 0 )
            {
                Process.Start( RBUtils.WorkEditURL( lvArt.SelectedItems[ 0 ].Text ).ToString() );
            }
            else
            {
                MessageBox.Show( "Not in a position to edit at the moment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }

        /// <summary>
        /// Save our document.
        /// </summary>
        internal void SaveArt( string sFilename )
        {
            // Remember the filename.
            this.sFilename = sFilename;

            // Get the content of this window as a RedBubble art document.
            RBArtDocument doc = WindowToDoc();

            // Create the serializer.
            XmlSerializer xml = new XmlSerializer( doc.GetType() );

            // Create the file to save to.
            using ( FileStream h = new FileStream( sFilename, FileMode.Create, FileAccess.Write, FileShare.None ) )
            {
                try
                {
                    // Write out the document.
                    xml.Serialize( h, doc );

                    // We've saved. Become clean.
                    bDirty = false;
                }
                finally
                {
                    h.Close();
                }
            }

            // Refresh the display.
            refreshTitle();
        }

        /// <summary>
        /// Save our document.
        /// </summary>
        internal void SaveArt()
        {
            SaveArt( sFilename );
        }

        /// <summary>
        /// Load an art document from the given file name.
        /// </summary>
        /// <param name="sFilename">The file to load.</param>
        internal void LoadArt( string sFilename )
        {
            // Remember the filename.
            this.sFilename = sFilename;

            // Create the serializer.
            XmlSerializer xml = new XmlSerializer( typeof( RBArtDocument ) );

            // Open the file to load from.
            using ( FileStream h = new FileStream( sFilename, FileMode.Open, FileAccess.Read, FileShare.ReadWrite ) )
            {
                try
                {
                    try
                    {
                        using ( new BusyCursor() )
                        {
                            // Deserialize the document.
                            DocToWindow( (RBArtDocument) xml.Deserialize( h ) );
                            // Seems we've loaded fine. Mark the window as clean.
                            bDirty = false;
                            // Also, given that this was a load, there's no point in the user being
                            // able to edit the user name any more.
                            StopUserIDEdit();
                        }
                    }
                    catch
                    {
                        MessageBox.Show( "Error loading document. Does not appear to be a valid art list.", "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                        Close();
                    }
                }
                finally
                {
                    h.Close();
                }
            }

            // Refresh the display.
            refreshTitle();
            refreshStatusBar();
        }

        /// <summary>
        /// Export the document to a CSV file.
        /// </summary>
        internal void ExportToCSV()
        {
            if ( sdCSV.ShowDialog() == DialogResult.OK )
            {
                try
                {
                    ( new RBExportToCSV( WindowToDoc() ) ).ExportTo( sdCSV.FileName );
                }
                catch ( Exception e )
                {
                    MessageBox.Show( "There was an error while exporting to the CSV file:\n\n" + e.Message, "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                }
            }
        }

        /// <summary>
        /// Export the document to a TSV file.
        /// </summary>
        internal void ExportToTSV()
        {
            if ( sdTSV.ShowDialog() == DialogResult.OK )
            {
                try
                {
                    ( new RBExportToTSV( WindowToDoc() ) ).ExportTo( sdTSV.FileName );
                }
                catch ( Exception e )
                {
                    MessageBox.Show( "There was an error while exporting to the TSV file:\n\n" + e.Message, "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                }
            }
        }

        /// <summary>
        /// Export the document as HTML.
        /// </summary>
        internal void ExportToHTML()
        {
            if ( fbHTML.ShowDialog() == DialogResult.OK )
            {
                try
                {
                    ( new RBExportToHTML( WindowToDoc() ) ).ExportTo( fbHTML.SelectedPath );
                    MessageBox.Show( "HTML files have been created in " + fbHTML.SelectedPath, "HTML Export Finished", MessageBoxButtons.OK, MessageBoxIcon.Information );
                }
                catch ( Exception e )
                {
                    MessageBox.Show( "There was an error while exporting to the HTML files:\n\n" + e.Message, "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                }
            }
        }

        /// <summary>
        /// Export the document to a MediaRSs file.
        /// </summary>
        internal void ExportToMediaRSS()
        {
            if ( sdMediaRSS.ShowDialog() == DialogResult.OK )
            {
                try
                {
                    ( new RBExportToMediaRSS( WindowToDoc() ) ).ExportTo( sdMediaRSS.FileName );
                }
                catch ( Exception e )
                {
                    MessageBox.Show( "There was an error while exporting to the MediaRSS file:\n\n" + e.Message, "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                }
            }
        }

        /// <summary>
        /// Refresh the art list context menu when it pops up.
        /// </summary>
        /// <param name="sender">Pointer to the object sending the event.</param>
        /// <param name="e">The event being sent.</param>
        private void popArt_Opening( object sender, CancelEventArgs e )
        {
            popArtDownload.Enabled       = CanDownload;
            popArtExportCSV.Enabled      = CanExport;
            popArtExportTSV.Enabled      = CanExport;
            popArtExportHTML.Enabled     = CanExport;
            popArtVisitArt.Enabled       = CanDownload;
            popArtVisitProfile.Enabled   = CanDownload;
            popArtVisitWork.Enabled      = CanDownload && lvArt.SelectedItems.Count > 0;
            popArtVisitEdit.Enabled      = CanDownload && lvArt.SelectedItems.Count > 0;
            popArtPromoteWork.Enabled    = CanDownload && lvArt.SelectedItems.Count > 0;
            popArtPromoteProfile.Enabled = CanDownload && lvArt.SelectedItems.Count > 0;
        }

        /// <summary>
        /// Do the download.
        /// </summary>
        /// <param name="sender">Pointer to the object sending the event.</param>
        /// <param name="e">The event being sent.</param>
        private void popArtDownload_Click( object sender, EventArgs e )
        {
            Download();
        }

        /// <summary>
        /// Visit the user's profile.
        /// </summary>
        /// <param name="sender">Pointer to the object sending the event.</param>
        /// <param name="e">The event being sent.</param>
        private void popArtVisitProfile_Click( object sender, EventArgs e )
        {
            VisitProfile();
        }

        /// <summary>
        /// Visit the user's art pages.
        /// </summary>
        /// <param name="sender">Pointer to the object sending the event.</param>
        /// <param name="e">The event being sent.</param>
        private void popArtVisitArt_Click( object sender, EventArgs e )
        {
            VisitArt();
        }

        /// <summary>
        /// Visit the page for the highlighted work.
        /// </summary>
        /// <param name="sender">Pointer to the object sending the event.</param>
        /// <param name="e">The event being sent.</param>
        private void popArtVisitWork_Click( object sender, EventArgs e )
        {
            VisitWork();
        }

        /// <summary>
        /// Visit the "mybubble" page.
        /// </summary>
        /// <param name="sender">Pointer to the object sending the event.</param>
        /// <param name="e">The event being sent.</param>
        private void popArtVisitMyBubble_Click( object sender, EventArgs e )
        {
            Process.Start( RBUtils.MyBubble().ToString() );
        }

        /// <summary>
        /// Handles a double click on the list view of art.
        /// </summary>
        /// <param name="sender">Pointer to the object sending the event.</param>
        /// <param name="e">The event being sent.</param>
        private void lvArt_DoubleClick( object sender, EventArgs e )
        {
            if ( CanDownload && lvArt.SelectedItems.Count > 0 )
            {
                VisitWork();
            }
        }

        /// <summary>
        /// Handle the CSV export click from the context menu.
        /// </summary>
        /// <param name="sender">Pointer to the object sending the event.</param>
        /// <param name="e">The event being sent.</param>
        private void popArtExportCSV_Click( object sender, EventArgs e )
        {
            ExportToCSV();
        }

        /// <summary>
        /// Handle the TSV export click from the context menu.
        /// </summary>
        /// <param name="sender">Pointer to the object sending the event.</param>
        /// <param name="e">The event being sent.</param>
        private void popArtExportTSV_Click( object sender, EventArgs e )
        {
            ExportToTSV();
        }

        /// <summary>
        /// Handle the HTML export click from the context menu.
        /// </summary>
        /// <param name="sender">Pointer to the object sending the event.</param>
        /// <param name="e">The event being sent.</param>
        private void popArtExportHTML_Click( object sender, EventArgs e )
        {
            ExportToHTML();
        }

        /// <summary>
        /// Generate promotion code for the current work.
        /// </summary>
        internal void PromoteWork()
        {
            if ( CanDownload && lvArt.SelectedItems.Count > 0 )
            {
                using ( frmPromoteWork promote = new frmPromoteWork() )
                {
                    // Pass on the information that the dialog needs.
                    promote.sUser   = UserID;
                    promote.sWorkID = lvArt.SelectedItems[ 0 ].Text.ToString();

                    // Show the dialog.
                    promote.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show( "Not in a position to promote a work at the moment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }

        /// <summary>
        /// Promote the current work.
        /// </summary>
        /// <param name="sender">Pointer to the object sending the event.</param>
        /// <param name="e">The event being sent.</param>
        private void popArtPromoteWork_Click( object sender, EventArgs e )
        {
            PromoteWork();
        }

        /// <summary>
        /// Visit the edit page for the current work.
        /// </summary>
        /// <param name="sender">Pointer to the object sending the event.</param>
        /// <param name="e">The event being sent.</param>
        private void popArtVisitEdit_Click( object sender, EventArgs e )
        {
            EditWork();
        }

        /// <summary>
        /// Generate promotion code for the current profile.
        /// </summary>
        internal void PromoteProfile()
        {
            if ( CanDownload )
            {
                using ( frmPromoteProfile promote = new frmPromoteProfile() )
                {
                    // Let the dialog know who the user is.
                    promote.sUser = UserID;

                    // Show the dialog.
                    promote.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show( "Not in a position to promote the profile at the moment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }

        /// <summary>
        /// Promote the current profile.
        /// </summary>
        /// <param name="sender">Pointer to the object sending the event.</param>
        /// <param name="e">The event being sent.</param>
        private void popArtPromoteProfile_Click( object sender, EventArgs e )
        {
            PromoteProfile();
        }

        /// <summary>
        /// Do some checks on close.
        /// </summary>
        /// <param name="sender">Pointer to the object sending the event.</param>
        /// <param name="e">The event being sent.</param>
        private void frmArt_FormClosing( object sender, FormClosingEventArgs e )
        {
            // Are we busy downloading?
            if ( Busy )
            {
                // Let the user know we're not going to close.
                MessageBox.Show( String.Format( "Busy downloading art for {0}, can't close just yet.", UserID ), "Can't close", MessageBoxButtons.OK, MessageBoxIcon.Warning );

                // Cancel the close.
                e.Cancel = true;
            }
            else if ( bDirty ) // Is the content of the window unsaved?
            {
                // Check that the user doesn't save to save.
                if ( MessageBox.Show( String.Format( "You haven't saved the art for {0}, are you sure you want to close the window?", UserID ), "Unsaved changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question ) == DialogResult.No )
                {
                    // They do want to save. Cancel the close.
                    e.Cancel = true;
                }
            }
        }

        /// <summary>
        /// Refresh the window title as the user types in a user name.
        /// </summary>
        /// <param name="sender">Pointer to the object sending the event.</param>
        /// <param name="e">The event being sent.</param>
        private void edtUserID_TextChanged( object sender, EventArgs e )
        {
            refreshTitle();
        }

        /// <summary>
        /// Export the current document to a MediaRSS file.
        /// </summary>
        /// <param name="sender">Pointer to the object sending the event.</param>
        /// <param name="e">The event being sent.</param>
        private void popArtExportMediaRSS_Click( object sender, EventArgs e )
        {
            ExportToMediaRSS();
        }
    }
}