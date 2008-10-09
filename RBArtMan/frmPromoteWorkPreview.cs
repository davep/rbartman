/* File.......: frmPromoteWorkPreview.cs
 * System.....: RBArtMan - Windows art manager for RedBubble.
 * Author.....: Dave Pearson <davep@davep.org>
 * Copyright..: Dave Pearson 2008
 * ID.........: $Id$
 * Description: Art promotion preview window.
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
    /// Form that shows a preview of a promotion code.
    /// </summary>
    public partial class frmPromoteWorkPreview : Form
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public frmPromoteWorkPreview()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Preview the given URL.
        /// </summary>
        /// <param name="sHTML">The HTML to preview.</param>
        public void Preview( string sHTML )
        {
            Text                   = "Promotion Preview: Downloading from RedBubble, please wait";
            wbPreview.DocumentText = sHTML;
        }

        /// <summary>
        /// Do things once the promotion page has finished loading.
        /// </summary>
        /// <param name="sender">Pointer to the object sending the event.</param>
        /// <param name="e">The event.</param>
        private void wbPreview_DocumentCompleted( object sender, WebBrowserDocumentCompletedEventArgs e )
        {
            Text = "Promotion Preview";
        }
    }
}