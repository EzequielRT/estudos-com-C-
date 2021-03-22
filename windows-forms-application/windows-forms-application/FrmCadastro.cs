using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace windows_forms_application
{
    public partial class FrmCadastro : Form
    {
        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {            
            var nome = TxtNome.Text;
            try
            {
                int numero = Convert.ToInt32(TxtNumero.Text);

                if (numero == 2)
                {
                    throw new ErroDeProposito("Erro de propósito");
                }
                else if (numero == 4)
                {
                    throw new Exception("Erro genérico");
                }

                numero += 100;

                MessageBox.Show("Olá " + nome + ", o valor do número + 100 é de: " + numero);
            }
            catch (FormatException errFormat)
            {
                MessageBox.Show("Olá cliente, você por acaso não digitou letra no lugar de número aqui? (" + errFormat.Message + ")");
                TxtNumero.Focus();
            }
            catch (ErroDeProposito errProposito)
            {
                MessageBox.Show(errProposito.Message);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                MessageBox.Show("Todas as minhas exceções tratadas.");
            }
        }
    }

    public class ErroDeProposito : Exception
    {
        public ErroDeProposito(string erro) : base(erro) { }
    }
}
