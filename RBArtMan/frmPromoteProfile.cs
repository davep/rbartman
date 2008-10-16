/* File.......: frmPromoteProfile.cs
 * System.....: RBArtMan - Windows art manager for RedBubble.
 * Author.....: Dave Pearson <davep@davep.org>
 * Copyright..: Dave Pearson 2008
 * Description: Dialog for creating promote code for a profile.
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
    /// Profile promotion dialog.
    /// </summary>
    public partial class frmPromoteProfile : Form
    {
        /// <summary>
        /// The ID of the user we'll be promoting.
        /// </summary>
        internal string sUser;

        /// <summary>
        /// Constructor.
        /// </summary>
        public frmPromoteProfile()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Return the URL for the promotion image.
        /// </summary>
        /// <returns>The URL for the promotion image.</returns>
        protected string ImageURL()
        {
            return RBUtils.RBProfileURL( sUser ) + 
                "recipe:banner" +
                ( rbVertical.Checked ? ";orientation:vertical" : "" ) + "/" +
                sUser + "_banner.jpg";
        }

        /// <summary>
        /// Returns the Textile version of the promotion code.
        /// </summary>
        /// <returns>The Textile version of the promotion code.</returns>
        protected string TextileCode()
        {
            return "!" + ImageURL() + "!:" + RBUtils.RBProfileURL( sUser );
        }

        /// <summary>
        /// Returns the BBCode version of the promotion code.
        /// </summary>
        /// <returns>The BBCode version of the promotion code.</returns>
        protected string BBCodeCode()
        {
            return "[url=" + RBUtils.RBProfileURL( sUser ) + "][img]" + ImageURL() + "[/img][/url]";
        }

        /// <summary>
        /// Returns the HTML version of the promotion code.
        /// </summary>
        /// <returns>The HTML version of the promotion code.</returns>
        protected string HTMLCode()
        {
            return "<a href=\"" + RBUtils.RBProfileURL( sUser ) + "\"><img src=\"" + ImageURL() + "\" /></a>";
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
        /// Update the code when the user changes something.
        /// </summary>
        /// <param name="sender">Pointer to the control sending us the event.</param>
        /// <param name="e">The event.</param>
        private void codeStyleChanged( object sender, EventArgs e )
        {
            GenerateCode();
        }

        /// <summary>
        /// Close the dialog.
        /// </summary>
        /// <param name="sender">Pointer to the control sending us the event.</param>
        /// <param name="e">The event.</param>
        private void btnClose_Click( object sender, EventArgs e )
        {
            Close();
        }

        /// <summary>
        /// Copy the code to the clipboard.
        /// </summary>
        /// <param name="sender">Pointer to the control sending us the event.</param>
        /// <param name="e">The event.</param>
        private void btnClipboard_Click( object sender, EventArgs e )
        {
            Clipboard.SetText( edtPromoteCode.Text );
        }

        /// <summary>
        /// Set the dialog up after it's been shown.
        /// </summary>
        /// <param name="sender">Pointer to the control sending us the event.</param>
        /// <param name="e">The event.</param>
        private void frmPromoteProfile_Shown( object sender, EventArgs e )
        {
            GenerateCode();
        }
    }
}