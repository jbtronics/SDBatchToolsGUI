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
using SDBatchToolsHelper;
using System.Diagnostics;

namespace SDBatchToolsGUI
{
    public partial class Form1 : Form
    {
        Sbsrender _sbsrender = new Sbsrender();
        Sbsbaker _sbsbaker = new Sbsbaker();
        Sbsmutator _sbsmutator = new Sbsmutator();
        Sbscooker _sbscooker = new Sbscooker();

        Process _proc;

        public Form1()
        {
            InitializeComponent();
        }

        private void stripitem_settings_Click(object sender, EventArgs e)
        {
            new Settings().Show();
        }

        

        private void updateCMDLine(IBatchTool tool)
        {
            txt_preview.Text = tool.getCmdLine();
        }

        private void runCMD()
        {
            runCMD(txt_preview.Text);
        }

        private void runCMD(String cmd)
        {
            clearOutput();
            cmd = cmd.Trim();


            String filename, args;
            if (Environment.OSVersion.Platform == PlatformID.Unix
                || Environment.OSVersion.Platform == PlatformID.MacOSX)
            {
                int tmp = cmd.IndexOf(" ");
                filename = cmd.Substring(0, tmp);
                args = cmd.Substring(tmp);
            }
            else
            {
                //Seperate filename and parameters
                int tmp = cmd.IndexOf(".exe");
                tmp = tmp + 4;
                filename = cmd.Substring(0, tmp);
                args = cmd.Substring(tmp);
            }

            //Configure Processstart
            ProcessStartInfo info = new ProcessStartInfo();
            info.WorkingDirectory = Properties.Settings.Default.tools_path;
            info.Arguments = args;
            info.CreateNoWindow = true;
            info.RedirectStandardError = true;
            info.RedirectStandardOutput = true;
            info.UseShellExecute = false;

            if (Environment.OSVersion.Platform == PlatformID.Unix
                || Environment.OSVersion.Platform == PlatformID.MacOSX)
            {
                //Unix use other filepath seperators
                info.FileName = Properties.Settings.Default.tools_path + "/" + filename;
            }
            else
            {
                info.FileName = Properties.Settings.Default.tools_path + "\\" + filename;
            }

                try
            {
                var proc = Process.Start(info);
                _proc = proc;

                var handler = new DataReceivedEventHandler(OutputHandler);

                //Redirect Output
                proc.OutputDataReceived += handler;
                proc.ErrorDataReceived += handler;
                proc.BeginOutputReadLine();

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
        }

        void OutputHandler(object sender, DataReceivedEventArgs e)
        {
            
            Trace.WriteLine(e.Data);
            this.BeginInvoke(new MethodInvoker(() =>
            {
                txt_output.AppendText(e.Data ?? string.Empty);
                //For new line
                txt_output.AppendText("\r\n");
            }));
        }

        private void tab_manager_Selected(object sender, TabControlEventArgs e)
        {
            switch(e.TabPage.Text)
            {
                case "sbsrender":
                    updateCMDLine(_sbsrender);
                    break;
                case "sbsmutator":
                    updateCMDLine(_sbsmutator);
                    break;
                case "sbscooker":
                    updateCMDLine(_sbscooker);
                    break;
                case "sbsbaker":
                    updateCMDLine(_sbsbaker);
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updateCMDLine(_sbsrender);
        }

        private void btn_run_Click(object sender, EventArgs e)
        {
                runCMD();                 
        }

        private void clearOutput()
        {
            txt_output.Text = "";
        }

        private void clearOutputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearOutput();
        }

        private void killProcessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _proc.Kill();
            }
            catch(Exception ex) { }
        
        }

        private void printVersion(IBatchTool tool)
        {
            runCMD(tool.getVersionCmd());
        }

        private void printHelp(IBatchTool tool)
        {
            runCMD(tool.getHelpCmd());
        }

        #region sbsbaker

        private void btn_baker_version_Click(object sender, EventArgs e)
        {
            printVersion(_sbsbaker);
        }

        private void btn_baker_help_Click(object sender, EventArgs e)
        {
            printHelp(_sbsbaker);
        }


        #endregion

        #region sbscooker
        private void btn_cooker_version_Click(object sender, EventArgs e)
        {
            printVersion(_sbscooker);
        }

        private void btn_cooker_help_Click(object sender, EventArgs e)
        {
            printHelp(_sbscooker);
        }

        #endregion

        #region sbsmutator

        private void btn_mutator_version_Click(object sender, EventArgs e)
        {
            printVersion(_sbsmutator);
        }

        private void btn_mutator_help_Click(object sender, EventArgs e)
        {
            printHelp(_sbsmutator);
        }

        #endregion

        #region sbsrender
        private void btn_render_version_Click(object sender, EventArgs e)
        {
            printVersion(_sbsrender);
        }

        private void btn_render_help_Click(object sender, EventArgs e)
        {
            printHelp(_sbsrender);
        }

        private void radio_render_info_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_render_info.Checked)
            {
                _sbsrender.Mode = SbsrenderModes.info;
                updateCMDLine(_sbsrender);
            }
        }

        private void radio_render_render_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_render_render.Checked)
            {
                _sbsrender.Mode = SbsrenderModes.render;
                updateCMDLine(_sbsrender);
            }
        }


        #endregion

        

        private void txt_preview_KeyDown(object sender, KeyEventArgs e)
        {
            //Execute Code on Enter
            if (e.KeyCode == Keys.Enter)
            {
                runCMD();
            }                
        }
    }
}
