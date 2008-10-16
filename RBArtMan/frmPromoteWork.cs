/* File.......: frmPromoteWork.cs
 * System.....: RBArtMan - Windows art manager for RedBubble.
 * Author.....: Dave Pearson <davep@davep.org>
 * Copyright..: Dave Pearson 2008
 * Description: Art promotion dialog.
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

namespace RBArtMan
{
    /// <summary>
    /// Dialog that helps construct promotion code for a work.
    /// </summary>
    public partial class frmPromoteWork : Form
    {
        /// <summary>
        /// The ID of the user we'll be promoting.
        /// </summary>
        internal string sUser;

        /// <summary>
        /// The ID of the work we'll be promoting.
        /// </summary>
        internal string sWorkID;

        /// <summary>
        /// Pointer to our preview form.
        /// </summary>
        protected frmPromoteWorkPreview preview;

        /// <summary>
        /// Constructor.
        /// </summary>
        public frmPromoteWork()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Set up the dialog once it's been shown.
        /// </summary>
        /// <param name="sender">The object sending the event.</param>
        /// <param name="e">The event.</param>
        private void frmPromoteWork_Shown( object sender, EventArgs e )
        {
            GenerateCode();
        }

        /// <summary>
        /// Generate the promotion code.
        /// </summary>
        private void GenerateCode()
        {
            if ( rbTextile.Checked )
            {
                edtPromoteCode.Text = TextileCode();
            }
            else if ( rbBBCode.Checked )
            {
                edtPromoteCode.Text = BBCodeCode();
            }
            else
            {
                edtPromoteCode.Text = HTMLCode();
            }
        }

        /// <summary>
        /// Return the URL for the work.
        /// </summary>
        /// <returns>The URL for the work.</returns>
        protected string WorkURL()
        {
            return ( rbView.Checked ? RBUtils.WorkURL( sUser, sWorkID ) : RBUtils.WorkBuyURL( sUser, sWorkID ) ).ToString();
        }

        /// <summary>
        /// Return the type of cropping for the image.
        /// </summary>
        /// <returns>The type of cropping.</returns>
        protected ArtCropping Cropping()
        {
            return cbCropped.Checked ? ArtCropping.Cropped : ArtCropping.None;
        }

        /// <summary>
        /// Return the size to use for the preview image.
        /// </summary>
        /// <returns>The size to use for the image.</returns>
        protected ArtSize ImageSize()
        {
            if ( rbExtraSmall.Checked )
            {
                return ArtSize.XSmall;
            }
            else if ( rbSmall.Checked )
            {
                return ArtSize.Small;
            }
            else if ( rbMedium.Checked )
            {
                return ArtSize.Medium;
            }
            else
            {
                return ArtSize.Large;
            }
        }

        /// <summary>
        /// Returns the backing colour for a card preview.
        /// </summary>
        /// <returns>The backing colour.</returns>
        protected BackingColour CardBackColour()
        {
            return rbBackBlack.Checked ? BackingColour.Black : BackingColour.White;
        }

        /// <summary>
        /// Returns the matte colour for a matted print.
        /// </summary>
        /// <returns>The matte colour.</returns>
        protected MatteColour MattedPrintMatteColour()
        {
            if ( rbMatteBlack.Checked )
            {
                return MatteColour.Black;
            }
            else if ( rbMatteBrightWhite.Checked )
            {
                return MatteColour.BrightWhite;
            }
            else
            {
                return MatteColour.OffWhite;
            }
        }

        /// <summary>
        /// Returns the border for a laminated print.
        /// </summary>
        /// <returns>The laminated print border.</returns>
        protected BorderColour LaminatedPrintBorder()
        {
            return rbLaminatedBorderWhite.Checked ? BorderColour.WhiteWithDetails : BorderColour.BlackWhiteDetails;
        }

        /// <summary>
        /// Returns the product size for a laminated print.
        /// </summary>
        /// <returns>The laminated print size.</returns>
        protected ArtSize LaminatedSize()
        {
            if ( rbLaminatedSmall.Checked )
            {
                return ArtSize.Small;
            }
            else if ( rbLaminatedMedium.Checked )
            {
                return ArtSize.Medium;
            }
            else
            {
                return ArtSize.Large;
            }
        }

        /// <summary>
        /// Returns the border for a mounted print.
        /// </summary>
        /// <returns>The mounted print border.</returns>
        protected BorderColour MountedPrintBorder()
        {
            if ( rbMountedNoBorder.Checked )
            {
                return BorderColour.None;
            }
            else if ( rbMountedWhiteBorder.Checked )
            {
                return BorderColour.WhiteWithDetails;
            }
            else
            {
                return BorderColour.BlackWhiteDetails;
            }
        }

        /// <summary>
        /// Return the frame colour for a framed print.
        /// </summary>
        /// <returns>The frame colour.</returns>
        protected FrameColour FramedPrintFrameColour()
        {
            if ( rbFrameBlack.Checked )
            {
                return FrameColour.Black;
            }
            else if ( rbFrameCharcoal.Checked )
            {
                return FrameColour.Charcoal;
            }
            else if ( rbFrameCherry.Checked )
            {
                return FrameColour.Cherry;
            }
            else if ( rbFrameMocha.Checked )
            {
                return FrameColour.Mocha;
            }
            else
            {
                return FrameColour.Walnut;
            }
        }

        /// <summary>
        /// Return the matte colour for a framed print.
        /// </summary>
        /// <returns>The matte colour.</returns>
        protected MatteColour FramedPrintMatteColour()
        {
            if ( rbFramedMatteBlack.Checked )
            {
                return MatteColour.Black;
            }
            else if ( rbFramedMatteBrightWhite.Checked )
            {
                return MatteColour.BrightWhite;
            }
            else
            {
                return MatteColour.OffWhite;
            }
        }

        /// <summary>
        /// Returns the product size for a framed print.
        /// </summary>
        /// <returns>The framed print size.</returns>
        protected ArtSize FramedSize()
        {
            if ( rbFramedSmall.Checked )
            {
                return ArtSize.Small;
            }
            else if ( rbFramedMedium.Checked )
            {
                return ArtSize.Medium;
            }
            else
            {
                return ArtSize.Large;
            }
        }

        /// <summary>
        /// Return the URL for the image.
        /// </summary>
        /// <returns>The URL for the image.</returns>
        protected string ImageURL()
        {
            string sURL = "";

            switch ( tcTypes.SelectedIndex )
            {
                case 0 : 
                    sURL = RBUtils.WorkImageURL( sWorkID, Cropping(), ImageSize() ).ToString();
                    break;
                case 1 : 
                    sURL = RBUtils.CardPreviewURL( sWorkID, CardBackColour(), pnlCardBackColourPreview.BackColor ).ToString();
                    break;
                case 2 :
                    sURL = RBUtils.MattedPrintPreviewURL( sWorkID, MattedPrintMatteColour() ).ToString();
                    break;
                case 3 :
                    sURL = RBUtils.LaminatedPrintPreviewURL( sWorkID, LaminatedPrintBorder(), LaminatedSize() ).ToString();
                    break;
                case 4 :
                    sURL = RBUtils.MountedPrintPreviewURL( sWorkID, MountedPrintBorder() ).ToString();
                    break;
                case 5 :
                    sURL = RBUtils.CanvasPrintPreviewURL( sWorkID ).ToString();
                    break;
                case 6 :
                    sURL = RBUtils.FramedPrintPreviewURL( sWorkID, FramedPrintFrameColour(), FramedPrintMatteColour(), FramedSize() ).ToString();
                    break;
            }

            // .NET's Uri class seems to want to unescape spaces. Escape them again.
            // Yeah, I know it's horrible.
            return sURL.Replace( " ", "%20" );
        }

        /// <summary>
        /// Return Textile promotion code.
        /// </summary>
        /// <returns>The Textile promotion code.</returns>
        protected string TextileCode()
        {
            return "!" + ImageURL() + "!:" + WorkURL();
        }

        /// <summary>
        /// Return BBCode promotion code.
        /// </summary>
        /// <returns>The BBCode promotion code.</returns>
        protected string BBCodeCode()
        {
            return "[url=" + WorkURL() + "][img]" + ImageURL() + "[/img][/url]";
        }

        /// <summary>
        /// Return HTML promotion code.
        /// </summary>
        /// <returns>The HTML promotion code.</returns>
        protected string HTMLCode()
        {
            return "<a href=\"" + WorkURL() + "\"><img src=\"" + ImageURL() + "\" /></a>";
        }

        /// <summary>
        /// Refresh the promotion code when something changes.
        /// </summary>
        /// <param name="sender">The object sending the event.</param>
        /// <param name="e">The event.</param>
        private void codeStyleChanged( object sender, EventArgs e )
        {
            GenerateCode();
        }

        /// <summary>
        /// Copy the promotion code to the clipboard.
        /// </summary>
        /// <param name="sender">The object sending the event.</param>
        /// <param name="e">The event.</param>
        private void btnClipboard_Click( object sender, EventArgs e )
        {
            Clipboard.SetText( edtPromoteCode.Text );
        }

        /// <summary>
        /// Close the dialog.
        /// </summary>
        /// <param name="sender">The object sending the event.</param>
        /// <param name="e">The event.</param>
        private void btnClose_Click( object sender, EventArgs e )
        {
            // Close our window.
            Close();
        }

        /// <summary>
        /// Preview the current promotion code.
        /// </summary>
        /// <param name="sender">The object sending the event.</param>
        /// <param name="e">The event.</param>
        private void btnPreview_Click( object sender, EventArgs e )
        {
            // If we don't have a preview form...
            if ( preview == null )
            {
                // ...create it...
                preview = new frmPromoteWorkPreview();
                // ...hook into it closing...
                preview.FormClosed += catchPreviewClose;
                // ...and show it.
                preview.Show();
            }
            else
            {
                preview.Focus();
            }

            // Bung the preview HTML code into the browser.
            preview.Preview( "<center><img src=\"" + ImageURL() + "\" /></center>" );
        }

        /// <summary>
        /// Catches the close of the preview window.
        /// </summary>
        /// <param name="sender">The object sending the event.</param>
        /// <param name="e">The event.</param>
        private void catchPreviewClose( object sender, EventArgs e )
        {
            preview = null;
        }

        /// <summary>
        /// Cleans things up when we close.
        /// </summary>
        /// <param name="sender">The object sending the event.</param>
        /// <param name="e">The event.</param>
        private void frmPromoteWork_FormClosed( object sender, FormClosedEventArgs e )
        {
            // Close the preview window if it is open.
            if ( preview != null ) preview.Close();
        }

        /// <summary>
        /// Pick a background colour for the card preview image.
        /// </summary>
        /// <param name="sender">The object sending the event.</param>
        /// <param name="e">The event.</param>
        /// <remarks>Note that this is current disabled as RedBubble don't appear to
        /// provide the full range of background colours.</remarks>
        private void btnPickCardBackColour_Click( object sender, EventArgs e )
        {
            if ( cdImagebackground.ShowDialog() == DialogResult.OK )
            {
                pnlCardBackColourPreview.BackColor = cdImagebackground.Color;
            }
        }
    }
}