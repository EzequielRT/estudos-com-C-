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
            var contextMenu = new ContextMenuStrip();
            contextMenu.Items.Add(new ToolStripMenuItem("Abrir Ler arquivo", null, NovoTexto_Click));
            contextMenu.Items.Add(new ToolStripMenuItem("Abrir Cadastro", null, Cadastro_Click));
            contextMenu.Items.Add(new ToolStripMenuItem("Fechar", null, Sair_Click));            
            NotifyIcon.ContextMenuStrip = contextMenu;

            AtualizaHora();

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
            /*var data = from estado in Estado.Lista()
                       //where estado.Id == 1 || estado.Id == 2
                       //orderby estado.Nome
                       select new
                       {
                           Id = estado.Id,
                           Nome = estado.Nome
                       };

            dataGridView.DataSource = data.ToList();*/

            //Maneira complexa de utilizar
            dataGridView.ColumnCount = 2;
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
            }

        }

        private void AtualizaHora()
        {
            LblHoraAtual.Text = "Dia e Hora atual: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "Olá Ezequiel este é o seu primeiro programa - " + ((Estado)cboEstados.SelectedItem).Id;
        }

        private void BtnAbrir_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Inicializando novo formulário");

            var form = new FrmShow();
            form.lblMensagem.Text = txtResultado.Text;
            form.Show();
        }

        private void NovoTexto_Click(object sender, EventArgs e)
        {
            var frmTexto = new FrmTexto();
            frmTexto.MdiParent = MDISingleton.InstanciaMDI();
            frmTexto.Show();
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Sobre_Click(object sender, EventArgs e)
        {
            new FrmSobre().Show();
        }

        private void Licenca_Click(object sender, EventArgs e)
        {
            new FrmLicenca().Show();
        }

        private void Doacao_Click(object sender, EventArgs e)
        {
            new FrmDoacao().Show();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            AtualizaHora();
        }

        private void Cadastro_Click(object sender, EventArgs e)
        {
            new FrmCadastro().Show();
        }

        private void NotifyIcon1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Cliquei no icone");
        }

        private void NotifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("dois cliques no icone");
        }

        private void BtnNotificacao_Click(object sender, EventArgs e)
        {
            NotifyIcon.ShowBalloonTip(10, "Notificação", "Erro na aplicação", ToolTipIcon.Error);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            new MDIParentPrincipal().Show();
        }
    }
}
