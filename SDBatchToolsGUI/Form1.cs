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
using System.IO;

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


        private void Form1_Load(object sender, EventArgs e)
        {
            updateCMDLine(_sbsrender);
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
        

        #region Preview Line
        private void txt_preview_KeyDown(object sender, KeyEventArgs e)
        {
            //Execute Code on Enter
            if (e.KeyCode == Keys.Enter)
            {
                runCMD();
            }
        }

        private void updateCMDLine(IBatchTool tool)
        {
            txt_preview.Text = tool.getCmdLine();
        }

        private void btn_run_Click(object sender, EventArgs e)
        {
            runCMD();
        }
        #endregion

        #region Output Box
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
            //info.WorkingDirectory = Properties.Settings.Default.tools_path;
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

                //Redirect Output
                proc.OutputDataReceived += new DataReceivedEventHandler(OutputHandler);
                proc.ErrorDataReceived += new DataReceivedEventHandler(OutputHandler);
                proc.BeginOutputReadLine();
                proc.BeginErrorReadLine();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void clearOutput()
        {
            txt_output.Text = "";
        }

        private void printVersion(IBatchTool tool)
        {
            runCMD(tool.getVersionCmd());
        }

        private void printHelp(IBatchTool tool)
        {
            runCMD(tool.getHelpCmd());
        }
        #endregion

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
                _sbsrender.Mode = Sbsrender.SbsrenderModes.info;
                updateCMDLine(_sbsrender);
            }
        }

        private void radio_render_render_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_render_render.Checked)
            {
                _sbsrender.Mode = Sbsrender.SbsrenderModes.render;
                updateCMDLine(_sbsrender);
            }
        }

        private void btn_render_input_select_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Substance Archive File|*.sbsar";
            openFileDialog1.Title = "Select a Substance Archive";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // Assign the cursor in the Stream to the Form's Cursor property.
                txt_render_input.Text = openFileDialog1.FileName;
                _sbsrender.InputFile = openFileDialog1.FileName;

                if(_sbsrender.OutputPath=="")
                {
                    _sbsrender.OutputPath = System.IO.Path.GetDirectoryName(openFileDialog1.FileName);
                }

                updateCMDLine(_sbsrender);
            }

       }

        private void numeric_render_budget_ValueChanged(object sender, EventArgs e)
        {
            _sbsrender.MemoryBudget = Convert.ToInt32(numeric_render_budget.Value);
            updateCMDLine(_sbsrender);
        }

        private void btn_render_output_select_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowNewFolderButton = true;
            if(fbd.ShowDialog() == DialogResult.OK)
            {
                txt_render_output.Text = fbd.SelectedPath;
                _sbsrender.OutputPath = fbd.SelectedPath;

                updateCMDLine(_sbsrender);
            }
        }

        private void combo_render_fileformat_SelectedValueChanged(object sender, EventArgs e)
        {
            Sbsrender.RenderOutputFormat format;

            try
            { 
                format = (Sbsrender.RenderOutputFormat)combo_render_fileformat.SelectedIndex;
            }
            catch(Exception ex)
            {
                format = Sbsrender.RenderOutputFormat.unset;
            }          

            _sbsrender.OutputFormat = format;
            updateCMDLine(_sbsrender);
        }

        private void combo_render_compression_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sbsrender.DDSCompression format;

            try
            {
                format = (Sbsrender.DDSCompression)combo_render_compression.SelectedIndex;
            }
            catch (Exception ex)
            {
                format = Sbsrender.DDSCompression.unset;
            }

            _sbsrender.Compression = format;
            updateCMDLine(_sbsrender);
        }

        private void txt_render_engine_TextChanged(object sender, EventArgs e)
        {
            _sbsrender.Engine = txt_render_engine.Text;
            updateCMDLine(_sbsrender);
        }

        private void txt_render_output_name_TextChanged(object sender, EventArgs e)
        {
            _sbsrender.OutputName = txt_render_output_name.Text;
            updateCMDLine(_sbsrender);
        }

        private void btn_render_output_name_build_Click(object sender, EventArgs e)
        {
            var builder = new OutputNameBuilder();
            if(builder.ShowDialog() == DialogResult.OK)
            {
                txt_render_output_name.Text = builder.Result;
                _sbsrender.OutputName = builder.Result;
                updateCMDLine(_sbsrender);
            }
        }

        private void txt_render_graph_TextChanged(object sender, EventArgs e)
        {
            _sbsrender.InputGraph = txt_render_graph.Text;
            updateCMDLine(_sbsrender);
        }

        private void txt_render_graph_output_TextChanged(object sender, EventArgs e)
        {
            _sbsrender.InputGraphOutput = txt_render_graph_output.Text;
            updateCMDLine(_sbsrender);
        }

        private void txt_render_seed_TextChanged(object sender, EventArgs e)
        {
            _sbsrender.SetSeed = txt_render_seed.Text;
            updateCMDLine(_sbsrender);
        }

        private void btn_render_entry_path_select_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            //openFileDialog1.Filter = "Substance Archive File|*.sbsar";
            openFileDialog1.Title = "Select a Bitmap";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // Assign the cursor in the Stream to the Form's Cursor property.
                txt_render_entry_path.Text = openFileDialog1.FileName;
            }
        }

        private void txt_render_entry_path_TextChanged(object sender, EventArgs e)
        {
            _sbsrender.SetEntry = txt_render_entry_id.Text + "@" + Tools.formatPath(txt_render_entry_path.Text);
            updateCMDLine(_sbsrender);
        }


        private void txt_render_entry_id_TextChanged(object sender, EventArgs e)
        {
            _sbsrender.SetEntry = txt_render_entry_id.Text + "@" + Tools.formatPath(txt_render_entry_path.Text);
            updateCMDLine(_sbsrender);
        }

        private void txt_render_output_size_TextChanged(object sender, EventArgs e)
        {
            _sbsrender.SetResolution = txt_render_output_size.Text;
            updateCMDLine(_sbsrender);
        }

        private void txt_render_pixel_size_TextChanged(object sender, EventArgs e)
        {
            _sbsrender.SetPixelSize = txt_render_pixel_size.Text;
            updateCMDLine(_sbsrender);
        }

        private void txt_render_values_TextChanged(object sender, EventArgs e)
        {
            _sbsrender.SetValue = txt_render_values.Text;
            updateCMDLine(_sbsrender);
        }

        #endregion

        #region Toolstrip
        private void exportOutputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.AddExtension = true;
            sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            sfd.RestoreDirectory = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string name = sfd.FileName;
                File.WriteAllText(name, txt_output.Text);
            }

        }

        private void exportAsBATToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.AddExtension = true;
            sfd.Filter = "bat files (*.bat)|*.txt|All files (*.*)|*.*";
            sfd.RestoreDirectory = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string name = sfd.FileName;
                File.WriteAllText(name, txt_preview.Text);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void killProcessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _proc.Kill();
            }
            catch (Exception ex) { }

        }

        private void clearOutputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearOutput();
        }

        private void stripitem_settings_Click(object sender, EventArgs e)
        {
            new Settings().Show();
        }

        #endregion

       

       
    }
}
