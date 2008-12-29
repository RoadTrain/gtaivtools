﻿/**********************************************************************\

 Spark IV
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

using System.Windows.Forms;
using System.Text;
using System.Drawing;
using RageLib.FileSystem.Common;

namespace SparkIV.Viewer
{
    class TextViewer : IViewer
    {
        string[] _supportedExtensions = new[] 
            {
                "dat", "txt", "ide", "ipl", "ped", "cmb", "csv", "ini", "list", "dcl", "sps"
            };

        public bool SupportsExtension(string extension)
        {
            foreach (string viewer in _supportedExtensions)
            {
                if (viewer == extension)
                {
                    return true;
                }
            }
            return false;
        }

        public Control GetView(File file)
        {
            var data = file.GetData();

            TextBox textBox = new TextBox();
            textBox.Font = new Font("Courier New", 10);
            textBox.ReadOnly = true;
            textBox.BackColor = SystemColors.Window;
            textBox.Text = Encoding.ASCII.GetString(data);
            textBox.Multiline = true;
            textBox.ScrollBars = ScrollBars.Both;
            textBox.SelectionStart = 0;
            textBox.SelectionLength = 0;
            textBox.WordWrap = false;
            return textBox;
        }
    }
}
