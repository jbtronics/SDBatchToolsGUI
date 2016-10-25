namespace SDBatchToolsGUI
{
    partial class OutputNameBuilder
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
            this.txt_box = new System.Windows.Forms.TextBox();
            this.btn_inputname = new System.Windows.Forms.Button();
            this.btn_inputgraphurl = new System.Windows.Forms.Button();
            this.btn_outputnodename = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ok
            // 
            this.btn_ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ok.Location = new System.Drawing.Point(320, 12);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 0;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.Location = new System.Drawing.Point(320, 41);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // txt_box
            // 
            this.txt_box.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_box.Location = new System.Drawing.Point(12, 15);
            this.txt_box.Multiline = true;
            this.txt_box.Name = "txt_box";
            this.txt_box.Size = new System.Drawing.Size(302, 112);
            this.txt_box.TabIndex = 2;
            // 
            // btn_inputname
            // 
            this.btn_inputname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_inputname.Location = new System.Drawing.Point(12, 133);
            this.btn_inputname.Name = "btn_inputname";
            this.btn_inputname.Size = new System.Drawing.Size(110, 23);
            this.btn_inputname.TabIndex = 3;
            this.btn_inputname.Text = "{inputName}";
            this.btn_inputname.UseVisualStyleBackColor = true;
            this.btn_inputname.Click += new System.EventHandler(this.btn_inputname_Click);
            // 
            // btn_inputgraphurl
            // 
            this.btn_inputgraphurl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_inputgraphurl.Location = new System.Drawing.Point(128, 133);
            this.btn_inputgraphurl.Name = "btn_inputgraphurl";
            this.btn_inputgraphurl.Size = new System.Drawing.Size(110, 23);
            this.btn_inputgraphurl.TabIndex = 4;
            this.btn_inputgraphurl.Text = "{inputGraphUrl}";
            this.btn_inputgraphurl.UseVisualStyleBackColor = true;
            this.btn_inputgraphurl.Click += new System.EventHandler(this.btn_inputgraphurl_Click);
            // 
            // btn_outputnodename
            // 
            this.btn_outputnodename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_outputnodename.Location = new System.Drawing.Point(244, 133);
            this.btn_outputnodename.Name = "btn_outputnodename";
            this.btn_outputnodename.Size = new System.Drawing.Size(110, 23);
            this.btn_outputnodename.TabIndex = 5;
            this.btn_outputnodename.Text = "{outputNodeName}";
            this.btn_outputnodename.UseVisualStyleBackColor = true;
            this.btn_outputnodename.Click += new System.EventHandler(this.btn_outputnodename_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_clear.Location = new System.Drawing.Point(320, 93);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 6;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // OutputNameBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 168);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_inputgraphurl);
            this.Controls.Add(this.btn_inputname);
            this.Controls.Add(this.txt_box);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_outputnodename);
            this.Name = "OutputNameBuilder";
            this.Text = "Output Name Builder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox txt_box;
        private System.Windows.Forms.Button btn_inputname;
        private System.Windows.Forms.Button btn_inputgraphurl;
        private System.Windows.Forms.Button btn_outputnodename;
        private System.Windows.Forms.Button btn_clear;
    }
}