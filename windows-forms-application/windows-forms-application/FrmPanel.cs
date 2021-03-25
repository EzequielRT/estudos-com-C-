using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace windows_forms_application
{
    public partial class FrmPanel : Form
    {
        public FrmPanel()
        {
            InitializeComponent();
        }

        private void BtnAlerta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O dado digitado é: " + TxtNome.Text);
        }

        private void BtnShowCadastro_Click(object sender, EventArgs e)
        {
            PnlCadastro.Visible = true;
            PnlLista.Visible = false;
        }

        private void FrmPanel_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Estado.Lista();
        }

        private void BtnShowLista_Click(object sender, EventArgs e)
        {
            PnlLista.Visible = true;
            PnlCadastro.Visible = false;
        }
    }
}
