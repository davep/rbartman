/* File.......: frmExportMediaRSS.cs
 * System.....: RBArtMan - Windows art manager for RedBubble.
 * Author.....: Dave Pearson <davep@davep.org>
 * Copyright..: Dave Pearson 2008
 * Description: Dialog for getting MediaRSS exporting information from the user.
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
    /// Dialog for getting the MediaRSS exporting information from the user.
    /// </summary>
    public partial class frmExportMediaRSS : Form
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public frmExportMediaRSS()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Should buy URLs be linked to?
        /// </summary>
        public bool Buy
        {
            get
            {
                return rbLinkToBuy.Checked;
            }
        }

        /// <summary>
        /// Should view URLs be linked to?
        /// </summary>
        public bool View
        {
            get
            {
                return !Buy;
            }
        }

        /// <summary>
        /// Title for the feed.
        /// </summary>
        public string Title
        {
            get
            {
                return edtTitle.Text.Trim();
            }
        }

        /// <summary>
        /// Link for the feed.
        /// </summary>
        public string Link
        {
            get
            {
                return edtLink.Text.Trim();
            }
            set
            {
                edtLink.Text = value;
            }
        }

        /// <summary>
        /// Author for the feed.
        /// </summary>
        public string Author
        {
            get
            {
                return edtAuthor.Text.Trim();
            }
        }

        /// <summary>
        /// Copyright message for the feed.
        /// </summary>
        public string Copyright
        {
            get
            {
                return edtCopyright.Text.Trim();
            }
        }
    }
}