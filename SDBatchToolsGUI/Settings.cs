// Copyright 2016 Jan Boehmer
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDBatchToolsGUI
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            SaveSettings();
            Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveSettings()
        {
            Properties.Settings.Default.tools_path = txt_tools_path.Text;
            Properties.Settings.Default.output_info = check_info.Checked;

            //Write the Settings to file
            Properties.Settings.Default.Save();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            txt_tools_path.Text = Properties.Settings.Default.tools_path;
            check_info.Checked = Properties.Settings.Default.output_info;

            //Set Dir Dialog to old path
            if (Properties.Settings.Default.tools_path!="")
            {
                folderBrowserDialog1.SelectedPath = Properties.Settings.Default.tools_path;
            }
        }

        private void btn_path_select_Click(object sender, EventArgs e)
        {
            var result = folderBrowserDialog1.ShowDialog();
            if(result == DialogResult.OK)
            {
                txt_tools_path.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        
    }
}
