/* File.......: RBUtils.cs
 * System.....: RBArtMan - Windows art manager for RedBubble.
 * Author.....: Dave Pearson <davep@davep.org>
 * Copyright..: Dave Pearson 2008
 * Description: RedBubble utility classes.
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
using System.Reflection;
using System.Drawing;

namespace RBArtMan
{
    /// <summary>
    /// Attribute class for enums that help build RedBubble URLs.
    /// </summary>
    /// <remarks>Provides an attribute that lets you specify how the enum item will
    /// appear within a URL.</remarks>
    public class RBUrlString : Attribute
    {
        /// <summary>
        /// String that should be used in the URL.
        /// </summary>
        public string URLString;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="s"></param>
        public RBUrlString( string s )
        {
            URLString = s;
        }
    }

    /// <summary>
    /// Utility class for working with RedBubble enums.
    /// </summary>
    public static class RBEnums
    {
        /// <summary>
        /// Convert an enum value to some text that can be used within a URL.
        /// </summary>
        /// <param name="en">The enum to be converted.</param>
        /// <returns>The URL text for the given enum value.</returns>
        public static string ToURL( Enum en )
        {
            string sURL = en.ToString().ToLower();
            Type   type = en.GetType();

            MemberInfo[] memInfo = type.GetMember( en.ToString() );

            if ( memInfo != null && memInfo.Length > 0 )
            {
                object[] attrs = memInfo[ 0 ].GetCustomAttributes( typeof( RBUrlString ), false );

                if ( attrs != null && attrs.Length > 0 )
                {
                    sURL = ( (RBUrlString) attrs[ 0 ] ).URLString;
                }
            }

            return sURL;
        }
    }

    /// <summary>
    /// The type of cropping for the image.
    /// </summary>
    public enum ArtCropping
    {
        /// <summary>
        /// No cropping.
        /// </summary>
        None,
        /// <summary>
        /// A cropped view (normally square) view of an item of art.
        /// </summary>
        Cropped
    }

    /// <summary>
    /// Size of an item of art.
    /// </summary>
    public enum ArtSize
    {
        /// <summary>
        /// Extra small.
        /// </summary>
        XSmall,
        /// <summary>
        /// Small.
        /// </summary>
        Small,
        /// <summary>
        /// Medium.
        /// </summary>
        Medium,
        /// <summary>
        /// Extra medium.
        /// </summary>
        XMedium,
        /// <summary>
        /// Large.
        /// </summary>
        Large,
        /// <summary>
        /// Extra large.
        /// </summary>
        XLarge
    }

    /// <summary>
    /// "Views" of art.
    /// </summary>
    public enum ArtView
    {
        /// <summary>
        /// Main view.
        /// </summary>
        Main,
        /// <summary>
        /// Preview view.
        /// </summary>
        Preview
    }

    /// <summary>
    /// Types of art products on RedBubble.
    /// </summary>
    public enum ArtProduct
    {
        /// <summary>
        /// Greetings cards.
        /// </summary>
        [ RBUrlString( "greeting-card" ) ] 
        GreetingCard,
        
        /// <summary>
        /// Matted print.
        /// </summary>
        [ RBUrlString( "matted-print" ) ] 
        MattedPrint,

        /// <summary>
        /// Laminated print.
        /// </summary>
        [ RBUrlString( "laminated-print" ) ] 
        LaminatedPrint,

        /// <summary>
        /// Mounted print.
        /// </summary>
        [ RBUrlString( "mounted-print" ) ] 
        MountedPrint,

        /// <summary>
        /// Canvas print.
        /// </summary>
        [ RBUrlString( "canvas-print" ) ] 
        CanvasPrint,

        /// <summary>
        /// Framed print.
        /// </summary>
        [ RBUrlString( "framed-print" ) ] 
        FramedPrint,

        /// <summary>
        /// Poster.
        /// </summary>
        Poster
    }

    /// <summary>
    /// Product backing colours.
    /// </summary>
    public enum BackingColour
    {
        /// <summary>
        /// Black background.
        /// </summary>
        Black,

        /// <summary>
        /// White background.
        /// </summary>
        White
    }

    /// <summary>
    /// Product matte colours.
    /// </summary>
    public enum MatteColour
    {
        /// <summary>
        /// Off white matte colour.
        /// </summary>
        [ RBUrlString( "off%20white" ) ]
        OffWhite,

        /// <summary>
        /// Bright white matte colour.
        /// </summary>
        [ RBUrlString( "bright%20white" ) ]
        BrightWhite,

        /// <summary>
        /// Black matte colour.
        /// </summary>
        Black
    }

    /// <summary>
    /// Border colours.
    /// </summary>
    public enum BorderColour
    {
        /// <summary>
        /// No border.
        /// </summary>
        [ RBUrlString( "noborder" ) ]
        None,

        /// <summary>
        /// White border with artist's details.
        /// </summary>
        [ RBUrlString( "whitewithdetail" ) ]
        WhiteWithDetails,

        /// <summary>
        /// Black border with artist's details.
        /// </summary>
        [ RBUrlString( "blackwithdetail" ) ]
        BlackWhiteDetails
    }

    /// <summary>
    /// Frame colours.
    /// </summary>
    public enum FrameColour
    {
        /// <summary>
        /// Black frame.
        /// </summary>
        Black,

        /// <summary>
        /// Charcoal frame.
        /// </summary>
        Charcoal,

        /// <summary>
        /// Cherry frame.
        /// </summary>
        Cherry,

        /// <summary>
        /// Mocha frame.
        /// </summary>
        Mocha,

        /// <summary>
        /// Walnut frame.
        /// </summary>
        Walnut
    }

    /// <summary>
    /// Utility functions.
    /// </summary>
    static class RBUtils
    {
        /// <summary>
        /// Base site for RedBubble URLs.
        /// </summary>
        private const string RB_SITE = "www.redbubble.com";

        /// <summary>
        /// Format string for the RedBubble image server(s).
        /// </summary>
        private const string RB_IMAGE_SERVER = "images-{0}.redbubble.com";

        /// <summary>
        /// The port to connect to at RedBubble.
        /// </summary>
        private const int RB_PORT = 80;

        /// <summary>
        /// Path to people on the RedBubble site.
        /// </summary>
        private const string RB_PEOPLE_PATH = "people";

        /// <summary>
        /// Path to art on the RedBubble site.
        /// </summary>
        private const string RB_ART_PATH = "art";

        /// <summary>
        /// Return the "root" part of a URL for a RedBubble server.
        /// </summary>
        /// <param name="sServer">The server.</param>
        /// <returns>The root part of the URL for that server.</returns>
        public static Uri RBRoot( string sServer )
        {
            return new Uri( "http://" + sServer + ":" + RB_PORT.ToString() + "/" );
        }

        /// <summary>
        /// Return the "root" part of a URL for RedBubble's main site.
        /// </summary>
        /// <returns>The root part of the URL for RedBubble's main site.</returns>
        public static Uri RBRoot()
        {
            return RBRoot( RB_SITE );
        }

        /// <summary>
        /// Return the "root" part of a URL for one of RedBubble's image servers.
        /// </summary>
        /// <param name="iServer">The number of the image server.</param>
        /// <returns>The root part of the URL for the given image server.</returns>
        public static Uri RBImageServer( int iServer )
        {
            return RBRoot( String.Format( RB_IMAGE_SERVER, iServer ) );
        }

        /// <summary>
        /// Return the "root" part of a URL for one of RedBubble's image servers.
        /// </summary>
        /// <param name="sWorkID">The ID of an item of work.</param>
        /// <returns>The root part of the URL for the given image server.</returns>
        /// <remarks>The actual server name is worked out from the ID of the work.
        /// Values of 0 to 3 are taken from the ID based on the ID modulo 4.</remarks>
        public static Uri RBImageServer( string sWorkID )
        {
            return RBImageServer( Convert.ToInt32( sWorkID ) % 4 );
        }

        /// <summary>
        /// Return the URL for "mybubble".
        /// </summary>
        /// <returns>The URL for "mybubble".</returns>
        public static Uri MyBubble()
        {
            return new Uri( RBRoot().ToString() + "mybubble/" );
        }

        /// <summary>
        /// Return the URL for a user's profile page.
        /// </summary>
        /// <param name="sUser">The user whose profile we want the URL for.</param>
        /// <returns>The URL</returns>
        public static Uri RBProfileURL( string sUser )
        {
            return new Uri( RBRoot().ToString() + RB_PEOPLE_PATH + "/" + sUser + "/" );
        }

        /// <summary>
        /// Return the URL for a person's art.
        /// </summary>
        /// <param name="sUser">The user whose art we want the URL for.</param>
        /// <returns>The URL</returns>
        public static Uri ArtURL( string sUser )
        {
            return new Uri( RBProfileURL( sUser ).ToString() + RB_ART_PATH );
        }

        /// <summary>
        /// Return the URL for a specific page of art for the given user.
        /// </summary>
        /// <param name="sUser">The user whose art we want the URL for.</param>
        /// <param name="iPage">The page to point at.</param>
        /// <returns>The URL</returns>
        public static Uri ArtURL( string sUser, int iPage )
        {
            return new Uri( ArtURL( sUser ).ToString() + "/?page=" + iPage.ToString() );
        }

        /// <summary>
        /// Return the URL for a specific work.
        /// </summary>
        /// <param name="sUser">The user who owns the work.</param>
        /// <param name="sWorkID">The ID of the work.</param>
        /// <returns>The URL for the work.</returns>
        public static Uri WorkURL( string sUser, string sWorkID )
        {
            return new Uri( ArtURL( sUser ).ToString() + "/" + sWorkID );
        }

        /// <summary>
        /// Return the edit URL for a specific work.
        /// </summary>
        /// <param name="sWorkID">The ID of the work.</param>
        /// <returns>The edit URL for the work.</returns>
        public static Uri WorkEditURL( string sWorkID )
        {
            return new Uri( MyBubble() + "art/" + sWorkID + "/edit" );
        }

        /// <summary>
        /// Return the purchasing URL for a specific work.
        /// </summary>
        /// <param name="sUser">The user who owns the work.</param>
        /// <param name="sWorkID">The ID of the work.</param>
        /// <returns>The URL for purchasing the work.</returns>
        public static Uri WorkBuyURL( string sUser, string sWorkID )
        {
            return new Uri( WorkURL( sUser, sWorkID ).ToString() + "/buy" );
        }

        /// <summary>
        /// Return the URL for the image of a work.
        /// </summary>
        /// <param name="sWorkID">The ID of the work.</param>
        /// <param name="cropping">The type of cropping to apply.</param>
        /// <param name="size">The size of the image.</param>
        /// <param name="view">The type of view to use.</param>
        /// <param name="sExtras">Any extra bits of path you want to add before the file.</param>
        /// <returns>The URL for the image.</returns>
        public static Uri WorkImageURL( string sWorkID, ArtCropping cropping, ArtSize size, ArtView view, string sExtras )
        {
            return new Uri( RBImageServer( sWorkID ) +
                "img/art/" +
                ( cropping == ArtCropping.Cropped ? "cropped/" : "" ) +
                "size:" + RBEnums.ToURL( size ) + "/" +
                "view:" + RBEnums.ToURL( view ) + "/" +
                sExtras +
                sWorkID + ".jpg" );
        }

        /// <summary>
        /// Return the URL for the image of a work.
        /// </summary>
        /// <param name="sWorkID">The ID of the work.</param>
        /// <param name="cropping">The type of cropping to apply.</param>
        /// <param name="size">The size of the image.</param>
        /// <param name="view">The type of view to use.</param>
        /// <returns>The URL for the image.</returns>
        public static Uri WorkImageURL( string sWorkID, ArtCropping cropping, ArtSize size, ArtView view )
        {
            return WorkImageURL( sWorkID, cropping, size, view, "" );
        }

        /// <summary>
        /// Return the URL for the image of a work.
        /// </summary>
        /// <param name="sWorkID">The ID of the work.</param>
        /// <param name="cropping">The type of cropping to apply.</param>
        /// <param name="size">The size of the image.</param>
        /// <returns>The URL for the image.</returns>
        public static Uri WorkImageURL( string sWorkID, ArtCropping cropping, ArtSize size )
        {
            return WorkImageURL( sWorkID, cropping, size, ArtView.Main );
        }

        /// <summary>
        /// Return the URL for a card preview image.
        /// </summary>
        /// <param name="sWorkID">The ID of the work.</param>
        /// <param name="colour">The colour to use for the background.</param>
        /// <param name="imageBackColour">The colour to use for the background of the preview image.</param>
        /// <returns>The URL of a card preview of the work.</returns>
        public static Uri CardPreviewURL( string sWorkID, BackingColour colour, Color imageBackColour )
        {
            return WorkImageURL( sWorkID, ArtCropping.None, ArtSize.Small, ArtView.Preview,
//              "backgroundcolor:" + imageBackColour.R.ToString( "x" ) + imageBackColour.G.ToString( "x" ) + imageBackColour.B.ToString( "x" ) + "/" +
                "product:" + RBEnums.ToURL( ArtProduct.GreetingCard ) + "/" +
                "backingcolor:" + RBEnums.ToURL( colour ) + "/" );
        }

        /// <summary>
        /// Return the URL for a matted print preview image.
        /// </summary>
        /// <param name="sWorkID">The ID of the work.</param>
        /// <param name="colour">The colour to use for the matte.</param>
        /// <returns>The URL of a matted print preview of the work.</returns>
        public static Uri MattedPrintPreviewURL( string sWorkID, MatteColour colour )
        {
            return WorkImageURL( sWorkID, ArtCropping.None, ArtSize.Small, ArtView.Preview,
                "product:" + RBEnums.ToURL( ArtProduct.MattedPrint ) + "/" +
                "mattecolor:" + RBEnums.ToURL( colour ) + "/" );
        }

        /// <summary>
        /// Return the URL for a laminated print preview image.
        /// </summary>
        /// <param name="sWorkID">The ID of the work.</param>
        /// <param name="border">The border to use for the print.</param>
        /// <param name="size">The size of the laminated print.</param>
        /// <returns>The URL of a laminated print preview of the work.</returns>
        public static Uri LaminatedPrintPreviewURL( string sWorkID, BorderColour border, ArtSize size )
        {
            return WorkImageURL( sWorkID, ArtCropping.None, size, ArtView.Preview,
                "product:" + RBEnums.ToURL( ArtProduct.LaminatedPrint ) + "/" +
                "border:" + RBEnums.ToURL( border ) + "/" );
        }

        /// <summary>
        /// Return the URL for a mounted print preview image.
        /// </summary>
        /// <param name="sWorkID">The ID of the work.</param>
        /// <param name="border">The border to use for the print.</param>
        /// <returns>The URL of a mounted print preview of the work.</returns>
        public static Uri MountedPrintPreviewURL( string sWorkID, BorderColour border )
        {
            return WorkImageURL( sWorkID, ArtCropping.None, ArtSize.Small, ArtView.Preview,
                "product:" + RBEnums.ToURL( ArtProduct.MountedPrint ) + "/" +
                "border:" + RBEnums.ToURL( border ) + "/" );
        }

        /// <summary>
        /// Return the URL for a canvas print preview image.
        /// </summary>
        /// <param name="sWorkID">The ID of the work.</param>
        /// <returns>The URL of a canvas print preview of the work.</returns>
        public static Uri CanvasPrintPreviewURL( string sWorkID )
        {
            return WorkImageURL( sWorkID, ArtCropping.None, ArtSize.Small, ArtView.Preview,
                "product:" + RBEnums.ToURL( ArtProduct.CanvasPrint ) + "/" );
        }

        /// <summary>
        /// Return the URL for a framed print preview image.
        /// </summary>
        /// <param name="sWorkID">The ID of the work.</param>
        /// <param name="frame">The colour of the frame.</param>
        /// <param name="matte">The colour of the matte.</param>
        /// <param name="size">The size of the framed print.</param>
        /// <returns>The URL of a framed print preview of the work.</returns>
        public static Uri FramedPrintPreviewURL( string sWorkID, FrameColour frame, MatteColour matte, ArtSize size )
        {
            return WorkImageURL( sWorkID, ArtCropping.None, size, ArtView.Preview,
                "product:" + RBEnums.ToURL( ArtProduct.FramedPrint ) + "/" +
                "framestyle:flat30/" +
                "framecolor:" + RBEnums.ToURL( frame ) + "/" +
                "mattecolor:" + RBEnums.ToURL( matte ) + "/" );
        }
    }
}
