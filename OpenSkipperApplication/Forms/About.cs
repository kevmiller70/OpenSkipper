﻿/*
	Copyright (C) 2009-2010, Andrew Mason <amas008@users.sourceforge.net>
	Copyright (C) 2009-2010, Jason Drake <jdra@users.sourceforge.net>

	This file is part of Open Skipper.
	
	Open Skipper is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    Open Skipper is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OpenSkipperApplication
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }



        private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText); 
        }

        private void button1_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void About_Load(object sender, EventArgs e) {
            labelVersion.Text = Application.ProductName.ToString() + " " + Application.ProductVersion.ToString(); // Major + "." + vrs.Minor + "." + vrs.Build + "." + vrs.Revision;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
