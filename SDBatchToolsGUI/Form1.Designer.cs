namespace SDBatchToolsGUI
{
    partial class Form1
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
            this.stripitem_settings = new System.Windows.Forms.ToolStripMenuItem();
            this.clearOutputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.killProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tab_manager = new System.Windows.Forms.TabControl();
            this.tab_baker = new System.Windows.Forms.TabPage();
            this.btn_baker_help = new System.Windows.Forms.Button();
            this.btn_baker_version = new System.Windows.Forms.Button();
            this.tab_cooker = new System.Windows.Forms.TabPage();
            this.btn_cooker_help = new System.Windows.Forms.Button();
            this.btn_cooker_version = new System.Windows.Forms.Button();
            this.tab_mutator = new System.Windows.Forms.TabPage();
            this.btn_mutator_help = new System.Windows.Forms.Button();
            this.btn_mutator_version = new System.Windows.Forms.Button();
            this.tab_render = new System.Windows.Forms.TabPage();
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
            this.tab_cooker.SuspendLayout();
            this.tab_mutator.SuspendLayout();
            this.tab_render.SuspendLayout();
            this.group_render_mode.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripitem_settings,
            this.clearOutputToolStripMenuItem,
            this.killProcessToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(858, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
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
            this.btn_render_help.Location = new System.Drawing.Point(87, 6);
            this.btn_render_help.Name = "btn_render_help";
            this.btn_render_help.Size = new System.Drawing.Size(75, 23);
            this.btn_render_help.TabIndex = 3;
            this.btn_render_help.Text = "Help";
            this.btn_render_help.UseVisualStyleBackColor = true;
            this.btn_render_help.Click += new System.EventHandler(this.btn_render_help_Click);
            // 
            // btn_render_version
            // 
            this.btn_render_version.Location = new System.Drawing.Point(6, 6);
            this.btn_render_version.Name = "btn_render_version";
            this.btn_render_version.Size = new System.Drawing.Size(75, 23);
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
            // Form1
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
            this.Name = "Form1";
            this.Text = "SD Batch Tools GUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tab_manager.ResumeLayout(false);
            this.tab_baker.ResumeLayout(false);
            this.tab_cooker.ResumeLayout(false);
            this.tab_mutator.ResumeLayout(false);
            this.tab_render.ResumeLayout(false);
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
    }
}

