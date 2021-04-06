using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacaoTresCamadas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            var usuario = new Usuario();
            usuario.Nome = TxtNome.Text;
            usuario.Telefone = TxtTelefone.Text;
            usuario.CPF = TxtCPF.Text;
            usuario.Gravar();

            MessageBox.Show("Usuário salvo com sucesso!");
        }
    }
}
