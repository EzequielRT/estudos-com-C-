using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace windows_forms_application
{
    public partial class FrmLicenca : Form
    {
        public FrmLicenca()
        {
            InitializeComponent();
        }

         private void FrmLicenca_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psInfo = new ProcessStartInfo
            {
                FileName = "https://www.google.com",
                UseShellExecute = true
            };
            Process.Start(psInfo);
        }   

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programa registrado");
        }
    }
}
