/* File.......: RBDownloader.cs
 * System.....: RBArtMan - Windows art manager for RedBubble.
 * Author.....: Dave Pearson <davep@davep.org>
 * Copyright..: Dave Pearson 2008
 * Description: Art downloader class.
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
using System.Net;
using System.Xml;
using System.IO;
using System.Text.RegularExpressions;

namespace RBArtMan
{
    /// <summary>
    /// Class that handles downloading data from RedBubble.
    /// </summary>
    class RBDownloader : IDisposable
    {
        /// <summary>
        /// The web client.
        /// </summary>
        protected WebClient web = null;

        /// <summary>
        /// User we'll be downloading for.
        /// </summary>
        protected string sUser;

        /// <summary>
        /// Holds the max page.
        /// </summary>
        protected int iMaxPage = -1;

        /// <summary>
        /// Holds the name table used when pulling data from the xhtml. 
        /// </summary>
        protected XmlNameTable nt;

        /// <summary>
        /// Holds the namespace manager used when pulling data from the xhtml. 
        /// </summary>
        protected XmlNamespaceManager nsmgr;

        /// <summary>
        ///  Constructor.
        /// </summary>
        /// <param name="sUser">The user we'll be downloading for.</param>
        public RBDownloader( string sUser )
        {
            // Remember the user.
            this.sUser = sUser;

            // Create the web client.
            web = new WebClient();

            // Create the name table.
            nt = new NameTable();

            // Crete the namespace manager.
            nsmgr = new XmlNamespaceManager( nt );

            // Add the xhtml namespace.
            nsmgr.AddNamespace( "xhtml", "http://www.w3.org/1999/xhtml" );
        }

        /// <summary>
        /// Dispose of an object of our class.
        /// </summary>
        public void Dispose()
        {
            if ( web != null )
            {
                web.Dispose();
            }
        }

        /// <summary>
        /// Download an art page as a string.
        /// </summary>
        /// <param name="iPage">The page to download.</param>
        /// <returns>The content of the page as a string.</returns>
        protected string GetArtPageAsString( int iPage )
        {
            return web.DownloadString( RBUtils.ArtURL( sUser, iPage ) );
        }

        /// <summary>
        /// Download an art page.
        /// </summary>
        /// <param name="iPage">The page to download.</param>
        /// <returns>The content of the page as an XmlDocument.</returns>
        protected XmlDocument GetArtPage( int iPage )
        {
            string sText = GetArtPageAsString( iPage );

            XmlDocument doc = new XmlDocument();

            doc.LoadXml( sText );

            return doc;
        }

        /// <summary>
        /// Returns the count of art pages for the user.
        /// </summary>
        public int MaxPage
        {
            get
            {
                if ( iMaxPage == -1 )
                {
                    // Get the first page of art.
                    XmlDocument page = GetArtPage( 1 );

                    // Find the list of pages.
                    XmlNodeList pages = page.SelectNodes( "//xhtml:div[@id='pages']/xhtml:a", nsmgr );

                    // Got a list?
                    if ( pages.Count > 0 )
                    {
                        // The content of the last link to a specific page contains our max page number.
                        iMaxPage = Convert.ToInt32( pages[ pages.Count - 1 ].InnerText );
                    }
                    else
                    {
                        // Couldn't find the page links. Let's assume there's just the single page.
                        iMaxPage = 1;
                    }
                }

                return iMaxPage;
            }
        }

        /// <summary>
        /// Get the ID of a work from the URL of a work.
        /// </summary>
        /// <param name="sURL">The URL of the work.</param>
        /// <returns>The unique ID of the work.</returns>
        protected string WorkIDFromURL( string sURL )
        {
            return ( new Regex( @"/(\d+)-" ) ).Match( sURL ).Groups[ 1 ].Value;
        }

        /// <summary>
        /// Get a list of art from a page.
        /// </summary>
        /// <param name="iPage">The page to get the art from.</param>
        /// <returns>List of art found on the page.</returns>
        public RBArtItems GetArt( int iPage )
        {
            // Create the list to hold the items.
            RBArtItems art = new RBArtItems();

            // Get the page.
            XmlDocument page = GetArtPage( iPage );

            // Find the items in the page.
            XmlNodeList items = page.SelectNodes( "//xhtml:span[@class='work-info']", nsmgr );

            // For each item found.
            foreach ( XmlNode item in items )
            {
                XmlNode id    = item.SelectSingleNode( "xhtml:span[@class='title']/xhtml:a", nsmgr );
                XmlNode title = id; // Get title from same place as the ID.

                art.Add( new RBArtItem( WorkIDFromURL( id.Attributes[ "href" ].Value ), title.Attributes[ "title" ].Value ) );
            }

            return art;
        }
    }
}
