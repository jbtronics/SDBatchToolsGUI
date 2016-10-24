namespace SDBatchToolsGUI
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lbl_path = new System.Windows.Forms.Label();
            this.txt_tools_path = new System.Windows.Forms.TextBox();
            this.btn_path_select = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numeric_max_mem = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_max_mem)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ok
            // 
            this.btn_ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_ok.Location = new System.Drawing.Point(12, 188);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 0;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_cancel.Location = new System.Drawing.Point(93, 188);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lbl_path
            // 
            this.lbl_path.AutoSize = true;
            this.lbl_path.Location = new System.Drawing.Point(9, 14);
            this.lbl_path.Name = "lbl_path";
            this.lbl_path.Size = new System.Drawing.Size(104, 13);
            this.lbl_path.TabIndex = 2;
            this.lbl_path.Text = "Path to Batch Tools:";
            // 
            // txt_tools_path
            // 
            this.txt_tools_path.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_tools_path.Location = new System.Drawing.Point(12, 30);
            this.txt_tools_path.Name = "txt_tools_path";
            this.txt_tools_path.Size = new System.Drawing.Size(278, 20);
            this.txt_tools_path.TabIndex = 3;
            // 
            // btn_path_select
            // 
            this.btn_path_select.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_path_select.Location = new System.Drawing.Point(296, 30);
            this.btn_path_select.Name = "btn_path_select";
            this.btn_path_select.Size = new System.Drawing.Size(34, 20);
            this.btn_path_select.TabIndex = 4;
            this.btn_path_select.Text = "...";
            this.btn_path_select.UseVisualStyleBackColor = true;
            this.btn_path_select.Click += new System.EventHandler(this.btn_path_select_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Max. engine memory:";
            // 
            // numeric_max_mem
            // 
            this.numeric_max_mem.Location = new System.Drawing.Point(13, 79);
            this.numeric_max_mem.Maximum = new decimal(new int[] {
            32000,
            0,
            0,
            0});
            this.numeric_max_mem.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numeric_max_mem.Name = "numeric_max_mem";
            this.numeric_max_mem.Size = new System.Drawing.Size(120, 20);
            this.numeric_max_mem.TabIndex = 6;
            this.numeric_max_mem.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "MB";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 223);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numeric_max_mem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_path_select);
            this.Controls.Add(this.txt_tools_path);
            this.Controls.Add(this.lbl_path);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numeric_max_mem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lbl_path;
        private System.Windows.Forms.TextBox txt_tools_path;
        private System.Windows.Forms.Button btn_path_select;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numeric_max_mem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}