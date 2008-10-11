/* File.......: frmMain.cs
 * System.....: RBArtMan - Windows art manager for RedBubble.
 * Author.....: Dave Pearson <davep@davep.org>
 * Copyright..: Dave Pearson 2008
 * ID.........: $Id$
 * Description: Main window.
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

namespace RBArtMan
{
    /// <summary>
    /// Main form.
    /// </summary>
    public partial class frmMain : Form
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The currently active document window.
        /// </summary>
        private frmArt CurrentDocument
        {
            get
            {
                return (frmArt) ActiveMdiChild;
            }
        }

        /// <summary>
        /// Create a new art window.
        /// </summary>
        /// <param name="sender">Pointer to the object sending the event.</param>
        /// <param name="e">The event being sent.</param>
        private void newArtWindow( object sender, EventArgs e )
        {
            // Create the new form.
            frmArt wndArt = new frmArt();

            // Let it know that we're the parent.
            wndArt.MdiParent = this;

            // Add some hooks.
            wndArt.FormClosed                 += mdiRefresh;
            wndArt.edtUserID.TextChanged      += mdiRefresh;
            wndArt.lvArt.SelectedIndexChanged += mdiRefresh;
            wndArt.BusyChange                 += mdiRefresh;

            // Show it.
            wndArt.Show();
        }

        /// <summary>
        /// Close the application.
        /// </summary>
        /// <param name="sender">Pointer to the object sending the event.</param>
        /// <param name="e">The event being sent.</param>
        private void closeApplication( object sender, EventArgs e )
        {
            Close();
        }

        /// <summary>
        /// Close the currently active art window.
        /// </summary>
        /// <param name="sender">Pointer to the object sending the event.</param>
        /// <param name="e">The event being sent.</param>
        private void closeArtWindow( object sender, EventArgs e )
        {
            ActiveMdiChild.Close();
        }

        /// <summary>
        /// Refresh all parts of our window that pertain to MDI stuff.
        /// </summary>
        /// <param name="sender">Pointer to the object sending the event.</param>
        /// <param name="e">The event being sent.</param>
        private void mdiRefresh( object sender, EventArgs e )
        {
            mdiRefresh();
        }

        /// <summary>
        /// Refresh all parts of our window that pertain to MDI stuff.
        /// </summary>
        private void mdiRefresh()
        {
            mnuFileSave.Enabled             = ActiveMdiChild != null && !CurrentDocument.Busy;
            tbMainFileSave.Enabled          = mnuFileSave.Enabled;
            mnuFileSaveAs.Enabled           = ActiveMdiChild != null && !CurrentDocument.Busy;
            tbMainFileSaveAs.Enabled        = mnuFileSaveAs.Enabled;
            mnuFileClose.Enabled            = ActiveMdiChild != null && !CurrentDocument.Busy;
            tbMainFileClose.Enabled         = mnuFileClose.Enabled;
            mnuArtDownload.Enabled          = ActiveMdiChild != null && CurrentDocument.CanDownload && !CurrentDocument.Busy;
            tbMainArtDownload.Enabled       = mnuArtDownload.Enabled;
            mnuArtExportCSV.Enabled         = ActiveMdiChild != null && CurrentDocument.CanExport;
            mnuArtExportTSV.Enabled         = ActiveMdiChild != null && CurrentDocument.CanExport;
            mnuArtExportHTML.Enabled        = ActiveMdiChild != null && CurrentDocument.CanExport;
            mnuArtExportCoolIris.Enabled    = ActiveMdiChild != null && CurrentDocument.CanExport;
            mnuArtPromoteWork.Enabled       = ActiveMdiChild != null && CurrentDocument.lvArt.SelectedItems.Count > 0;
            tbMainArtPromoteWork.Enabled    = mnuArtPromoteWork.Enabled;
            mnuArtPromoteProfile.Enabled    = ActiveMdiChild != null && CurrentDocument.CanExport;
            tbMainArtPromoteProfile.Enabled = mnuArtPromoteProfile.Enabled;
            mnuArtVisitArt.Enabled          = ActiveMdiChild != null && CurrentDocument.CanDownload;
            mnuArtVisitProfile.Enabled      = ActiveMdiChild != null && CurrentDocument.CanDownload;
            mnuArtVisitWork.Enabled         = ActiveMdiChild != null && CurrentDocument.lvArt.SelectedItems.Count > 0;
            mnuArtVisitEdit.Enabled         = ActiveMdiChild != null && CurrentDocument.lvArt.SelectedItems.Count > 0;
            tbMainArtVisitEdit.Enabled      = mnuArtVisitEdit.Enabled;
            mnuWindowCascade.Enabled        = MdiChildren.Length > 0;
            mnuWindowTileHorizontal.Enabled = MdiChildren.Length > 0;
            mnuWindowTileVertical.Enabled   = MdiChildren.Length > 0;
        }

        /// <summary>
        /// Download the details of the art pages associated with the current document.
        /// </summary>
        /// <param name="sender">Pointer to the object sending the event.</param>
        /// <param name="e">The event being sent.</param>
        private void mnuArtDownload_Click( object sender, EventArgs e )
        {
            CurrentDocument.Download();
        }

        /// <summary>
        /// Save the current document.
        /// </summary>
        /// <param name="sender">Pointer to the object sending the event.</param>
        /// <param name="e">The event being sent.</param>
        private void mnuFileSave_Click( object sender, EventArgs e )
        {
            if ( CurrentDocument.HasFileName )
            {
                CurrentDocument.SaveArt();
            }
            else
            {
                mnuFileSaveAs_Click( sender, e );
            }
        }

        /// <summary>
        /// Load a document.
        /// </summary>
        /// <param name="sender">Pointer to the object sending the event.</param>
        /// <param name="e">The event being sent.</param>
        private void mnuFileOpen_Click( object sender, EventArgs e )
        {
            if ( ofdArt.ShowDialog() == DialogResult.OK )
            {
                newArtWindow( sender, e );
                CurrentDocument.LoadArt( ofdArt.FileName );
                mdiRefresh();
            }
        }

        /// <summary>
        /// Save the current document, promting the user for the filename.
        /// </summary>
        /// <param name="sender">Pointer to the object sending the event.</param>
        /// <param name="e">The event being sent.</param>
        private void mnuFileSaveAs_Click( object sender, EventArgs e )
        {
            // Populate the dialog's filename.
            if ( CurrentDocument.HasFileName )
            {
                sfdArt.FileName = CurrentDocument.Filename;
            }
            else
            {
                sfdArt.FileName = CurrentDocument.UserID;
            }

            // Get the save information from the user.
            if ( sfdArt.ShowDialog() == DialogResult.OK )
            {
                // They've confirmed a save, do it.
                CurrentDocument.SaveArt( sfdArt.FileName );
            }
        }

        /// <summary>
        /// Visit the art pages associated with the current document.
        /// </summary>
        /// <param name="sender">Pointer to the object sending the event.</param>
        /// <param name="e">The event being sent.</param>
        private void mnuArtVisitArt_Click( object sender, EventArgs e )
        {
            CurrentDocument.VisitArt();
        }

        /// <summary>
        /// Visit your "mybubble".
        /// </summary>
        /// <param name="sender">Pointer to the object sending the event.</param>
        /// <param name="e">The event being sent.</param>
        private void mnuArtVisitMyBubble_Click( object sender, EventArgs e )
        {
            Process.Start( RBUtils.MyBubble().ToString() );
        }

        /// <summary>
        /// Visit the profile of the user associated with the current document.
        /// </summary>
        /// <param name="sender">Pointer to the object sending the event.</param>
        /// <param name="e">The event being sent.</param>
        private void mnuArtVisitProfile_Click( object sender, EventArgs e )
        {
            CurrentDocument.VisitProfile();
        }

        /// <summary>
        /// Visit the page associated with the currently highlighted work.
        /// </summary>
        /// <param name="sender">Pointer to the object sending the event.</param>
        /// <param name="e">The event being sent.</param>
        private void mnuArtVisitWork_Click( object sender, EventArgs e )
        {
            CurrentDocument.VisitWork();
        }

        /// <summary>
        /// Export the current document as a CSV file.
        /// </summary>
        /// <param name="sender">Pointer to the object sending the event.</param>
        /// <param name="e">The event being sent.</param>
        private void mnuArtExportCSV_Click( object sender, EventArgs e )
        {
            CurrentDocument.ExportToCSV();
        }

        /// <summary>
        /// Export the current file as a TSV file.
        /// </summary>
        /// <param name="sender">Pointer to the object sending the event.</param>
        /// <param name="e">The event being sent.</param>
        private void mnuArtExportTSV_Click( object sender, EventArgs e )
        {
            CurrentDocument.ExportToTSV();
        }

        /// <summary>
        /// Export the current file as HTML.
        /// </summary>
        /// <param name="sender">Pointer to the object sending the event.</param>
        /// <param name="e">The event being sent.</param>
        private void mnuArtExportHTML_Click( object sender, EventArgs e )
        {
            CurrentDocument.ExportToHTML();
        }

        /// <summary>
        /// Display information about the application.
        /// </summary>
        /// <param name="sender">Pointer to the object sending the event.</param>
        /// <param name="e">The event being sent.</param>
        private void mnuHelpAbout_Click( object sender, EventArgs e )
        {
            ( new frmAbout() ).ShowDialog();
        }

        /// <summary>
        /// Sort a few things out once the window is shown.
        /// </summary>
        /// <param name="sender">Pointer to the object sending the event.</param>
        /// <param name="e">The event being sent.</param>
        private void frmMain_Shown( object sender, EventArgs e )
        {
            // Place the version number in the status bar.
            ttslVersion.Text = "v" + Application.ProductVersion;

            // Get the command line arguments.
            string[] args = Environment.GetCommandLineArgs();

            // Open any files given on the command line.
            if ( args.Length > 1 )
            {
                for ( int i = 1; i < args.Length; i++ )
                {
                    newArtWindow( sender, e );
                    CurrentDocument.LoadArt( args[ i ] );
                }
            }

            // Refresh.
            mdiRefresh();
        }

        /// <summary>
        /// Generate promotion code for the current work.
        /// </summary>
        /// <param name="sender">Pointer to the object sending the event.</param>
        /// <param name="e">The event being sent.</param>
        private void mnuArtPromoteWork_Click( object sender, EventArgs e )
        {
            CurrentDocument.PromoteWork();
        }

        /// <summary>
        /// Cascade all child windows.
        /// </summary>
        /// <param name="sender">Pointer to the object sending the event.</param>
        /// <param name="e">The event being sent.</param>
        private void mnuWindowCascade_Click( object sender, EventArgs e )
        {
            LayoutMdi( MdiLayout.Cascade );
        }

        /// <summary>
        /// Tile all child windows.
        /// </summary>
        /// <param name="sender">Pointer to the object sending the event.</param>
        /// <param name="e">The event being sent.</param>
        private void mnuWindowTileHorizontal_Click( object sender, EventArgs e )
        {
            LayoutMdi( MdiLayout.TileHorizontal );
        }

        /// <summary>
        /// Tile all child windows.
        /// </summary>
        /// <param name="sender">Pointer to the object sending the event.</param>
        /// <param name="e">The event being sent.</param>
        private void mnuWindowTileVertical_Click( object sender, EventArgs e )
        {
            LayoutMdi( MdiLayout.TileVertical );
        }

        /// <summary>
        /// Visit the edit page for the highlighted work.
        /// </summary>
        /// <param name="sender">Pointer to the object sending the event.</param>
        /// <param name="e">The event being sent.</param>
        private void mnuArtVisitEdit_Click( object sender, EventArgs e )
        {
            CurrentDocument.EditWork();
        }

        /// <summary>
        /// Promote the current document's profile.
        /// </summary>
        /// <param name="sender">Pointer to the object sending the event.</param>
        /// <param name="e">The event being sent.</param>
        private void mnuArtPromoteProfile_Click( object sender, EventArgs e )
        {
            CurrentDocument.PromoteProfile();
        }

        /// <summary>
        /// Export the current document to a MediaRSS file.
        /// </summary>
        /// <param name="sender">Pointer to the object sending the event.</param>
        /// <param name="e">The event being sent.</param>
        private void mnuArtExportMediaRSS_Click( object sender, EventArgs e )
        {
            CurrentDocument.ExportToMediaRSS();
        }
    }
}