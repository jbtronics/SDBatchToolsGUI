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
    public partial class MainForm : Form
    {
        Sbsrender _sbsrender = new Sbsrender();
        Sbsbaker _sbsbaker = new Sbsbaker();
        Sbsmutator _sbsmutator = new Sbsmutator();
        Sbscooker _sbscooker = new Sbscooker();

        Process _proc;

        public MainForm()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            combo_mutator_mode.SelectedIndex = 1;
            combo_baker_mode.SelectedIndex = 0;

            //These mutator boxes are disabled by default, default is info mode
            txt_mutator_alias.Enabled = false;
            txt_mutator_connect_image.Enabled = false;
            txt_mutator_connect_input.Enabled = false;
            txt_mutator_graph_name.Enabled = false;
            txt_mutator_output_name.Enabled = false;
            txt_mutator_output_path.Enabled = false;
            txt_mutator_presets.Enabled = false;
            txt_mutator_set_default.Enabled = false;
            txt_mutator_switch_to_constant.Enabled = false;
            txt_mutator_input_graph.Enabled = false;
        }

        private void tab_manager_Selected(object sender, TabControlEventArgs e)
        {
            switch (e.TabPage.Text)
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

                //Add infos on Output start
                if (Properties.Settings.Default.output_info)
                {
                    txt_output.Text += "Command: " + cmd + "\r\n";
                    txt_output.Text += "Started on " + DateTime.Now.ToString() + "\r\n";
                    txt_output.Text += "==================================================\r\n\r\n";
                }

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

        private void combo_baker_mode_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = combo_baker_mode.SelectedIndex;

            if (i == 0)
            {
                _sbsbaker.Mode = Sbsbaker.Modes.ambient_occlusion;
            }
            else if (i == 1)
            {
                _sbsbaker.Mode = Sbsbaker.Modes.ambient_occlusion_from_mesh;
            }
            else if (i == 2)
            {
                _sbsbaker.Mode = Sbsbaker.Modes.bent_normal_from_mesh;
            }
            else if (i == 3)
            {
                _sbsbaker.Mode = Sbsbaker.Modes.color_from_mesh;
            }
            else if (i == 4)
            {
                _sbsbaker.Mode = Sbsbaker.Modes.curvature;
            }
            else if (i == 5)
            {
                _sbsbaker.Mode = Sbsbaker.Modes.height_from_mesh;
            }
            else if (i == 6)
            {
                _sbsbaker.Mode = Sbsbaker.Modes.normal_from_mesh;
            }
            else if (i == 7)
            {
                _sbsbaker.Mode = Sbsbaker.Modes.normal_world_space;
            }
            else if (i == 8)
            {
                _sbsbaker.Mode = Sbsbaker.Modes.opacity_mask_from_mesh;
            }
            else if (i == 9)
            {
                _sbsbaker.Mode = Sbsbaker.Modes.position;
            }
            else if (i == 10)
            {
                _sbsbaker.Mode = Sbsbaker.Modes.texture_from_mesh;
            }
            else if (i == 11)
            {
                _sbsbaker.Mode = Sbsbaker.Modes.thickness_from_mesh;
            }
            else if (i == 12)
            {
                _sbsbaker.Mode = Sbsbaker.Modes.uv_map;
            }
            else if (i == 13)
            {
                _sbsbaker.Mode = Sbsbaker.Modes.world_space_direction;
            }

            updateCMDLine(_sbsbaker);
        }

        private void txt_baker_input_TextChanged(object sender, EventArgs e)
        {
            _sbsbaker.InputMesh = txt_baker_input.Text;
            updateCMDLine(_sbsbaker);
        }

        private void btn_baker_input_select_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "OBJ file|*.obj|FBX File|*.fbx";
            openFileDialog1.Title = "Select a Mesh";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txt_baker_input.Text = openFileDialog1.FileName;

                if (_sbsbaker.OutputPath == "")
                {
                    _sbsbaker.OutputPath = System.IO.Path.GetDirectoryName(openFileDialog1.FileName);
                    updateCMDLine(_sbscooker);
                }
            }
        }

        private void combo_baker_fileformat_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _sbsbaker.OutputFormat = (Tools.RenderOutputFormat)combo_baker_fileformat.SelectedIndex;
            }
            catch (Exception) { }


            if (_sbsbaker.OutputFormat == Tools.RenderOutputFormat.dds)
            {
                combo_baker_compression.Enabled = true;
            }
            else
            {
                combo_baker_compression.Enabled = false;
            }

            updateCMDLine(_sbsbaker);
        }

        private void combo_baker_compression_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _sbsbaker.DDSCompression = (Tools.DDSCompression)combo_baker_compression.SelectedIndex;
            }
            catch (Exception) { }

            updateCMDLine(_sbsbaker);
        }

        private void txt_baker_additional_TextChanged(object sender, EventArgs e)
        {
            _sbsbaker.AdditionalParams = txt_baker_additional.Text;
            updateCMDLine(_sbsbaker);
        }

        private void txt_baker_input_select_TextChanged(object sender, EventArgs e)
        {
            _sbsbaker.InputSelection = txt_baker_input_select.Text;
            updateCMDLine(_sbsbaker);
        }

        private void txt_baker_output_path_TextChanged(object sender, EventArgs e)
        {
            _sbsbaker.OutputPath = txt_baker_output_path.Text;
            updateCMDLine(_sbsbaker);
        }

        private void txt_baker_output_name_TextChanged(object sender, EventArgs e)
        {
            _sbsbaker.OutputName = txt_baker_output_name.Text;
            updateCMDLine(_sbsbaker);
        }

        private void txt_baker_tangent_space_TextChanged(object sender, EventArgs e)
        {
            _sbsbaker.TangentSpacePlugin = txt_baker_tangent_space.Text;
            updateCMDLine(_sbsbaker);
        }

        private void btn_baker_output_path_select_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowNewFolderButton = true;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txt_baker_output_path.Text = fbd.SelectedPath;
                _sbsbaker.OutputPath = fbd.SelectedPath;

                updateCMDLine(_sbsbaker);
            }
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

        private void txt_cooker_additional_TextChanged(object sender, EventArgs e)
        {
            _sbscooker.AdditionalParams = txt_cooker_additional.Text;
            updateCMDLine(_sbscooker);
        }

        private void check_cooker_merge_CheckedChanged(object sender, EventArgs e)
        {
            _sbscooker.Merge = check_cooker_merge.Checked;
            updateCMDLine(_sbscooker);
        }

        private void check_cooker_archive_CheckedChanged(object sender, EventArgs e)
        {
            _sbscooker.NoArchive = check_cooker_archive.Checked;
            updateCMDLine(_sbscooker);
        }

        private void check_cooker_optimation_CheckedChanged(object sender, EventArgs e)
        {
            _sbscooker.NoOptimation = check_cooker_optimation.Checked;
            updateCMDLine(_sbscooker);
        }

        private void check_cooker_output_size_CheckedChanged(object sender, EventArgs e)
        {
            _sbscooker.ExposeOutputSize = check_cooker_output_size.Checked;
            updateCMDLine(_sbscooker);
        }

        private void check_cooker_random_seed_CheckedChanged(object sender, EventArgs e)
        {
            _sbscooker.ExposeRandomSeed = check_cooker_random_seed.Checked;
            updateCMDLine(_sbscooker);
        }

        private void check_expose_pixel_size_CheckedChanged(object sender, EventArgs e)
        {
            _sbscooker.ExposePixelSize = check_cooker_pixel_size.Checked;
            updateCMDLine(_sbscooker);
        }

        private void btn_cooker_input_select_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Substance File|*.sbs";
            openFileDialog1.Title = "Select a Substance Editor File";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txt_cooker_input.Text = openFileDialog1.FileName;

                if (_sbscooker.OutputPath == "")
                {
                    _sbscooker.OutputPath = System.IO.Path.GetDirectoryName(openFileDialog1.FileName);
                    updateCMDLine(_sbscooker);
                }
            }
        }

        private void txt_cooker_input_TextChanged(object sender, EventArgs e)
        {
            _sbscooker.InputFile = txt_cooker_input.Text;
            updateCMDLine(_sbscooker);
        }

        private void txt_cooker_output_folder_TextChanged(object sender, EventArgs e)
        {
            _sbscooker.OutputPath = txt_cooker_output_folder.Text;
            updateCMDLine(_sbscooker);
        }

        private void btn_cooker_output_folder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowNewFolderButton = true;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txt_cooker_output_folder.Text = fbd.SelectedPath;
            }
        }

        private void txt_cooker_output_name_TextChanged(object sender, EventArgs e)
        {
            _sbscooker.OutputName = txt_cooker_output_name.Text;
            updateCMDLine(_sbscooker);
        }

        private void txt_cooker_sizelimit_TextChanged(object sender, EventArgs e)
        {
            _sbscooker.SizeLimit = txt_cooker_sizelimit.Text;
            updateCMDLine(_sbscooker);
        }

        private void txt_cooker_alias_TextChanged(object sender, EventArgs e)
        {
            _sbscooker.Alias = txt_cooker_alias.Text;
            updateCMDLine(_sbscooker);
        }

        private void txt_cooker_includes_TextChanged(object sender, EventArgs e)
        {
            _sbscooker.IncludesDir = txt_cooker_includes.Text;
            updateCMDLine(_sbscooker);
        }

        private void btn_cooker_includes_select_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowNewFolderButton = true;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txt_cooker_includes.Text = Tools.formatPath(fbd.SelectedPath);
            }
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

        private void txt_mutator_additional_TextChanged(object sender, EventArgs e)
        {
            _sbsmutator.AdditionalParams = txt_mutator_additional.Text;
            updateCMDLine(_sbsmutator);
        }

        private void combo_mutator_mode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_mutator_mode.SelectedIndex == 0)
            {
                _sbsmutator.Mode = Sbsmutator.Modes.graph_parameters_editor;

                check_mutator_merge.Enabled = false;
                check_mutator_hide_params.Enabled = false;
                check_mutator_depend.Enabled = false;

                txt_mutator_alias.Enabled = true;
                txt_mutator_connect_image.Enabled = false;
                txt_mutator_connect_input.Enabled = false;
                txt_mutator_graph_name.Enabled = false;
                txt_mutator_output_name.Enabled = true;
                txt_mutator_output_path.Enabled = true;
                txt_mutator_presets.Enabled = true;
                txt_mutator_set_default.Enabled = true;
                txt_mutator_switch_to_constant.Enabled = true;
                txt_mutator_input_graph.Enabled = true;
            }

            else if (combo_mutator_mode.SelectedIndex == 1)
            {
                _sbsmutator.Mode = Sbsmutator.Modes.info;

                check_mutator_merge.Enabled = false;
                check_mutator_hide_params.Enabled = false;
                check_mutator_depend.Enabled = false;

                txt_mutator_alias.Enabled = false;
                txt_mutator_connect_image.Enabled = false;
                txt_mutator_connect_input.Enabled = false;
                txt_mutator_graph_name.Enabled = false;
                txt_mutator_output_name.Enabled = false;
                txt_mutator_output_path.Enabled = false;
                txt_mutator_presets.Enabled = false;
                txt_mutator_set_default.Enabled = false;
                txt_mutator_switch_to_constant.Enabled = false;
                txt_mutator_input_graph.Enabled = false;
            }

            else if (combo_mutator_mode.SelectedIndex == 2)
            {
                _sbsmutator.Mode = Sbsmutator.Modes.specialization;

                check_mutator_merge.Enabled = true;
                check_mutator_hide_params.Enabled = true;
                check_mutator_depend.Enabled = false;

                txt_mutator_alias.Enabled = true;
                txt_mutator_connect_image.Enabled = true;
                txt_mutator_connect_input.Enabled = true;
                txt_mutator_graph_name.Enabled = true;
                txt_mutator_output_name.Enabled = true;
                txt_mutator_output_path.Enabled = true;
                txt_mutator_presets.Enabled = true;
                txt_mutator_set_default.Enabled = false;
                txt_mutator_switch_to_constant.Enabled = false;
                txt_mutator_input_graph.Enabled = true;
            }

            else if (combo_mutator_mode.SelectedIndex == 3)
            {
                _sbsmutator.Mode = Sbsmutator.Modes.update;

                check_mutator_merge.Enabled = false;
                check_mutator_hide_params.Enabled = false;
                check_mutator_depend.Enabled = true;

                txt_mutator_alias.Enabled = true;
                txt_mutator_connect_image.Enabled = false;
                txt_mutator_connect_input.Enabled = false;
                txt_mutator_graph_name.Enabled = false;
                txt_mutator_output_name.Enabled = true;
                txt_mutator_output_path.Enabled = true;
                txt_mutator_presets.Enabled = true;
                txt_mutator_set_default.Enabled = false;
                txt_mutator_switch_to_constant.Enabled = false;
                txt_mutator_input_graph.Enabled = false;
            }

            updateCMDLine(_sbsmutator);


        }

        private void check_mutator_hide_params_CheckedChanged(object sender, EventArgs e)
        {
            _sbsmutator.HideParameters = check_mutator_hide_params.Checked;
            updateCMDLine(_sbsmutator);
        }

        private void check_mutator_merge_CheckedChanged(object sender, EventArgs e)
        {
            _sbsmutator.OutputMerge = check_mutator_merge.Checked;
            updateCMDLine(_sbsmutator);
        }

        private void check_mutator_depend_CheckedChanged(object sender, EventArgs e)
        {
            _sbsmutator.NoDependency = check_mutator_depend.Checked;
            updateCMDLine(_sbsmutator);
        }

        private void txt_mutator_input_TextChanged(object sender, EventArgs e)
        {
            _sbsmutator.InputFile = txt_mutator_input.Text;
            updateCMDLine(_sbsmutator);
        }

        private void txt_mutator_output_path_TextChanged(object sender, EventArgs e)
        {
            _sbsmutator.OutputPath = txt_mutator_output_path.Text;
            updateCMDLine(_sbsmutator);
        }

        private void txt_mutator_output_name_TextChanged(object sender, EventArgs e)
        {
            _sbsmutator.OutputName = txt_mutator_output_name.Text;
            updateCMDLine(_sbsmutator);
        }

        private void btn_mutator_input_select_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Substance File|*.sbs";
            openFileDialog1.Title = "Select a Substance Editor File";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txt_mutator_input.Text = openFileDialog1.FileName;

                if (_sbsmutator.OutputPath == "")
                {
                    _sbsmutator.OutputPath = System.IO.Path.GetDirectoryName(openFileDialog1.FileName);
                    updateCMDLine(_sbsmutator);
                }
            }
        }

        private void txt_mutator_input_graph_TextChanged(object sender, EventArgs e)
        {
            _sbsmutator.InputGraph = txt_mutator_input_graph.Text;
            updateCMDLine(_sbsmutator);
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


        private void txt_render_additional_TextChanged(object sender, EventArgs e)
        {
            _sbsrender.AdditionalParams = txt_render_additional.Text;
            updateCMDLine(_sbsrender);
        }

        private void radio_render_info_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_render_info.Checked)
            {
                _sbsrender.Mode = Sbsrender.SbsrenderModes.info;
                updateCMDLine(_sbsrender);

                txt_render_engine.Enabled = false;
                txt_render_entry_id.Enabled = false;
                txt_render_entry_path.Enabled = false;
                txt_render_graph.Enabled = false;
                txt_render_output.Enabled = false;
                txt_render_output_name.Enabled = false;
                txt_render_output_size.Enabled = false;
                txt_render_pixel_size.Enabled = false;
                txt_render_seed.Enabled = false;
                txt_render_values.Enabled = false;
                txt_render_graph_output.Enabled = false;
                numeric_render_budget.Enabled = false;
                combo_render_compression.Enabled = false;
                combo_render_fileformat.Enabled = false;
            }
        }

        private void radio_render_render_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_render_render.Checked)
            {
                _sbsrender.Mode = Sbsrender.SbsrenderModes.render;
                updateCMDLine(_sbsrender);

                txt_render_engine.Enabled = true;
                txt_render_entry_id.Enabled = true;
                txt_render_entry_path.Enabled = true;
                txt_render_graph.Enabled = true;
                txt_render_output.Enabled = true;
                txt_render_output_name.Enabled = true;
                txt_render_output_size.Enabled = true;
                txt_render_pixel_size.Enabled = true;
                txt_render_seed.Enabled = true;
                txt_render_values.Enabled = true;
                txt_render_graph_output.Enabled = true;
                numeric_render_budget.Enabled = true;
                combo_render_compression.Enabled = false;
                combo_render_fileformat.Enabled = true;
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

                if (_sbsrender.OutputPath == "")
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
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txt_render_output.Text = fbd.SelectedPath;
                _sbsrender.OutputPath = fbd.SelectedPath;

                updateCMDLine(_sbsrender);
            }
        }

        private void combo_render_fileformat_SelectedValueChanged(object sender, EventArgs e)
        {
            Tools.RenderOutputFormat format;

            try
            {
                format = (Tools.RenderOutputFormat)combo_render_fileformat.SelectedIndex;
            }
            catch (Exception)
            {
                format = Tools.RenderOutputFormat.unset;
            }

            _sbsrender.OutputFormat = format;
            updateCMDLine(_sbsrender);


            if (_sbsrender.OutputFormat == Tools.RenderOutputFormat.dds)
                combo_render_compression.Enabled = true;
            else
                combo_render_compression.Enabled = false;

        }


        private void combo_render_compression_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tools.DDSCompression format;

            try
            {
                format = (Tools.DDSCompression)combo_render_compression.SelectedIndex;
            }
            catch (Exception)
            {
                format = Tools.DDSCompression.unset;
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
            if (builder.ShowDialog() == DialogResult.OK)
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

        private void txt_render_input_TextChanged(object sender, EventArgs e)
        {
            _sbsrender.InputFile = txt_render_input.Text;
            updateCMDLine(_sbsrender);
        }

        private void txt_render_output_TextChanged(object sender, EventArgs e)
        {
            _sbsrender.OutputPath = txt_render_output.Text;
            updateCMDLine(_sbsrender);
        }

        private void btn_output_path_select_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowNewFolderButton = true;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txt_mutator_output_path.Text = fbd.SelectedPath;
            }
        }

        private void txt_mutator_graph_name_TextChanged(object sender, EventArgs e)
        {
            _sbsmutator.OutputGraphName = txt_mutator_graph_name.Text;
            updateCMDLine(_sbsmutator);
        }

        private void txt_mutator_alias_TextChanged(object sender, EventArgs e)
        {
            _sbsmutator.Alias = txt_mutator_alias.Text;
            updateCMDLine(_sbsmutator);
        }

        private void txt_mutator_presets_TextChanged(object sender, EventArgs e)
        {
            _sbsmutator.PresetsPath = txt_mutator_presets.Text;
            updateCMDLine(_sbsmutator);
        }

        private void btn_mutator_presets_select_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowNewFolderButton = true;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txt_mutator_presets.Text = fbd.SelectedPath;
            }
        }

        private void txt_mutator_switch_to_constant_TextChanged(object sender, EventArgs e)
        {
            _sbsmutator.SwitchToConstant = txt_mutator_switch_to_constant.Text;
            updateCMDLine(_sbsmutator);
        }

        private void txt_mutator_set_default_TextChanged(object sender, EventArgs e)
        {
            _sbsmutator.SetDefaultValue = txt_mutator_set_default.Text;
            updateCMDLine(_sbsmutator);
        }

        private void txt_mutator_connect_image_TextChanged(object sender, EventArgs e)
        {
            _sbsmutator.ConnectImage = txt_mutator_connect_image.Text;
            updateCMDLine(_sbsmutator);
        }

        private void txt_mutator_connect_input_TextChanged(object sender, EventArgs e)
        {
            _sbsmutator.ConnectInput = txt_mutator_connect_input.Text;
            updateCMDLine(_sbsmutator);
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
            catch (Exception) { }

        }

        private void clearOutputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearOutput();
        }

        private void stripitem_settings_Click(object sender, EventArgs e)
        {
            new Settings().Show();
        }

        private void openOutputFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {

            switch (tab_manager.SelectedTab.Text)
            {
                case "sbsrender":
                    if (_sbsrender.OutputPath != "" && _sbsrender.Mode == Sbsrender.SbsrenderModes.render)
                    {
                        Process.Start("explorer.exe", _sbsrender.OutputPath);
                    }
                    break;
                case "sbsmutator":
                    if (_sbsmutator.OutputPath != "" && _sbsmutator.Mode != Sbsmutator.Modes.info)
                    {
                        Process.Start("explorer.exe", _sbsmutator.OutputPath);
                    }
                    break;
                case "sbscooker":
                    if (_sbscooker.OutputPath != "")
                    {
                        Process.Start("explorer.exe", _sbscooker.OutputPath);
                    }
                    break;
                case "sbsbaker":
                    if(_sbsbaker.OutputPath !="")
                    {
                        Process.Start("explorer.exe", _sbsbaker.OutputPath);
                    }
                    break;
            }


        }


        private void creditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Credits().Show();
        }





        #endregion


       

        
    }

}
