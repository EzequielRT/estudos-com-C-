
namespace windows_forms_application
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.cboEstados = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.lblNomeGrid = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.novoTexto = new System.Windows.Forms.ToolStripMenuItem();
            this.sair = new System.Windows.Forms.ToolStripMenuItem();
            this.info = new System.Windows.Forms.ToolStripMenuItem();
            this.sobre = new System.Windows.Forms.ToolStripMenuItem();
            this.licenca = new System.Windows.Forms.ToolStripMenuItem();
            this.doacao = new System.Windows.Forms.ToolStripMenuItem();
            this.LblHoraAtual = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(33, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(495, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pressione OK para preencher a caixa de texto";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(40, 86);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(488, 27);
            this.txtResultado.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(40, 311);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(390, 105);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(40, 533);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(181, 41);
            this.btnAbrir.TabIndex = 3;
            this.btnAbrir.Text = "Abrir nova janela";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.BtnAbrir_Click);
            // 
            // cboEstados
            // 
            this.cboEstados.FormattingEnabled = true;
            this.cboEstados.Items.AddRange(new object[] {
            "Acre (AC)",
            "Alagoas (AL)",
            "Amapá (AP)",
            "Amazonas (AM)",
            "Bahia (BA)",
            "Ceará (CE)",
            "Distrito Federal (DF)",
            "Espírito Santo (ES)",
            "Goiás (GO)",
            "Maranhão (MA)",
            "Mato Grosso (MT)",
            "Mato Grosso do Sul (MS)",
            "Minas Gerais (MG)",
            "Pará (PA)",
            "Paraíba (PB)",
            "Paraná (PR)",
            "Pernambuco (PE)",
            "Piauí (PI)",
            "Rio de Janeiro (RJ)",
            "Rio Grande do Norte (RN)",
            "Rio Grande do Sul (RS)",
            "Rondônia (RO)",
            "Roraima (RR)",
            "Santa Catarina (SC)",
            "São Paulo (SP)",
            "Sergipe (SE)",
            "Tocantins (TO)"});
            this.cboEstados.Location = new System.Drawing.Point(40, 172);
            this.cboEstados.Name = "cboEstados";
            this.cboEstados.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboEstados.Size = new System.Drawing.Size(488, 28);
            this.cboEstados.TabIndex = 4;
            this.cboEstados.Text = "[Selecione]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(33, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Estados:";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(465, 362);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 29;
            this.dataGridView.Size = new System.Drawing.Size(483, 185);
            this.dataGridView.TabIndex = 6;
            // 
            // lblNomeGrid
            // 
            this.lblNomeGrid.AutoSize = true;
            this.lblNomeGrid.Location = new System.Drawing.Point(608, 337);
            this.lblNomeGrid.Name = "lblNomeGrid";
            this.lblNomeGrid.Size = new System.Drawing.Size(205, 20);
            this.lblNomeGrid.TabIndex = 7;
            this.lblNomeGrid.Text = "Dados da coleção de estados";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivo,
            this.info});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1029, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = " ";
            // 
            // arquivo
            // 
            this.arquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoTexto,
            this.sair});
            this.arquivo.Name = "arquivo";
            this.arquivo.Size = new System.Drawing.Size(53, 20);
            this.arquivo.Text = "Arquivo";
            // 
            // novoTexto
            // 
            this.novoTexto.Name = "novoTexto";
            this.novoTexto.Size = new System.Drawing.Size(133, 26);
            this.novoTexto.Text = "Novo texto";
            this.novoTexto.Click += new System.EventHandler(this.NovoTexto_Click);
            // 
            // sair
            // 
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(133, 26);
            this.sair.Text = "Sair";
            this.sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // info
            // 
            this.info.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobre,
            this.licenca,
            this.doacao});
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(37, 20);
            this.info.Text = "Info";
            // 
            // sobre
            // 
            this.sobre.Name = "sobre";
            this.sobre.Size = new System.Drawing.Size(118, 26);
            this.sobre.Text = "Sobre";
            this.sobre.Click += new System.EventHandler(this.Sobre_Click);
            // 
            // licenca
            // 
            this.licenca.Name = "licenca";
            this.licenca.Size = new System.Drawing.Size(118, 26);
            this.licenca.Text = "Licença";
            this.licenca.Click += new System.EventHandler(this.Licenca_Click);
            // 
            // doacao
            // 
            this.doacao.Name = "doacao";
            this.doacao.Size = new System.Drawing.Size(118, 26);
            this.doacao.Text = "Doação";
            this.doacao.Click += new System.EventHandler(this.Doacao_Click);
            // 
            // LblHoraAtual
            // 
            this.LblHoraAtual.AutoSize = true;
            this.LblHoraAtual.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblHoraAtual.Location = new System.Drawing.Point(465, 242);
            this.LblHoraAtual.Name = "LblHoraAtual";
            this.LblHoraAtual.Size = new System.Drawing.Size(473, 37);
            this.LblHoraAtual.TabIndex = 9;
            this.LblHoraAtual.Text = "Dia e Hora atual: 01/01/0000 00:00:00";
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 680);
            this.Controls.Add(this.LblHoraAtual);
            this.Controls.Add(this.lblNomeGrid);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboEstados);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Aplicação 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.ComboBox cboEstados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label lblNomeGrid;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivo;
        private System.Windows.Forms.ToolStripMenuItem novoTexto;
        private System.Windows.Forms.ToolStripMenuItem sair;
        private System.Windows.Forms.ToolStripMenuItem info;
        private System.Windows.Forms.ToolStripMenuItem sobre;
        private System.Windows.Forms.ToolStripMenuItem licenca;
        private System.Windows.Forms.ToolStripMenuItem doacao;
        private System.Windows.Forms.Label LblHoraAtual;
        private System.Windows.Forms.Timer Timer;
    }
}

