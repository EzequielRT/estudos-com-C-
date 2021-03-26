using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace windows_forms_application
{
    public partial class FrmTabControl : Form
    {
        public FrmTabControl()
        {
            InitializeComponent();
        }

        private void FrmTabControl_Load(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabPage3");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabPage1");
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabPage2");
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabPage3");
        }
    }
}
