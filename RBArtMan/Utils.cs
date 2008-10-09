/* File.......: Utils.cs
 * System.....: RBArtMan - Windows art manager for RedBubble.
 * Author.....: Dave Pearson <davep@davep.org>
 * Copyright..: Dave Pearson 2008
 * ID.........: $Id$
 * Description: General utility classes.
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
using System.Windows.Forms;

namespace RBArtMan
{
    /// <summary>
    /// Class to manage the display of a busy cursor.
    /// </summary>
    public class BusyCursor : IDisposable
    {
        /// <summary>
        /// Holds the old cursor style.
        /// </summary>
        private Cursor OldCursor;

        /// <summary>
        /// Constructor.
        /// </summary>
        public BusyCursor()
        {
            // Save the current cursor.
            OldCursor = Cursor.Current;

            // Set the cursor to the waiting cursor.
            Cursor.Current = Cursors.WaitCursor;
        }

        /// <summary>
        /// Sets the cursor back to what it was.
        /// </summary>
        public void Dispose()
        {
            // reset the cursor.
            Cursor.Current = OldCursor;
        }
    }
}
