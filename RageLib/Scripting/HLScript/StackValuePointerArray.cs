﻿/**********************************************************************\

 RageLib
 Copyright (C) 2008  Arushan/Aru <oneforaru at gmail.com>

 This program is free software: you can redistribute it and/or modify
 it under the terms of the GNU General Public License as published by
 the Free Software Foundation, either version 3 of the License, or
 (at your option) any later version.

 This program is distributed in the hope that it will be useful,
 but WITHOUT ANY WARRANTY; without even the implied warranty of
 MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 GNU General Public License for more details.

 You should have received a copy of the GNU General Public License
 along with this program.  If not, see <http://www.gnu.org/licenses/>.

\**********************************************************************/

using System.Text;

namespace RageLib.Scripting.HLScript
{
    internal class StackValuePointerArray : StackValuePointerBase
    {
        public StackValuePointerArray(StackValuePointerBase pointer, StackValue index, int itemSize)
        {
            Pointer = pointer;
            Index = index;
            ItemSize = itemSize;
        }

        public StackValuePointerBase Pointer { get; set; }
        public int ItemSize { get; set; }
        public StackValue Index { get; set; }

        public override string GetDisplayText()
        {
            var sb = new StringBuilder();
            
            if (Pointer is StackValuePointerFake)
            {
                sb.Append("(");
                sb.Append(Pointer.GetDisplayText());
                sb.Append(")");
            }
            else
            {
                sb.Append(Pointer.GetDisplayText());
            }
            
            sb.Append("[");
            sb.Append(Index.ToString());
            if (ItemSize > 1)
            {
                sb.Append(" * ");
                sb.Append(ItemSize);
            }
            sb.Append("]");

            return sb.ToString();
        }
    }
}