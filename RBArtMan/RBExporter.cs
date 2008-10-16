/* File.......: RBExporter.cs
 * System.....: RBArtMan - Windows art manager for RedBubble.
 * Author.....: Dave Pearson <davep@davep.org>
 * Copyright..: Dave Pearson 2008
 * Description: Art exporting classes.
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
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace RBArtMan
{
    /// <summary>
    /// Base exporter class.
    /// </summary>
    abstract class RBBaseExporter
    {
        /// <summary>
        /// The document we'll be exporting from.
        /// </summary>
        protected RBArtDocument doc;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="doc">The document that will be exported.</param>
        public RBBaseExporter( RBArtDocument doc )
        {
            // Remember the document.
            this.doc = doc;
        }

        /// <summary>
        /// Export to the given location.
        /// </summary>
        /// <param name="sLocation">The location we'll export to.</param>
        /// <returns><c>true</c> if the export happened, <c>false</c> if not.</returns>
        /// <remarks>The location given could be a file or directory or even possibly
        /// something else. The context will depend on the child class in use.</remarks>
        public abstract bool ExportTo( string sLocation );
    }

    /// <summary>
    /// Base class for exporter classes that are line based.
    /// </summary>
    abstract class RBBaseLineExporter : RBBaseExporter
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="doc">The document that will be exported.</param>
        public RBBaseLineExporter( RBArtDocument doc ) : base( doc ) { }

        /// <summary>
        /// Format an item for writing to a file.
        /// </summary>
        /// <param name="item">The item to be formatted.</param>
        /// <returns>A string representation of the item.</returns>
        protected abstract string FormatItem( RBArtItem item );

        /// <summary>
        /// Export the document as a file.
        /// </summary>
        /// <param name="sLocation">The name of the file to export to.</param>
        /// <returns><c>true</c> if the export happened, <c>false</c> if not.</returns>
        public override bool ExportTo( string sLocation )
        {
            // Assume the worst.
            bool bExported = false;

            // Create the file to export to.
            using ( FileStream h = new FileStream( sLocation, FileMode.Create, FileAccess.Write, FileShare.None ) )
            {
                try
                {
                    using ( StreamWriter stream = new StreamWriter( h ) )
                    {
                        try
                        {
                            foreach ( RBArtItem item in doc.Items )
                            {
                                stream.WriteLine( FormatItem( item ) );
                            }
                        }
                        finally
                        {
                            stream.Close();
                        }
                        bExported = true;
                    }
                }
                finally
                {
                    h.Close();
                }
            }

            return bExported;
        }
    }

    /// <summary>
    /// Export to a CSV file.
    /// </summary>
    class RBExportToCSV : RBBaseLineExporter
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="doc">The document that will be exported.</param>
        public RBExportToCSV( RBArtDocument doc ) : base( doc ) {}

        /// <summary>
        /// Format an item for writing to a file.
        /// </summary>
        /// <param name="item">The item to be formatted.</param>
        /// <returns>A string representation of the item.</returns>
        protected override string FormatItem( RBArtItem item )
        {
            return String.Format( "{0},\"{1}\"", item.ID, item.Title );
        }
    }

    /// <summary>
    /// Export to a TSV file.
    /// </summary>
    class RBExportToTSV : RBBaseLineExporter
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="doc">The document that will be exported.</param>
        public RBExportToTSV( RBArtDocument doc ) : base( doc ) {}

        /// <summary>
        /// Format an item for writing to a file.
        /// </summary>
        /// <param name="item">The item to be formatted.</param>
        /// <returns>A string representation of the item.</returns>
        protected override string FormatItem( RBArtItem item )
        {
            return String.Format( "{0}\t{1}", item.ID, item.Title );
        }
    }

    /// <summary>
    /// Export an art document to a set of HTML files.
    /// </summary>
    class RBExportToHTML : RBBaseExporter
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="doc">The document that will be exported.</param>
        public RBExportToHTML( RBArtDocument doc ) : base( doc ) {}

        /// <summary>
        /// Max number of works per page.
        /// </summary>
        protected const int MAX_WORKS_PER_PAGE = 20;

        /// <summary>
        /// Export the document as HTML files.
        /// </summary>
        /// <param name="sLocation">The directory where the files will be located.</param>
        /// <returns><c>true</c> if the export happened, <c>false</c> if not.</returns>
        public override bool ExportTo( string sLocation )
        {
            // Assume the worst.
            bool bExported = false;

            using( frmExportHTML oExport = new frmExportHTML() )
            {
                if ( oExport.ShowDialog() == DialogResult.OK )
                {
                    // Work out how many pages we'll have.
                    int iMaxPage = (int) Math.Ceiling( (double) ( doc.Items.Count / MAX_WORKS_PER_PAGE ) );

                    // For each page....
                    for ( int i = 0; i <= iMaxPage; i++ )
                    {
                        // ...emit the page.
                        ExportPage( i, sLocation, oExport.Buy );
                    }

                    // Done.
                    bExported = true;
                }
            }

            return bExported;
        }

        /// <summary>
        /// Export a page of HTML from the document.
        /// </summary>
        /// <param name="iPage">The page to export.</param>
        /// <param name="sLocation">The location where it will be exported to.</param>
        /// <param name="bBuy">Should we link to the purchase page for a work instead of the view page?</param>
        protected void ExportPage( int iPage, string sLocation, bool bBuy )
        {
            using ( FileStream h = new FileStream( sLocation + "\\page" + iPage.ToString() + ".html", FileMode.Create, FileAccess.Write, FileShare.None ) )
            {
                try
                {
                    using ( StreamWriter html = new StreamWriter( h ) )
                    {
                        try
                        {
                            // Write the intro.
                            html.WriteLine( "<div id=\"rbam-redbubble-art\">" );

                            // Write the art.
                            for ( int i = iPage * MAX_WORKS_PER_PAGE; i < Math.Min( ( iPage * MAX_WORKS_PER_PAGE ) + MAX_WORKS_PER_PAGE, doc.Items.Count ); i++ )
                            {
                                RBArtItem item = doc.Items[ i ];

                                html.WriteLine( String.Format( "<a class=\"rbam-thumbnail\" href=\"{0}\" title=\"{1}\"><img class=\"rbam-thumbnail\" src=\"{2}\" alt=\"{1}\" /></a>", 
                                    bBuy ? RBUtils.WorkBuyURL( doc.UserName, item.ID ) : RBUtils.WorkURL( doc.UserName, item.ID ),
                                    item.Title, 
                                    RBUtils.WorkImageURL( item.ID, ArtCropping.Cropped, ArtSize.Small ) ) );
                            }

                            // Write the outro.
                            html.WriteLine( "</div>" );
                        }
                        finally
                        {
                            html.Close();
                        }
                    }
                }
                finally
                {
                    h.Close();
                }
            }
        }
    }

    /// <summary>
    /// Class that exports a document to a MediaRSS file.
    /// </summary>
    class RBExportToMediaRSS : RBBaseExporter
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="doc">The document that will be exported.</param>
        public RBExportToMediaRSS( RBArtDocument doc ) : base( doc ) { }

        /// <summary>
        /// Perform the MediaRSS export.
        /// </summary>
        /// <param name="sLocation">The name of the file to export to.</param>
        /// <param name="oOptions">Options for the export.</param>
        /// <returns><c>true</c> if the export happened, <c>false</c> if not.</returns>
        protected bool PerformExport( string sLocation, frmExportMediaRSS oOptions )
        {
            // Assume the worst.
            bool bExported = false;

            // Create the file to export to.
            using ( FileStream h = new FileStream( sLocation, FileMode.Create, FileAccess.Write, FileShare.None ) )
            {
                try
                {
                    using ( StreamWriter stream = new StreamWriter( h ) )
                    {
                        try
                        {
                            // For when we need a time.
                            string sNow = DateTime.Now.ToUniversalTime().ToString( "r" );

                            // First write the start of the document.
                            stream.WriteLine( "<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"yes\"?>" );
                            stream.WriteLine( "<rss version=\"2.0\" xmlns:media=\"http://search.yahoo.com/mrss/\" xmlns:atom=\"http://www.w3.org/2005/Atom\">" );
                            stream.WriteLine( "  <channel>" );
                            stream.WriteLine( "    <title>" + Utils.HTMLEncode( oOptions.Title ) + "</title>" );
                            stream.WriteLine( "    <description>" + Utils.HTMLEncode( oOptions.Title ) + "</description>" );
                            stream.WriteLine( "    <copyright>" + Utils.HTMLEncode( oOptions.Copyright ) + "</copyright>" );
                            stream.WriteLine( "    <link>" + RBUtils.RBProfileURL( doc.UserName ) + "</link>" );
                            stream.WriteLine( "    <pubDate>" + sNow + "</pubDate>" );
                            stream.WriteLine( "    <lastBuildDate>" + sNow + "</lastBuildDate>" );
                            stream.WriteLine( "    <generator>http://www.davep.org/misc/RBArtMan/</generator>" );
                            stream.WriteLine( "    <managingEditor>" + Utils.HTMLEncode( oOptions.Author ) + "</managingEditor>" );
                            stream.WriteLine( "    <category>Art</category>" );
                            // <atom:link>

                            // Now write each item in the channel.
                            foreach ( RBArtItem item in doc.Items )
                            {
                                string sTargetURL = ( oOptions.Buy ? RBUtils.WorkBuyURL( doc.UserName, item.ID ) : RBUtils.WorkURL( doc.UserName, item.ID ) ).ToString();

                                stream.WriteLine( "    <item>" );
                                stream.WriteLine( "      <title>" + Utils.HTMLEncode( item.Title ) + "</title>" );
                                stream.WriteLine( "      <link>" + sTargetURL + "</link>" );
                                stream.WriteLine( "      <guid isPermaLink=\"true\">" + sTargetURL + "</guid>" );
                                stream.WriteLine( "      <pubDate>" + sNow + "</pubDate>" );
                                stream.WriteLine( "      <author>" + Utils.HTMLEncode( oOptions.Author ) + "</author>" );
                                stream.WriteLine( "      <media:thumbnail url=\"" + RBUtils.WorkImageURL( item.ID, ArtCropping.None, ArtSize.Small ) + "\" />" );
                                stream.WriteLine( "      <media:content url=\"" + RBUtils.WorkImageURL( item.ID, ArtCropping.None, ArtSize.XLarge ) + "\" />" );
                                // <media:credit>
                                // <description>
                                stream.WriteLine( "      <category>Art</category>" );
                                stream.WriteLine( "    </item>" );
                            }

                            // End of the document.
                            stream.WriteLine( "  </channel> " );
                            stream.WriteLine( "</rss>" );

                            // Done.
                            bExported = true;
                        }
                        finally
                        {
                            stream.Close();
                        }
                    }
                }
                finally
                {
                    h.Close();
                }
            }

            return bExported;
        }

        /// <summary>
        /// Export the document as a MediaRSS file.
        /// </summary>
        /// <param name="sLocation">The name of the file to export to.</param>
        /// <returns><c>true</c> if the export happened, <c>false</c> if not.</returns>
        public override bool ExportTo( string sLocation )
        {
            // Assume the worst.
            bool bExported = false;

            using ( frmExportMediaRSS oExport = new frmExportMediaRSS() )
            {
                // Set any defaults.
                oExport.Link = RBUtils.RBProfileURL( doc.UserName ).ToString();

                // Get options from the user.
                if ( oExport.ShowDialog() == DialogResult.OK )
                {
                    // They've confirmed the export, do it...
                    bExported = PerformExport( sLocation, oExport );
                }
            }

            return bExported;
        }
    }
}
