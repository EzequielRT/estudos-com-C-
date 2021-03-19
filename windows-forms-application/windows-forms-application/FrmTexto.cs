using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace windows_forms_application
{
    public partial class FrmTexto : Form
    {
        public FrmTexto()
        {
            InitializeComponent();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            SalvarArquivo();
        }

        private void SalvarArquivo()
        {
            File.WriteAllText(@"C:\Arquivos\Texto" + DateTime.Now.ToString("dd-MM-yyy-HH-mm-ss") + ".txt", txtTexto.Text);
            MessageBox.Show("Arquivo salvo");
            txtTexto.Text = string.Empty;
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            SalvarArquivo();
        }
    }
}
