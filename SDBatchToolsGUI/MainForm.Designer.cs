namespace SDBatchToolsGUI
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportOutputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportAsBATToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.openOutputFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stripitem_settings = new System.Windows.Forms.ToolStripMenuItem();
            this.clearOutputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.killProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tab_manager = new System.Windows.Forms.TabControl();
            this.tab_baker = new System.Windows.Forms.TabPage();
            this.btn_baker_input_select = new System.Windows.Forms.Button();
            this.txt_baker_input = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.group_baker_mode = new System.Windows.Forms.GroupBox();
            this.combo_baker_mode = new System.Windows.Forms.ComboBox();
            this.btn_baker_help = new System.Windows.Forms.Button();
            this.btn_baker_version = new System.Windows.Forms.Button();
            this.tab_cooker = new System.Windows.Forms.TabPage();
            this.btn_cooker_includes_select = new System.Windows.Forms.Button();
            this.txt_cooker_includes = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txt_cooker_alias = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txt_cooker_sizelimit = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txt_cooker_output_name = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.btn_cooker_output_folder = new System.Windows.Forms.Button();
            this.txt_cooker_output_folder = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btn_cooker_input_select = new System.Windows.Forms.Button();
            this.txt_cooker_input = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.check_cooker_archive = new System.Windows.Forms.CheckBox();
            this.check_cooker_merge = new System.Windows.Forms.CheckBox();
            this.check_cooker_pixel_size = new System.Windows.Forms.CheckBox();
            this.check_cooker_random_seed = new System.Windows.Forms.CheckBox();
            this.check_cooker_output_size = new System.Windows.Forms.CheckBox();
            this.check_cooker_optimation = new System.Windows.Forms.CheckBox();
            this.btn_cooker_help = new System.Windows.Forms.Button();
            this.btn_cooker_version = new System.Windows.Forms.Button();
            this.tab_mutator = new System.Windows.Forms.TabPage();
            this.label34 = new System.Windows.Forms.Label();
            this.txt_mutator_input_graph = new System.Windows.Forms.TextBox();
            this.txt_mutator_connect_input = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.txt_mutator_connect_image = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.txt_mutator_set_default = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.txt_mutator_switch_to_constant = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.btn_mutator_presets_select = new System.Windows.Forms.Button();
            this.txt_mutator_presets = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.txt_mutator_graph_name = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.txt_mutator_alias = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.check_mutator_depend = new System.Windows.Forms.CheckBox();
            this.check_mutator_merge = new System.Windows.Forms.CheckBox();
            this.check_mutator_hide_params = new System.Windows.Forms.CheckBox();
            this.txt_mutator_output_name = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.btn_output_path_select = new System.Windows.Forms.Button();
            this.txt_mutator_output_path = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.btn_mutator_input_select = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.txt_mutator_input = new System.Windows.Forms.TextBox();
            this.group_mutator_mode = new System.Windows.Forms.GroupBox();
            this.combo_mutator_mode = new System.Windows.Forms.ComboBox();
            this.btn_mutator_help = new System.Windows.Forms.Button();
            this.btn_mutator_version = new System.Windows.Forms.Button();
            this.tab_render = new System.Windows.Forms.TabPage();
            this.txt_render_values = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_render_pixel_size = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_render_output_size = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btn_render_entry_path_select = new System.Windows.Forms.Button();
            this.txt_render_entry_path = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_render_entry_id = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_render_seed = new System.Windows.Forms.TextBox();
            this.btn_render_output_name_build = new System.Windows.Forms.Button();
            this.txt_render_output_name = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_render_graph_output = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_render_graph = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.numeric_render_budget = new System.Windows.Forms.NumericUpDown();
            this.txt_render_engine = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.combo_render_compression = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.combo_render_fileformat = new System.Windows.Forms.ComboBox();
            this.btn_render_output_select = new System.Windows.Forms.Button();
            this.txt_render_output = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_render_input_select = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_render_input = new System.Windows.Forms.TextBox();
            this.group_render_mode = new System.Windows.Forms.GroupBox();
            this.radio_render_render = new System.Windows.Forms.RadioButton();
            this.radio_render_info = new System.Windows.Forms.RadioButton();
            this.btn_render_help = new System.Windows.Forms.Button();
            this.btn_render_version = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_output = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_preview = new System.Windows.Forms.TextBox();
            this.btn_run = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tab_manager.SuspendLayout();
            this.tab_baker.SuspendLayout();
            this.group_baker_mode.SuspendLayout();
            this.tab_cooker.SuspendLayout();
            this.tab_mutator.SuspendLayout();
            this.group_mutator_mode.SuspendLayout();
            this.tab_render.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_render_budget)).BeginInit();
            this.group_render_mode.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.stripitem_settings,
            this.clearOutputToolStripMenuItem,
            this.killProcessToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(858, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportOutputToolStripMenuItem,
            this.exportAsBATToolStripMenuItem,
            this.toolStripSeparator2,
            this.openOutputFolderToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exportOutputToolStripMenuItem
            // 
            this.exportOutputToolStripMenuItem.Name = "exportOutputToolStripMenuItem";
            this.exportOutputToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportOutputToolStripMenuItem.Text = "Save Output";
            this.exportOutputToolStripMenuItem.Click += new System.EventHandler(this.exportOutputToolStripMenuItem_Click);
            // 
            // exportAsBATToolStripMenuItem
            // 
            this.exportAsBATToolStripMenuItem.Name = "exportAsBATToolStripMenuItem";
            this.exportAsBATToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportAsBATToolStripMenuItem.Text = "Export as BAT";
            this.exportAsBATToolStripMenuItem.Click += new System.EventHandler(this.exportAsBATToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // openOutputFolderToolStripMenuItem
            // 
            this.openOutputFolderToolStripMenuItem.Name = "openOutputFolderToolStripMenuItem";
            this.openOutputFolderToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openOutputFolderToolStripMenuItem.Text = "Open Output Folder";
            this.openOutputFolderToolStripMenuItem.Click += new System.EventHandler(this.openOutputFolderToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // stripitem_settings
            // 
            this.stripitem_settings.Name = "stripitem_settings";
            this.stripitem_settings.Size = new System.Drawing.Size(61, 20);
            this.stripitem_settings.Text = "Settings";
            this.stripitem_settings.Click += new System.EventHandler(this.stripitem_settings_Click);
            // 
            // clearOutputToolStripMenuItem
            // 
            this.clearOutputToolStripMenuItem.Name = "clearOutputToolStripMenuItem";
            this.clearOutputToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.clearOutputToolStripMenuItem.Text = "Clear Output";
            this.clearOutputToolStripMenuItem.Click += new System.EventHandler(this.clearOutputToolStripMenuItem_Click);
            // 
            // killProcessToolStripMenuItem
            // 
            this.killProcessToolStripMenuItem.Name = "killProcessToolStripMenuItem";
            this.killProcessToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.killProcessToolStripMenuItem.Text = "Kill Process";
            this.killProcessToolStripMenuItem.Click += new System.EventHandler(this.killProcessToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creditsToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // creditsToolStripMenuItem
            // 
            this.creditsToolStripMenuItem.Name = "creditsToolStripMenuItem";
            this.creditsToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.creditsToolStripMenuItem.Text = "Credits";
            this.creditsToolStripMenuItem.Click += new System.EventHandler(this.creditsToolStripMenuItem_Click);
            // 
            // tab_manager
            // 
            this.tab_manager.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab_manager.Controls.Add(this.tab_baker);
            this.tab_manager.Controls.Add(this.tab_cooker);
            this.tab_manager.Controls.Add(this.tab_mutator);
            this.tab_manager.Controls.Add(this.tab_render);
            this.tab_manager.Location = new System.Drawing.Point(12, 27);
            this.tab_manager.Name = "tab_manager";
            this.tab_manager.SelectedIndex = 0;
            this.tab_manager.Size = new System.Drawing.Size(834, 299);
            this.tab_manager.TabIndex = 1;
            this.tab_manager.Selected += new System.Windows.Forms.TabControlEventHandler(this.tab_manager_Selected);
            // 
            // tab_baker
            // 
            this.tab_baker.Controls.Add(this.btn_baker_input_select);
            this.tab_baker.Controls.Add(this.txt_baker_input);
            this.tab_baker.Controls.Add(this.label35);
            this.tab_baker.Controls.Add(this.group_baker_mode);
            this.tab_baker.Controls.Add(this.btn_baker_help);
            this.tab_baker.Controls.Add(this.btn_baker_version);
            this.tab_baker.Location = new System.Drawing.Point(4, 22);
            this.tab_baker.Name = "tab_baker";
            this.tab_baker.Padding = new System.Windows.Forms.Padding(3);
            this.tab_baker.Size = new System.Drawing.Size(826, 273);
            this.tab_baker.TabIndex = 0;
            this.tab_baker.Text = "sbsbaker";
            this.tab_baker.UseVisualStyleBackColor = true;
            // 
            // btn_baker_input_select
            // 
            this.btn_baker_input_select.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_baker_input_select.Location = new System.Drawing.Point(787, 9);
            this.btn_baker_input_select.Name = "btn_baker_input_select";
            this.btn_baker_input_select.Size = new System.Drawing.Size(32, 20);
            this.btn_baker_input_select.TabIndex = 15;
            this.btn_baker_input_select.Text = "...";
            this.btn_baker_input_select.UseVisualStyleBackColor = true;
            this.btn_baker_input_select.Click += new System.EventHandler(this.btn_baker_input_select_Click);
            // 
            // txt_baker_input
            // 
            this.txt_baker_input.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_baker_input.Location = new System.Drawing.Point(251, 9);
            this.txt_baker_input.Name = "txt_baker_input";
            this.txt_baker_input.Size = new System.Drawing.Size(530, 20);
            this.txt_baker_input.TabIndex = 14;
            this.txt_baker_input.TextChanged += new System.EventHandler(this.txt_baker_input_TextChanged);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(182, 13);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(63, 13);
            this.label35.TabIndex = 13;
            this.label35.Text = "Input Mesh:";
            // 
            // group_baker_mode
            // 
            this.group_baker_mode.Controls.Add(this.combo_baker_mode);
            this.group_baker_mode.Location = new System.Drawing.Point(7, 36);
            this.group_baker_mode.Name = "group_baker_mode";
            this.group_baker_mode.Size = new System.Drawing.Size(155, 52);
            this.group_baker_mode.TabIndex = 2;
            this.group_baker_mode.TabStop = false;
            this.group_baker_mode.Text = "Mode";
            // 
            // combo_baker_mode
            // 
            this.combo_baker_mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_baker_mode.FormattingEnabled = true;
            this.combo_baker_mode.Items.AddRange(new object[] {
            "ambient-occlusion",
            "ambient-occlusion-from-mesh",
            "bent-normal-from-mesh",
            "color-from-mesh",
            "curvature",
            "height-from-mesh",
            "normal-from-mesh",
            "normal-world-space",
            "opacity-mask-from-mesh",
            "position",
            "texture-from-mesh",
            "thickness-from-mesh",
            "uv-map",
            "world-space-direction"});
            this.combo_baker_mode.Location = new System.Drawing.Point(6, 19);
            this.combo_baker_mode.Name = "combo_baker_mode";
            this.combo_baker_mode.Size = new System.Drawing.Size(142, 21);
            this.combo_baker_mode.TabIndex = 0;
            this.combo_baker_mode.SelectedIndexChanged += new System.EventHandler(this.combo_baker_mode_SelectedIndexChanged);
            // 
            // btn_baker_help
            // 
            this.btn_baker_help.Location = new System.Drawing.Point(87, 6);
            this.btn_baker_help.Name = "btn_baker_help";
            this.btn_baker_help.Size = new System.Drawing.Size(75, 23);
            this.btn_baker_help.TabIndex = 1;
            this.btn_baker_help.Text = "Help";
            this.btn_baker_help.UseVisualStyleBackColor = true;
            this.btn_baker_help.Click += new System.EventHandler(this.btn_baker_help_Click);
            // 
            // btn_baker_version
            // 
            this.btn_baker_version.Location = new System.Drawing.Point(6, 6);
            this.btn_baker_version.Name = "btn_baker_version";
            this.btn_baker_version.Size = new System.Drawing.Size(75, 23);
            this.btn_baker_version.TabIndex = 0;
            this.btn_baker_version.Text = "Version";
            this.btn_baker_version.UseVisualStyleBackColor = true;
            this.btn_baker_version.Click += new System.EventHandler(this.btn_baker_version_Click);
            // 
            // tab_cooker
            // 
            this.tab_cooker.Controls.Add(this.btn_cooker_includes_select);
            this.tab_cooker.Controls.Add(this.txt_cooker_includes);
            this.tab_cooker.Controls.Add(this.label23);
            this.tab_cooker.Controls.Add(this.txt_cooker_alias);
            this.tab_cooker.Controls.Add(this.label22);
            this.tab_cooker.Controls.Add(this.txt_cooker_sizelimit);
            this.tab_cooker.Controls.Add(this.label21);
            this.tab_cooker.Controls.Add(this.txt_cooker_output_name);
            this.tab_cooker.Controls.Add(this.label20);
            this.tab_cooker.Controls.Add(this.btn_cooker_output_folder);
            this.tab_cooker.Controls.Add(this.txt_cooker_output_folder);
            this.tab_cooker.Controls.Add(this.label19);
            this.tab_cooker.Controls.Add(this.btn_cooker_input_select);
            this.tab_cooker.Controls.Add(this.txt_cooker_input);
            this.tab_cooker.Controls.Add(this.label18);
            this.tab_cooker.Controls.Add(this.check_cooker_archive);
            this.tab_cooker.Controls.Add(this.check_cooker_merge);
            this.tab_cooker.Controls.Add(this.check_cooker_pixel_size);
            this.tab_cooker.Controls.Add(this.check_cooker_random_seed);
            this.tab_cooker.Controls.Add(this.check_cooker_output_size);
            this.tab_cooker.Controls.Add(this.check_cooker_optimation);
            this.tab_cooker.Controls.Add(this.btn_cooker_help);
            this.tab_cooker.Controls.Add(this.btn_cooker_version);
            this.tab_cooker.Location = new System.Drawing.Point(4, 22);
            this.tab_cooker.Name = "tab_cooker";
            this.tab_cooker.Padding = new System.Windows.Forms.Padding(3);
            this.tab_cooker.Size = new System.Drawing.Size(826, 273);
            this.tab_cooker.TabIndex = 1;
            this.tab_cooker.Text = "sbscooker";
            this.tab_cooker.UseVisualStyleBackColor = true;
            // 
            // btn_cooker_includes_select
            // 
            this.btn_cooker_includes_select.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cooker_includes_select.Location = new System.Drawing.Point(788, 143);
            this.btn_cooker_includes_select.Name = "btn_cooker_includes_select";
            this.btn_cooker_includes_select.Size = new System.Drawing.Size(32, 23);
            this.btn_cooker_includes_select.TabIndex = 24;
            this.btn_cooker_includes_select.Text = "...";
            this.btn_cooker_includes_select.UseVisualStyleBackColor = true;
            this.btn_cooker_includes_select.Click += new System.EventHandler(this.btn_cooker_includes_select_Click);
            // 
            // txt_cooker_includes
            // 
            this.txt_cooker_includes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_cooker_includes.Location = new System.Drawing.Point(252, 145);
            this.txt_cooker_includes.Name = "txt_cooker_includes";
            this.txt_cooker_includes.Size = new System.Drawing.Size(530, 20);
            this.txt_cooker_includes.TabIndex = 23;
            this.txt_cooker_includes.TextChanged += new System.EventHandler(this.txt_cooker_includes_TextChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(193, 148);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(50, 13);
            this.label23.TabIndex = 22;
            this.label23.Text = "Includes:";
            // 
            // txt_cooker_alias
            // 
            this.txt_cooker_alias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_cooker_alias.Location = new System.Drawing.Point(252, 119);
            this.txt_cooker_alias.Name = "txt_cooker_alias";
            this.txt_cooker_alias.Size = new System.Drawing.Size(568, 20);
            this.txt_cooker_alias.TabIndex = 21;
            this.txt_cooker_alias.TextChanged += new System.EventHandler(this.txt_cooker_alias_TextChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(214, 123);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(32, 13);
            this.label22.TabIndex = 20;
            this.label22.Text = "Alias:";
            // 
            // txt_cooker_sizelimit
            // 
            this.txt_cooker_sizelimit.Location = new System.Drawing.Point(62, 206);
            this.txt_cooker_sizelimit.Name = "txt_cooker_sizelimit";
            this.txt_cooker_sizelimit.Size = new System.Drawing.Size(100, 20);
            this.txt_cooker_sizelimit.TabIndex = 19;
            this.txt_cooker_sizelimit.TextChanged += new System.EventHandler(this.txt_cooker_sizelimit_TextChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 209);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(50, 13);
            this.label21.TabIndex = 18;
            this.label21.Text = "Size limit:";
            // 
            // txt_cooker_output_name
            // 
            this.txt_cooker_output_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_cooker_output_name.Location = new System.Drawing.Point(252, 73);
            this.txt_cooker_output_name.Name = "txt_cooker_output_name";
            this.txt_cooker_output_name.Size = new System.Drawing.Size(568, 20);
            this.txt_cooker_output_name.TabIndex = 17;
            this.txt_cooker_output_name.TextChanged += new System.EventHandler(this.txt_cooker_output_name_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(175, 76);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(71, 13);
            this.label20.TabIndex = 16;
            this.label20.Text = "Output name:";
            // 
            // btn_cooker_output_folder
            // 
            this.btn_cooker_output_folder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cooker_output_folder.Location = new System.Drawing.Point(788, 46);
            this.btn_cooker_output_folder.Name = "btn_cooker_output_folder";
            this.btn_cooker_output_folder.Size = new System.Drawing.Size(32, 20);
            this.btn_cooker_output_folder.TabIndex = 15;
            this.btn_cooker_output_folder.Text = "...";
            this.btn_cooker_output_folder.UseVisualStyleBackColor = true;
            this.btn_cooker_output_folder.Click += new System.EventHandler(this.btn_cooker_output_folder_Click);
            // 
            // txt_cooker_output_folder
            // 
            this.txt_cooker_output_folder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_cooker_output_folder.Location = new System.Drawing.Point(252, 46);
            this.txt_cooker_output_folder.Name = "txt_cooker_output_folder";
            this.txt_cooker_output_folder.Size = new System.Drawing.Size(530, 20);
            this.txt_cooker_output_folder.TabIndex = 14;
            this.txt_cooker_output_folder.TextChanged += new System.EventHandler(this.txt_cooker_output_folder_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(175, 50);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(71, 13);
            this.label19.TabIndex = 13;
            this.label19.Text = "Output folder:";
            // 
            // btn_cooker_input_select
            // 
            this.btn_cooker_input_select.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cooker_input_select.Location = new System.Drawing.Point(788, 6);
            this.btn_cooker_input_select.Name = "btn_cooker_input_select";
            this.btn_cooker_input_select.Size = new System.Drawing.Size(32, 20);
            this.btn_cooker_input_select.TabIndex = 12;
            this.btn_cooker_input_select.Text = "...";
            this.btn_cooker_input_select.UseVisualStyleBackColor = true;
            this.btn_cooker_input_select.Click += new System.EventHandler(this.btn_cooker_input_select_Click);
            // 
            // txt_cooker_input
            // 
            this.txt_cooker_input.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_cooker_input.Location = new System.Drawing.Point(252, 6);
            this.txt_cooker_input.Name = "txt_cooker_input";
            this.txt_cooker_input.Size = new System.Drawing.Size(530, 20);
            this.txt_cooker_input.TabIndex = 11;
            this.txt_cooker_input.TextChanged += new System.EventHandler(this.txt_cooker_input_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(193, 11);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 13);
            this.label18.TabIndex = 10;
            this.label18.Text = "Input File:";
            // 
            // check_cooker_archive
            // 
            this.check_cooker_archive.AutoSize = true;
            this.check_cooker_archive.Location = new System.Drawing.Point(6, 73);
            this.check_cooker_archive.Name = "check_cooker_archive";
            this.check_cooker_archive.Size = new System.Drawing.Size(78, 17);
            this.check_cooker_archive.TabIndex = 9;
            this.check_cooker_archive.Text = "No archive";
            this.check_cooker_archive.UseVisualStyleBackColor = true;
            this.check_cooker_archive.CheckedChanged += new System.EventHandler(this.check_cooker_archive_CheckedChanged);
            // 
            // check_cooker_merge
            // 
            this.check_cooker_merge.AutoSize = true;
            this.check_cooker_merge.Location = new System.Drawing.Point(6, 50);
            this.check_cooker_merge.Name = "check_cooker_merge";
            this.check_cooker_merge.Size = new System.Drawing.Size(102, 17);
            this.check_cooker_merge.TabIndex = 8;
            this.check_cooker_merge.Text = "Merge all results";
            this.check_cooker_merge.UseVisualStyleBackColor = true;
            this.check_cooker_merge.CheckedChanged += new System.EventHandler(this.check_cooker_merge_CheckedChanged);
            // 
            // check_cooker_pixel_size
            // 
            this.check_cooker_pixel_size.AutoSize = true;
            this.check_cooker_pixel_size.Location = new System.Drawing.Point(6, 165);
            this.check_cooker_pixel_size.Name = "check_cooker_pixel_size";
            this.check_cooker_pixel_size.Size = new System.Drawing.Size(106, 17);
            this.check_cooker_pixel_size.TabIndex = 7;
            this.check_cooker_pixel_size.Text = "Expose pixel size";
            this.check_cooker_pixel_size.UseVisualStyleBackColor = true;
            this.check_cooker_pixel_size.CheckedChanged += new System.EventHandler(this.check_expose_pixel_size_CheckedChanged);
            // 
            // check_cooker_random_seed
            // 
            this.check_cooker_random_seed.AutoSize = true;
            this.check_cooker_random_seed.Checked = true;
            this.check_cooker_random_seed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_cooker_random_seed.Location = new System.Drawing.Point(6, 142);
            this.check_cooker_random_seed.Name = "check_cooker_random_seed";
            this.check_cooker_random_seed.Size = new System.Drawing.Size(125, 17);
            this.check_cooker_random_seed.TabIndex = 6;
            this.check_cooker_random_seed.Text = "Expose random seed";
            this.check_cooker_random_seed.UseVisualStyleBackColor = true;
            this.check_cooker_random_seed.CheckedChanged += new System.EventHandler(this.check_cooker_random_seed_CheckedChanged);
            // 
            // check_cooker_output_size
            // 
            this.check_cooker_output_size.AutoSize = true;
            this.check_cooker_output_size.Checked = true;
            this.check_cooker_output_size.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_cooker_output_size.Location = new System.Drawing.Point(6, 119);
            this.check_cooker_output_size.Name = "check_cooker_output_size";
            this.check_cooker_output_size.Size = new System.Drawing.Size(115, 17);
            this.check_cooker_output_size.TabIndex = 5;
            this.check_cooker_output_size.Text = "Expose output size";
            this.check_cooker_output_size.UseVisualStyleBackColor = true;
            this.check_cooker_output_size.CheckedChanged += new System.EventHandler(this.check_cooker_output_size_CheckedChanged);
            // 
            // check_cooker_optimation
            // 
            this.check_cooker_optimation.AutoSize = true;
            this.check_cooker_optimation.Location = new System.Drawing.Point(6, 96);
            this.check_cooker_optimation.Name = "check_cooker_optimation";
            this.check_cooker_optimation.Size = new System.Drawing.Size(93, 17);
            this.check_cooker_optimation.TabIndex = 4;
            this.check_cooker_optimation.Text = "No Optimation";
            this.check_cooker_optimation.UseVisualStyleBackColor = true;
            this.check_cooker_optimation.CheckedChanged += new System.EventHandler(this.check_cooker_optimation_CheckedChanged);
            // 
            // btn_cooker_help
            // 
            this.btn_cooker_help.Location = new System.Drawing.Point(87, 6);
            this.btn_cooker_help.Name = "btn_cooker_help";
            this.btn_cooker_help.Size = new System.Drawing.Size(75, 23);
            this.btn_cooker_help.TabIndex = 3;
            this.btn_cooker_help.Text = "Help";
            this.btn_cooker_help.UseVisualStyleBackColor = true;
            this.btn_cooker_help.Click += new System.EventHandler(this.btn_cooker_help_Click);
            // 
            // btn_cooker_version
            // 
            this.btn_cooker_version.Location = new System.Drawing.Point(6, 6);
            this.btn_cooker_version.Name = "btn_cooker_version";
            this.btn_cooker_version.Size = new System.Drawing.Size(75, 23);
            this.btn_cooker_version.TabIndex = 2;
            this.btn_cooker_version.Text = "Version";
            this.btn_cooker_version.UseVisualStyleBackColor = true;
            this.btn_cooker_version.Click += new System.EventHandler(this.btn_cooker_version_Click);
            // 
            // tab_mutator
            // 
            this.tab_mutator.Controls.Add(this.label34);
            this.tab_mutator.Controls.Add(this.txt_mutator_input_graph);
            this.tab_mutator.Controls.Add(this.txt_mutator_connect_input);
            this.tab_mutator.Controls.Add(this.label33);
            this.tab_mutator.Controls.Add(this.txt_mutator_connect_image);
            this.tab_mutator.Controls.Add(this.label32);
            this.tab_mutator.Controls.Add(this.txt_mutator_set_default);
            this.tab_mutator.Controls.Add(this.label31);
            this.tab_mutator.Controls.Add(this.txt_mutator_switch_to_constant);
            this.tab_mutator.Controls.Add(this.label27);
            this.tab_mutator.Controls.Add(this.btn_mutator_presets_select);
            this.tab_mutator.Controls.Add(this.txt_mutator_presets);
            this.tab_mutator.Controls.Add(this.label30);
            this.tab_mutator.Controls.Add(this.txt_mutator_graph_name);
            this.tab_mutator.Controls.Add(this.label29);
            this.tab_mutator.Controls.Add(this.txt_mutator_alias);
            this.tab_mutator.Controls.Add(this.label28);
            this.tab_mutator.Controls.Add(this.check_mutator_depend);
            this.tab_mutator.Controls.Add(this.check_mutator_merge);
            this.tab_mutator.Controls.Add(this.check_mutator_hide_params);
            this.tab_mutator.Controls.Add(this.txt_mutator_output_name);
            this.tab_mutator.Controls.Add(this.label24);
            this.tab_mutator.Controls.Add(this.btn_output_path_select);
            this.tab_mutator.Controls.Add(this.txt_mutator_output_path);
            this.tab_mutator.Controls.Add(this.label25);
            this.tab_mutator.Controls.Add(this.btn_mutator_input_select);
            this.tab_mutator.Controls.Add(this.label26);
            this.tab_mutator.Controls.Add(this.txt_mutator_input);
            this.tab_mutator.Controls.Add(this.group_mutator_mode);
            this.tab_mutator.Controls.Add(this.btn_mutator_help);
            this.tab_mutator.Controls.Add(this.btn_mutator_version);
            this.tab_mutator.Location = new System.Drawing.Point(4, 22);
            this.tab_mutator.Name = "tab_mutator";
            this.tab_mutator.Padding = new System.Windows.Forms.Padding(3);
            this.tab_mutator.Size = new System.Drawing.Size(826, 273);
            this.tab_mutator.TabIndex = 2;
            this.tab_mutator.Text = "sbsmutator";
            this.tab_mutator.UseVisualStyleBackColor = true;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(177, 37);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(66, 13);
            this.label34.TabIndex = 55;
            this.label34.Text = "Input Graph:";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_mutator_input_graph
            // 
            this.txt_mutator_input_graph.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_mutator_input_graph.Location = new System.Drawing.Point(252, 30);
            this.txt_mutator_input_graph.Name = "txt_mutator_input_graph";
            this.txt_mutator_input_graph.Size = new System.Drawing.Size(568, 20);
            this.txt_mutator_input_graph.TabIndex = 54;
            this.txt_mutator_input_graph.TextChanged += new System.EventHandler(this.txt_mutator_input_graph_TextChanged);
            // 
            // txt_mutator_connect_input
            // 
            this.txt_mutator_connect_input.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_mutator_connect_input.Location = new System.Drawing.Point(606, 233);
            this.txt_mutator_connect_input.Name = "txt_mutator_connect_input";
            this.txt_mutator_connect_input.Size = new System.Drawing.Size(214, 20);
            this.txt_mutator_connect_input.TabIndex = 53;
            this.txt_mutator_connect_input.TextChanged += new System.EventHandler(this.txt_mutator_connect_input_TextChanged);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(524, 236);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(76, 13);
            this.label33.TabIndex = 52;
            this.label33.Text = "Connect input:";
            // 
            // txt_mutator_connect_image
            // 
            this.txt_mutator_connect_image.Location = new System.Drawing.Point(252, 233);
            this.txt_mutator_connect_image.Name = "txt_mutator_connect_image";
            this.txt_mutator_connect_image.Size = new System.Drawing.Size(252, 20);
            this.txt_mutator_connect_image.TabIndex = 51;
            this.txt_mutator_connect_image.TextChanged += new System.EventHandler(this.txt_mutator_connect_image_TextChanged);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(162, 236);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(81, 13);
            this.label32.TabIndex = 50;
            this.label32.Text = "Connect image:";
            // 
            // txt_mutator_set_default
            // 
            this.txt_mutator_set_default.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_mutator_set_default.Location = new System.Drawing.Point(606, 200);
            this.txt_mutator_set_default.Name = "txt_mutator_set_default";
            this.txt_mutator_set_default.Size = new System.Drawing.Size(214, 20);
            this.txt_mutator_set_default.TabIndex = 49;
            this.txt_mutator_set_default.TextChanged += new System.EventHandler(this.txt_mutator_set_default_TextChanged);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(510, 203);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(90, 13);
            this.label31.TabIndex = 48;
            this.label31.Text = "Set default value:";
            // 
            // txt_mutator_switch_to_constant
            // 
            this.txt_mutator_switch_to_constant.Location = new System.Drawing.Point(252, 200);
            this.txt_mutator_switch_to_constant.Name = "txt_mutator_switch_to_constant";
            this.txt_mutator_switch_to_constant.Size = new System.Drawing.Size(252, 20);
            this.txt_mutator_switch_to_constant.TabIndex = 47;
            this.txt_mutator_switch_to_constant.TextChanged += new System.EventHandler(this.txt_mutator_switch_to_constant_TextChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(149, 203);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(98, 13);
            this.label27.TabIndex = 46;
            this.label27.Text = "Switch to constant:";
            // 
            // btn_mutator_presets_select
            // 
            this.btn_mutator_presets_select.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_mutator_presets_select.Location = new System.Drawing.Point(788, 162);
            this.btn_mutator_presets_select.Name = "btn_mutator_presets_select";
            this.btn_mutator_presets_select.Size = new System.Drawing.Size(32, 23);
            this.btn_mutator_presets_select.TabIndex = 45;
            this.btn_mutator_presets_select.Text = "...";
            this.btn_mutator_presets_select.UseVisualStyleBackColor = true;
            this.btn_mutator_presets_select.Click += new System.EventHandler(this.btn_mutator_presets_select_Click);
            // 
            // txt_mutator_presets
            // 
            this.txt_mutator_presets.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_mutator_presets.Location = new System.Drawing.Point(252, 164);
            this.txt_mutator_presets.Name = "txt_mutator_presets";
            this.txt_mutator_presets.Size = new System.Drawing.Size(530, 20);
            this.txt_mutator_presets.TabIndex = 44;
            this.txt_mutator_presets.TextChanged += new System.EventHandler(this.txt_mutator_presets_TextChanged);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(174, 167);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(69, 13);
            this.label30.TabIndex = 43;
            this.label30.Text = "Presets path:";
            // 
            // txt_mutator_graph_name
            // 
            this.txt_mutator_graph_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_mutator_graph_name.Location = new System.Drawing.Point(252, 111);
            this.txt_mutator_graph_name.Name = "txt_mutator_graph_name";
            this.txt_mutator_graph_name.Size = new System.Drawing.Size(568, 20);
            this.txt_mutator_graph_name.TabIndex = 42;
            this.txt_mutator_graph_name.TextChanged += new System.EventHandler(this.txt_mutator_graph_name_TextChanged);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(146, 113);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(101, 13);
            this.label29.TabIndex = 41;
            this.label29.Text = "Output graph name:";
            // 
            // txt_mutator_alias
            // 
            this.txt_mutator_alias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_mutator_alias.Location = new System.Drawing.Point(252, 138);
            this.txt_mutator_alias.Name = "txt_mutator_alias";
            this.txt_mutator_alias.Size = new System.Drawing.Size(568, 20);
            this.txt_mutator_alias.TabIndex = 37;
            this.txt_mutator_alias.TextChanged += new System.EventHandler(this.txt_mutator_alias_TextChanged);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(214, 142);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(32, 13);
            this.label28.TabIndex = 36;
            this.label28.Text = "Alias:";
            // 
            // check_mutator_depend
            // 
            this.check_mutator_depend.AutoSize = true;
            this.check_mutator_depend.Enabled = false;
            this.check_mutator_depend.Location = new System.Drawing.Point(6, 141);
            this.check_mutator_depend.Name = "check_mutator_depend";
            this.check_mutator_depend.Size = new System.Drawing.Size(104, 17);
            this.check_mutator_depend.TabIndex = 35;
            this.check_mutator_depend.Text = "No Dependency";
            this.check_mutator_depend.UseVisualStyleBackColor = true;
            this.check_mutator_depend.CheckedChanged += new System.EventHandler(this.check_mutator_depend_CheckedChanged);
            // 
            // check_mutator_merge
            // 
            this.check_mutator_merge.AutoSize = true;
            this.check_mutator_merge.Enabled = false;
            this.check_mutator_merge.Location = new System.Drawing.Point(6, 118);
            this.check_mutator_merge.Name = "check_mutator_merge";
            this.check_mutator_merge.Size = new System.Drawing.Size(91, 17);
            this.check_mutator_merge.TabIndex = 34;
            this.check_mutator_merge.Text = "Output Merge";
            this.check_mutator_merge.UseVisualStyleBackColor = true;
            this.check_mutator_merge.CheckedChanged += new System.EventHandler(this.check_mutator_merge_CheckedChanged);
            // 
            // check_mutator_hide_params
            // 
            this.check_mutator_hide_params.AutoSize = true;
            this.check_mutator_hide_params.Enabled = false;
            this.check_mutator_hide_params.Location = new System.Drawing.Point(6, 94);
            this.check_mutator_hide_params.Name = "check_mutator_hide_params";
            this.check_mutator_hide_params.Size = new System.Drawing.Size(104, 17);
            this.check_mutator_hide_params.TabIndex = 33;
            this.check_mutator_hide_params.Text = "Hide Parameters";
            this.check_mutator_hide_params.UseVisualStyleBackColor = true;
            this.check_mutator_hide_params.CheckedChanged += new System.EventHandler(this.check_mutator_hide_params_CheckedChanged);
            // 
            // txt_mutator_output_name
            // 
            this.txt_mutator_output_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_mutator_output_name.Location = new System.Drawing.Point(252, 85);
            this.txt_mutator_output_name.Name = "txt_mutator_output_name";
            this.txt_mutator_output_name.Size = new System.Drawing.Size(568, 20);
            this.txt_mutator_output_name.TabIndex = 32;
            this.txt_mutator_output_name.TextChanged += new System.EventHandler(this.txt_mutator_output_name_TextChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(170, 87);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(73, 13);
            this.label24.TabIndex = 31;
            this.label24.Text = "Output Name:";
            // 
            // btn_output_path_select
            // 
            this.btn_output_path_select.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_output_path_select.Location = new System.Drawing.Point(788, 55);
            this.btn_output_path_select.Name = "btn_output_path_select";
            this.btn_output_path_select.Size = new System.Drawing.Size(32, 20);
            this.btn_output_path_select.TabIndex = 30;
            this.btn_output_path_select.Text = "...";
            this.btn_output_path_select.UseVisualStyleBackColor = true;
            this.btn_output_path_select.Click += new System.EventHandler(this.btn_output_path_select_Click);
            // 
            // txt_mutator_output_path
            // 
            this.txt_mutator_output_path.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_mutator_output_path.Location = new System.Drawing.Point(252, 56);
            this.txt_mutator_output_path.Name = "txt_mutator_output_path";
            this.txt_mutator_output_path.Size = new System.Drawing.Size(526, 20);
            this.txt_mutator_output_path.TabIndex = 29;
            this.txt_mutator_output_path.TextChanged += new System.EventHandler(this.txt_mutator_output_path_TextChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(176, 62);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(67, 13);
            this.label25.TabIndex = 28;
            this.label25.Text = "Output Path:";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_mutator_input_select
            // 
            this.btn_mutator_input_select.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_mutator_input_select.Location = new System.Drawing.Point(788, 6);
            this.btn_mutator_input_select.Name = "btn_mutator_input_select";
            this.btn_mutator_input_select.Size = new System.Drawing.Size(32, 20);
            this.btn_mutator_input_select.TabIndex = 27;
            this.btn_mutator_input_select.Text = "...";
            this.btn_mutator_input_select.UseVisualStyleBackColor = true;
            this.btn_mutator_input_select.Click += new System.EventHandler(this.btn_mutator_input_select_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(190, 11);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(53, 13);
            this.label26.TabIndex = 26;
            this.label26.Text = "Input File:";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_mutator_input
            // 
            this.txt_mutator_input.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_mutator_input.Location = new System.Drawing.Point(252, 6);
            this.txt_mutator_input.Name = "txt_mutator_input";
            this.txt_mutator_input.Size = new System.Drawing.Size(526, 20);
            this.txt_mutator_input.TabIndex = 25;
            this.txt_mutator_input.TextChanged += new System.EventHandler(this.txt_mutator_input_TextChanged);
            // 
            // group_mutator_mode
            // 
            this.group_mutator_mode.Controls.Add(this.combo_mutator_mode);
            this.group_mutator_mode.Location = new System.Drawing.Point(7, 36);
            this.group_mutator_mode.Name = "group_mutator_mode";
            this.group_mutator_mode.Size = new System.Drawing.Size(155, 51);
            this.group_mutator_mode.TabIndex = 4;
            this.group_mutator_mode.TabStop = false;
            this.group_mutator_mode.Text = "Mode";
            // 
            // combo_mutator_mode
            // 
            this.combo_mutator_mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_mutator_mode.FormattingEnabled = true;
            this.combo_mutator_mode.Items.AddRange(new object[] {
            "graph-parameters-editor",
            "info",
            "specialization",
            "update"});
            this.combo_mutator_mode.Location = new System.Drawing.Point(7, 20);
            this.combo_mutator_mode.Name = "combo_mutator_mode";
            this.combo_mutator_mode.Size = new System.Drawing.Size(142, 21);
            this.combo_mutator_mode.TabIndex = 0;
            this.combo_mutator_mode.SelectedIndexChanged += new System.EventHandler(this.combo_mutator_mode_SelectedIndexChanged);
            // 
            // btn_mutator_help
            // 
            this.btn_mutator_help.Location = new System.Drawing.Point(87, 6);
            this.btn_mutator_help.Name = "btn_mutator_help";
            this.btn_mutator_help.Size = new System.Drawing.Size(75, 23);
            this.btn_mutator_help.TabIndex = 3;
            this.btn_mutator_help.Text = "Help";
            this.btn_mutator_help.UseVisualStyleBackColor = true;
            this.btn_mutator_help.Click += new System.EventHandler(this.btn_mutator_help_Click);
            // 
            // btn_mutator_version
            // 
            this.btn_mutator_version.Location = new System.Drawing.Point(6, 6);
            this.btn_mutator_version.Name = "btn_mutator_version";
            this.btn_mutator_version.Size = new System.Drawing.Size(75, 23);
            this.btn_mutator_version.TabIndex = 2;
            this.btn_mutator_version.Text = "Version";
            this.btn_mutator_version.UseVisualStyleBackColor = true;
            this.btn_mutator_version.Click += new System.EventHandler(this.btn_mutator_version_Click);
            // 
            // tab_render
            // 
            this.tab_render.Controls.Add(this.txt_render_values);
            this.tab_render.Controls.Add(this.label17);
            this.tab_render.Controls.Add(this.txt_render_pixel_size);
            this.tab_render.Controls.Add(this.label16);
            this.tab_render.Controls.Add(this.txt_render_output_size);
            this.tab_render.Controls.Add(this.label15);
            this.tab_render.Controls.Add(this.btn_render_entry_path_select);
            this.tab_render.Controls.Add(this.txt_render_entry_path);
            this.tab_render.Controls.Add(this.label14);
            this.tab_render.Controls.Add(this.txt_render_entry_id);
            this.tab_render.Controls.Add(this.label13);
            this.tab_render.Controls.Add(this.label12);
            this.tab_render.Controls.Add(this.txt_render_seed);
            this.tab_render.Controls.Add(this.btn_render_output_name_build);
            this.tab_render.Controls.Add(this.txt_render_output_name);
            this.tab_render.Controls.Add(this.label11);
            this.tab_render.Controls.Add(this.txt_render_graph_output);
            this.tab_render.Controls.Add(this.label10);
            this.tab_render.Controls.Add(this.txt_render_graph);
            this.tab_render.Controls.Add(this.label9);
            this.tab_render.Controls.Add(this.numeric_render_budget);
            this.tab_render.Controls.Add(this.txt_render_engine);
            this.tab_render.Controls.Add(this.label8);
            this.tab_render.Controls.Add(this.label7);
            this.tab_render.Controls.Add(this.combo_render_compression);
            this.tab_render.Controls.Add(this.label6);
            this.tab_render.Controls.Add(this.label5);
            this.tab_render.Controls.Add(this.combo_render_fileformat);
            this.tab_render.Controls.Add(this.btn_render_output_select);
            this.tab_render.Controls.Add(this.txt_render_output);
            this.tab_render.Controls.Add(this.label4);
            this.tab_render.Controls.Add(this.btn_render_input_select);
            this.tab_render.Controls.Add(this.label3);
            this.tab_render.Controls.Add(this.txt_render_input);
            this.tab_render.Controls.Add(this.group_render_mode);
            this.tab_render.Controls.Add(this.btn_render_help);
            this.tab_render.Controls.Add(this.btn_render_version);
            this.tab_render.Location = new System.Drawing.Point(4, 22);
            this.tab_render.Name = "tab_render";
            this.tab_render.Padding = new System.Windows.Forms.Padding(3);
            this.tab_render.Size = new System.Drawing.Size(826, 273);
            this.tab_render.TabIndex = 3;
            this.tab_render.Text = "sbsrender";
            this.tab_render.UseVisualStyleBackColor = true;
            // 
            // txt_render_values
            // 
            this.txt_render_values.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_render_values.Location = new System.Drawing.Point(277, 159);
            this.txt_render_values.Name = "txt_render_values";
            this.txt_render_values.Size = new System.Drawing.Size(543, 20);
            this.txt_render_values.TabIndex = 38;
            this.txt_render_values.TextChanged += new System.EventHandler(this.txt_render_values_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(194, 162);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 13);
            this.label17.TabIndex = 37;
            this.label17.Text = "Set Values:";
            // 
            // txt_render_pixel_size
            // 
            this.txt_render_pixel_size.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_render_pixel_size.Location = new System.Drawing.Point(564, 185);
            this.txt_render_pixel_size.Name = "txt_render_pixel_size";
            this.txt_render_pixel_size.Size = new System.Drawing.Size(256, 20);
            this.txt_render_pixel_size.TabIndex = 36;
            this.txt_render_pixel_size.TextChanged += new System.EventHandler(this.txt_render_pixel_size_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(505, 188);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 13);
            this.label16.TabIndex = 35;
            this.label16.Text = "Pixel size:";
            // 
            // txt_render_output_size
            // 
            this.txt_render_output_size.Location = new System.Drawing.Point(277, 185);
            this.txt_render_output_size.Name = "txt_render_output_size";
            this.txt_render_output_size.Size = new System.Drawing.Size(222, 20);
            this.txt_render_output_size.TabIndex = 34;
            this.txt_render_output_size.TextChanged += new System.EventHandler(this.txt_render_output_size_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(194, 188);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 13);
            this.label15.TabIndex = 33;
            this.label15.Text = "Output size:";
            // 
            // btn_render_entry_path_select
            // 
            this.btn_render_entry_path_select.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_render_entry_path_select.Location = new System.Drawing.Point(788, 126);
            this.btn_render_entry_path_select.Name = "btn_render_entry_path_select";
            this.btn_render_entry_path_select.Size = new System.Drawing.Size(32, 21);
            this.btn_render_entry_path_select.TabIndex = 32;
            this.btn_render_entry_path_select.Text = "...";
            this.btn_render_entry_path_select.UseVisualStyleBackColor = true;
            this.btn_render_entry_path_select.Click += new System.EventHandler(this.btn_render_entry_path_select_Click);
            // 
            // txt_render_entry_path
            // 
            this.txt_render_entry_path.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_render_entry_path.Location = new System.Drawing.Point(538, 127);
            this.txt_render_entry_path.Name = "txt_render_entry_path";
            this.txt_render_entry_path.Size = new System.Drawing.Size(244, 20);
            this.txt_render_entry_path.TabIndex = 31;
            this.txt_render_entry_path.TextChanged += new System.EventHandler(this.txt_render_entry_path_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(514, 130);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(18, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "@";
            // 
            // txt_render_entry_id
            // 
            this.txt_render_entry_id.Location = new System.Drawing.Point(277, 127);
            this.txt_render_entry_id.Name = "txt_render_entry_id";
            this.txt_render_entry_id.Size = new System.Drawing.Size(231, 20);
            this.txt_render_entry_id.TabIndex = 29;
            this.txt_render_entry_id.TextChanged += new System.EventHandler(this.txt_render_entry_id_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(194, 130);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Bitmap entry:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 236);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Seed:";
            // 
            // txt_render_seed
            // 
            this.txt_render_seed.Location = new System.Drawing.Point(62, 233);
            this.txt_render_seed.Name = "txt_render_seed";
            this.txt_render_seed.Size = new System.Drawing.Size(119, 20);
            this.txt_render_seed.TabIndex = 26;
            this.txt_render_seed.TextChanged += new System.EventHandler(this.txt_render_seed_TextChanged);
            // 
            // btn_render_output_name_build
            // 
            this.btn_render_output_name_build.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_render_output_name_build.Location = new System.Drawing.Point(767, 61);
            this.btn_render_output_name_build.Name = "btn_render_output_name_build";
            this.btn_render_output_name_build.Size = new System.Drawing.Size(53, 20);
            this.btn_render_output_name_build.TabIndex = 25;
            this.btn_render_output_name_build.Text = "Builder";
            this.btn_render_output_name_build.UseVisualStyleBackColor = true;
            this.btn_render_output_name_build.Click += new System.EventHandler(this.btn_render_output_name_build_Click);
            // 
            // txt_render_output_name
            // 
            this.txt_render_output_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_render_output_name.Location = new System.Drawing.Point(277, 61);
            this.txt_render_output_name.Name = "txt_render_output_name";
            this.txt_render_output_name.Size = new System.Drawing.Size(487, 20);
            this.txt_render_output_name.TabIndex = 24;
            this.txt_render_output_name.TextChanged += new System.EventHandler(this.txt_render_output_name_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(194, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Output Name:";
            // 
            // txt_render_graph_output
            // 
            this.txt_render_graph_output.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_render_graph_output.Location = new System.Drawing.Point(600, 93);
            this.txt_render_graph_output.Name = "txt_render_graph_output";
            this.txt_render_graph_output.Size = new System.Drawing.Size(220, 20);
            this.txt_render_graph_output.TabIndex = 22;
            this.txt_render_graph_output.TextChanged += new System.EventHandler(this.txt_render_graph_output_TextChanged);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(514, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Render Output:";
            // 
            // txt_render_graph
            // 
            this.txt_render_graph.Location = new System.Drawing.Point(277, 92);
            this.txt_render_graph.Name = "txt_render_graph";
            this.txt_render_graph.Size = new System.Drawing.Size(231, 20);
            this.txt_render_graph.TabIndex = 20;
            this.txt_render_graph.TextChanged += new System.EventHandler(this.txt_render_graph_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(194, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Render Graph:";
            // 
            // numeric_render_budget
            // 
            this.numeric_render_budget.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numeric_render_budget.Location = new System.Drawing.Point(125, 207);
            this.numeric_render_budget.Maximum = new decimal(new int[] {
            16000,
            0,
            0,
            0});
            this.numeric_render_budget.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numeric_render_budget.Name = "numeric_render_budget";
            this.numeric_render_budget.Size = new System.Drawing.Size(56, 20);
            this.numeric_render_budget.TabIndex = 18;
            this.numeric_render_budget.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numeric_render_budget.ValueChanged += new System.EventHandler(this.numeric_render_budget_ValueChanged);
            // 
            // txt_render_engine
            // 
            this.txt_render_engine.Location = new System.Drawing.Point(62, 178);
            this.txt_render_engine.Name = "txt_render_engine";
            this.txt_render_engine.Size = new System.Drawing.Size(119, 20);
            this.txt_render_engine.TabIndex = 17;
            this.txt_render_engine.TextChanged += new System.EventHandler(this.txt_render_engine_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Memory Budget (MB):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Engine:";
            // 
            // combo_render_compression
            // 
            this.combo_render_compression.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_render_compression.Enabled = false;
            this.combo_render_compression.Items.AddRange(new object[] {
            "",
            "raw",
            "dxt1",
            "dxt3",
            "dxt5"});
            this.combo_render_compression.Location = new System.Drawing.Point(112, 149);
            this.combo_render_compression.Name = "combo_render_compression";
            this.combo_render_compression.Size = new System.Drawing.Size(69, 21);
            this.combo_render_compression.TabIndex = 14;
            this.combo_render_compression.SelectedIndexChanged += new System.EventHandler(this.combo_render_compression_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "DDS compression:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Fileformat:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // combo_render_fileformat
            // 
            this.combo_render_fileformat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_render_fileformat.Items.AddRange(new object[] {
            "",
            "dds",
            "bmp ",
            "ico",
            "jpg",
            "jif ",
            "jpeg",
            "jpe",
            "png",
            "tga",
            "targa ",
            "tif",
            "tiff",
            "wap",
            "wbmp",
            "wbm",
            "hdr",
            "exr",
            "jp2",
            "webp",
            "jxr",
            "wdp",
            "hdp"});
            this.combo_render_fileformat.Location = new System.Drawing.Point(71, 115);
            this.combo_render_fileformat.Name = "combo_render_fileformat";
            this.combo_render_fileformat.Size = new System.Drawing.Size(110, 21);
            this.combo_render_fileformat.TabIndex = 11;
            this.combo_render_fileformat.SelectedValueChanged += new System.EventHandler(this.combo_render_fileformat_SelectedValueChanged);
            // 
            // btn_render_output_select
            // 
            this.btn_render_output_select.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_render_output_select.Location = new System.Drawing.Point(788, 34);
            this.btn_render_output_select.Name = "btn_render_output_select";
            this.btn_render_output_select.Size = new System.Drawing.Size(32, 20);
            this.btn_render_output_select.TabIndex = 10;
            this.btn_render_output_select.Text = "...";
            this.btn_render_output_select.UseVisualStyleBackColor = true;
            this.btn_render_output_select.Click += new System.EventHandler(this.btn_render_output_select_Click);
            // 
            // txt_render_output
            // 
            this.txt_render_output.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_render_output.Location = new System.Drawing.Point(277, 35);
            this.txt_render_output.Name = "txt_render_output";
            this.txt_render_output.Size = new System.Drawing.Size(504, 20);
            this.txt_render_output.TabIndex = 9;
            this.txt_render_output.TextChanged += new System.EventHandler(this.txt_render_output_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Output Path:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_render_input_select
            // 
            this.btn_render_input_select.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_render_input_select.Location = new System.Drawing.Point(788, 6);
            this.btn_render_input_select.Name = "btn_render_input_select";
            this.btn_render_input_select.Size = new System.Drawing.Size(32, 20);
            this.btn_render_input_select.TabIndex = 7;
            this.btn_render_input_select.Text = "...";
            this.btn_render_input_select.UseVisualStyleBackColor = true;
            this.btn_render_input_select.Click += new System.EventHandler(this.btn_render_input_select_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Input File:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_render_input
            // 
            this.txt_render_input.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_render_input.Location = new System.Drawing.Point(277, 6);
            this.txt_render_input.Name = "txt_render_input";
            this.txt_render_input.Size = new System.Drawing.Size(505, 20);
            this.txt_render_input.TabIndex = 5;
            this.txt_render_input.TextChanged += new System.EventHandler(this.txt_render_input_TextChanged);
            // 
            // group_render_mode
            // 
            this.group_render_mode.Controls.Add(this.radio_render_render);
            this.group_render_mode.Controls.Add(this.radio_render_info);
            this.group_render_mode.Location = new System.Drawing.Point(6, 35);
            this.group_render_mode.Name = "group_render_mode";
            this.group_render_mode.Size = new System.Drawing.Size(175, 74);
            this.group_render_mode.TabIndex = 4;
            this.group_render_mode.TabStop = false;
            this.group_render_mode.Text = "Mode:";
            // 
            // radio_render_render
            // 
            this.radio_render_render.AutoSize = true;
            this.radio_render_render.Checked = true;
            this.radio_render_render.Location = new System.Drawing.Point(7, 44);
            this.radio_render_render.Name = "radio_render_render";
            this.radio_render_render.Size = new System.Drawing.Size(55, 17);
            this.radio_render_render.TabIndex = 1;
            this.radio_render_render.TabStop = true;
            this.radio_render_render.Text = "render";
            this.radio_render_render.UseVisualStyleBackColor = true;
            this.radio_render_render.CheckedChanged += new System.EventHandler(this.radio_render_render_CheckedChanged);
            // 
            // radio_render_info
            // 
            this.radio_render_info.AutoSize = true;
            this.radio_render_info.Location = new System.Drawing.Point(7, 20);
            this.radio_render_info.Name = "radio_render_info";
            this.radio_render_info.Size = new System.Drawing.Size(42, 17);
            this.radio_render_info.TabIndex = 0;
            this.radio_render_info.Text = "info";
            this.radio_render_info.UseVisualStyleBackColor = true;
            this.radio_render_info.CheckedChanged += new System.EventHandler(this.radio_render_info_CheckedChanged);
            // 
            // btn_render_help
            // 
            this.btn_render_help.Location = new System.Drawing.Point(92, 6);
            this.btn_render_help.Name = "btn_render_help";
            this.btn_render_help.Size = new System.Drawing.Size(89, 23);
            this.btn_render_help.TabIndex = 3;
            this.btn_render_help.Text = "Help";
            this.btn_render_help.UseVisualStyleBackColor = true;
            this.btn_render_help.Click += new System.EventHandler(this.btn_render_help_Click);
            // 
            // btn_render_version
            // 
            this.btn_render_version.Location = new System.Drawing.Point(6, 6);
            this.btn_render_version.Name = "btn_render_version";
            this.btn_render_version.Size = new System.Drawing.Size(80, 23);
            this.btn_render_version.TabIndex = 2;
            this.btn_render_version.Text = "Version";
            this.btn_render_version.UseVisualStyleBackColor = true;
            this.btn_render_version.Click += new System.EventHandler(this.btn_render_version_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Output";
            // 
            // txt_output
            // 
            this.txt_output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_output.Location = new System.Drawing.Point(16, 373);
            this.txt_output.Multiline = true;
            this.txt_output.Name = "txt_output";
            this.txt_output.ReadOnly = true;
            this.txt_output.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_output.Size = new System.Drawing.Size(826, 176);
            this.txt_output.TabIndex = 3;
            this.txt_output.WordWrap = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Preview:";
            // 
            // txt_preview
            // 
            this.txt_preview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_preview.Location = new System.Drawing.Point(64, 329);
            this.txt_preview.Name = "txt_preview";
            this.txt_preview.Size = new System.Drawing.Size(716, 20);
            this.txt_preview.TabIndex = 5;
            this.txt_preview.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_preview_KeyDown);
            // 
            // btn_run
            // 
            this.btn_run.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_run.Location = new System.Drawing.Point(783, 329);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(63, 20);
            this.btn_run.TabIndex = 6;
            this.btn_run.Text = "Run";
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 561);
            this.Controls.Add(this.btn_run);
            this.Controls.Add(this.txt_preview);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_output);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tab_manager);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "SD Batch Tools GUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tab_manager.ResumeLayout(false);
            this.tab_baker.ResumeLayout(false);
            this.tab_baker.PerformLayout();
            this.group_baker_mode.ResumeLayout(false);
            this.tab_cooker.ResumeLayout(false);
            this.tab_cooker.PerformLayout();
            this.tab_mutator.ResumeLayout(false);
            this.tab_mutator.PerformLayout();
            this.group_mutator_mode.ResumeLayout(false);
            this.tab_render.ResumeLayout(false);
            this.tab_render.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_render_budget)).EndInit();
            this.group_render_mode.ResumeLayout(false);
            this.group_render_mode.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stripitem_settings;
        private System.Windows.Forms.TabControl tab_manager;
        private System.Windows.Forms.TabPage tab_baker;
        private System.Windows.Forms.TabPage tab_cooker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_output;
        private System.Windows.Forms.ToolStripMenuItem clearOutputToolStripMenuItem;
        private System.Windows.Forms.TabPage tab_mutator;
        private System.Windows.Forms.TabPage tab_render;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_preview;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.ToolStripMenuItem killProcessToolStripMenuItem;
        private System.Windows.Forms.Button btn_baker_help;
        private System.Windows.Forms.Button btn_baker_version;
        private System.Windows.Forms.Button btn_cooker_help;
        private System.Windows.Forms.Button btn_cooker_version;
        private System.Windows.Forms.Button btn_mutator_help;
        private System.Windows.Forms.Button btn_mutator_version;
        private System.Windows.Forms.Button btn_render_help;
        private System.Windows.Forms.Button btn_render_version;
        private System.Windows.Forms.GroupBox group_render_mode;
        private System.Windows.Forms.RadioButton radio_render_render;
        private System.Windows.Forms.RadioButton radio_render_info;
        private System.Windows.Forms.TextBox txt_render_input;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_render_input_select;
        private System.Windows.Forms.TextBox txt_render_output;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_render_output_select;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox combo_render_fileformat;
        private System.Windows.Forms.ComboBox combo_render_compression;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_render_engine;
        private System.Windows.Forms.NumericUpDown numeric_render_budget;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_render_graph;
        private System.Windows.Forms.TextBox txt_render_graph_output;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_render_output_name_build;
        private System.Windows.Forms.TextBox txt_render_output_name;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_render_seed;
        private System.Windows.Forms.TextBox txt_render_entry_path;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_render_entry_id;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_render_entry_path_select;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_render_output_size;
        private System.Windows.Forms.TextBox txt_render_pixel_size;
        private System.Windows.Forms.TextBox txt_render_values;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportOutputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportAsBATToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem openOutputFolderToolStripMenuItem;
        private System.Windows.Forms.CheckBox check_cooker_output_size;
        private System.Windows.Forms.CheckBox check_cooker_optimation;
        private System.Windows.Forms.CheckBox check_cooker_random_seed;
        private System.Windows.Forms.CheckBox check_cooker_pixel_size;
        private System.Windows.Forms.CheckBox check_cooker_merge;
        private System.Windows.Forms.CheckBox check_cooker_archive;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btn_cooker_input_select;
        private System.Windows.Forms.TextBox txt_cooker_input;
        private System.Windows.Forms.Button btn_cooker_output_folder;
        private System.Windows.Forms.TextBox txt_cooker_output_folder;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txt_cooker_output_name;
        private System.Windows.Forms.TextBox txt_cooker_sizelimit;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txt_cooker_alias;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btn_cooker_includes_select;
        private System.Windows.Forms.TextBox txt_cooker_includes;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditsToolStripMenuItem;
        private System.Windows.Forms.GroupBox group_mutator_mode;
        private System.Windows.Forms.ComboBox combo_mutator_mode;
        private System.Windows.Forms.TextBox txt_mutator_output_name;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button btn_output_path_select;
        private System.Windows.Forms.TextBox txt_mutator_output_path;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btn_mutator_input_select;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txt_mutator_input;
        private System.Windows.Forms.CheckBox check_mutator_depend;
        private System.Windows.Forms.CheckBox check_mutator_merge;
        private System.Windows.Forms.CheckBox check_mutator_hide_params;
        private System.Windows.Forms.TextBox txt_mutator_alias;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txt_mutator_graph_name;
        private System.Windows.Forms.Button btn_mutator_presets_select;
        private System.Windows.Forms.TextBox txt_mutator_presets;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox txt_mutator_set_default;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox txt_mutator_switch_to_constant;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txt_mutator_connect_image;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox txt_mutator_connect_input;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox txt_mutator_input_graph;
        private System.Windows.Forms.GroupBox group_baker_mode;
        private System.Windows.Forms.ComboBox combo_baker_mode;
        private System.Windows.Forms.Button btn_baker_input_select;
        private System.Windows.Forms.TextBox txt_baker_input;
        private System.Windows.Forms.Label label35;
    }
}

