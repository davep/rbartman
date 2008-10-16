/* File.......: RBArtDocument.cs
 * System.....: RBArtMan - Windows art manager for RedBubble.
 * Author.....: Dave Pearson <davep@davep.org>
 * Copyright..: Dave Pearson 2008
 * Description: Art document classes.
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

namespace RBArtMan
{
    /// <summary>
    /// Class that holds the details of an item of art.
    /// </summary>
    public class RBArtItem
    {
        /// <summary>
        /// The ID of the item of art.
        /// </summary>
        public string ID;

        /// <summary>
        /// The title of the item of work.
        /// </summary>
        public string Title;

        /// <summary>
        /// Constructor.
        /// </summary>
        public RBArtItem()
        {
            // GNDN
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="sID">The ID of the item of art.</param>
        /// <param name="sTitle">The title of the item of art.</param>
        /// <remarks>This constructor allows the passing of values as parameters.</remarks>
        public RBArtItem( string sID, string sTitle )
        {
            ID    = sID;
            Title = sTitle;
        }
    }

    /// <summary>
    /// Class that holds a list of items of art.
    /// </summary>
    public class RBArtItems : List<RBArtItem>
    {
    }

    /// <summary>
    /// Class that implements an art document.
    /// </summary>
    public class RBArtDocument
    {
        /// <summary>
        /// The user name for the RedBubble user.
        /// </summary>
        public string UserName = "";

        /// <summary>
        /// Date and time the works were last downloaded.
        /// </summary>
        public DateTime LastDownloaded = new DateTime( 0 );

        /// <summary>
        /// The list of items.
        /// </summary>
        public RBArtItems Items;

        /// <summary>
        /// Constructor.
        /// </summary>
        public RBArtDocument()
        {
            Items = new RBArtItems();
        }
    }
}
