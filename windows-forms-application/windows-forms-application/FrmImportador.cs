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

    public partial class FrmImportador : Form
    {
        private string[] lines;

        public FrmImportador()
        {
            InitializeComponent();
        }

        private void FrmImportador_Load(object sender, EventArgs e)
        {
            string fileName = @"C:\Arquivos\dados.importar.txt";
            using (var streamReader = File.OpenText(fileName))
            {
                lines = streamReader.ReadToEnd().Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                progressBar1.Maximum = lines.Length;
                progressBar1.Minimum = 0;
            }
        }

        private void BtnImportar_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < lines.Length; i++)
            {
                var line = lines[i];
                progressBar1.Value = (i + 1);
            }

            TxtLogs.Text = "Todos os dados foram importados!";
        }
    }

    
}
