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
    public partial class OutputNameBuilder : Form
    {
        public OutputNameBuilder()
        {
            InitializeComponent();
        }

        private void btn_inputname_Click(object sender, EventArgs e)
        {
            txt_box.Text += "{inputName}";
        }

        private void btn_inputgraphurl_Click(object sender, EventArgs e)
        {
            txt_box.Text += "{inputGraphUrl}";
        }

        private void btn_outputnodename_Click(object sender, EventArgs e)
        {
            txt_box.Text += "{outputNodeName}";
        }

        public string Result { get; set; }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            Result = txt_box.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Result = txt_box.Text;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_box.Text = "";
        }
    }
}
