/* File.......: frmAbout.cs
 * System.....: RBArtMan - Windows art manager for RedBubble.
 * Author.....: Dave Pearson <davep@davep.org>
 * Copyright..: Dave Pearson 2008
 * ID.........: $Id$
 * Description: About dialog.
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
    /// The about dialog for the application.
    /// </summary>
    public partial class frmAbout : Form
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public frmAbout()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sort out some things after the dialog is shown.
        /// </summary>
        /// <param name="sender">The object sending the event.</param>
        /// <param name="e">The event.</param>
        private void frmAbout_Shown( object sender, EventArgs e )
        {
            lblVersion.Text = String.Format( lblVersion.Text, Application.ProductVersion );
        }

        /// <summary>
        /// Handle a click on the URL for me.
        /// </summary>
        /// <param name="sender">The object sending the event.</param>
        /// <param name="e">The event.</param>
        private void lblDavePearson_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
        {
            Process.Start( "http://www.davep.org/" );
        }

        /// <summary>
        /// Visit the website of one of the testers.
        /// </summary>
        /// <param name="sender">The object sending the event.</param>
        /// <param name="e">The event.</param>
        private void VisitTester( object sender, LinkLabelLinkClickedEventArgs e )
        {
            Process.Start( (string) ( (LinkLabel) sender ).Tag );
        }
    }
}