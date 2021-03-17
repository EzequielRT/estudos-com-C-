using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows_forms_application
{
    public partial class Form1 : Form
    {
        public Form1()  // Construtor da classe
        {
            //MessageBox.Show("Inicializando formulário pelo construtor");
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Inicializando o formulário");

            /***********************************************/
            cboEstados.DataSource = Estado.Lista();
            cboEstados.Text = "[Selecione]";

            /*cboEstados.Items.Clear(); 
            foreach (Estado estado in Estado.Lista())
            {
                cboEstados.Items.Add(estado);
            }*/
            /***********************************************/

            //Maneira simples de utilizar
            //dataGridView.DataSource = Estado.Lista();

            //Maneira intermediária de utilizar
            //Utilizando Link
            var data = from estado in Estado.Lista()
                       //where estado.Id == 1 || estado.Id == 2
                       //orderby estado.Nome
                       select new
                       {
                           Id = estado.Id,
                           Nome = estado.Nome
                       };

            dataGridView.DataSource = data.ToList();

            //Maneira complexa de utilizar
            /*dataGridView.ColumnCount = 2;
            dataGridView.Columns[0].Name = "Id";
            dataGridView.Columns[1].Name = "Nome";

            var rows = new List<string[]>();
            foreach (Estado estado in Estado.Lista())
            {
                string[] row1 = new string[] { estado.Id.ToString(), estado.Nome };
                rows.Add(row1);
            }

            foreach (string[] rowArray in rows)
            {
                dataGridView.Rows.Add(rowArray);
            }*/

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "Olá Ezequiel este é o seu primeiro programa - " + ((Estado)cboEstados.SelectedItem).Id;
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            var form = new FrmShow();
            form.lblMensagem.Text = txtResultado.Text;
            form.Show();
        }
    }
}
