
namespace windows_forms_application
{
    partial class FrmPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPanel));
            this.PnlCadastro = new System.Windows.Forms.Panel();
            this.BtnAlerta = new System.Windows.Forms.Button();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnShowCadastro = new System.Windows.Forms.Button();
            this.PnlLista = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnShowLista = new System.Windows.Forms.Button();
            this.PnlCadastro.SuspendLayout();
            this.PnlLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlCadastro
            // 
            this.PnlCadastro.Controls.Add(this.BtnAlerta);
            this.PnlCadastro.Controls.Add(this.TxtNome);
            this.PnlCadastro.Controls.Add(this.label1);
            this.PnlCadastro.Location = new System.Drawing.Point(21, 68);
            this.PnlCadastro.Name = "PnlCadastro";
            this.PnlCadastro.Size = new System.Drawing.Size(430, 331);
            this.PnlCadastro.TabIndex = 0;
            this.PnlCadastro.Visible = false;
            // 
            // BtnAlerta
            // 
            this.BtnAlerta.Location = new System.Drawing.Point(288, 42);
            this.BtnAlerta.Name = "BtnAlerta";
            this.BtnAlerta.Size = new System.Drawing.Size(94, 29);
            this.BtnAlerta.TabIndex = 2;
            this.BtnAlerta.Text = "OK";
            this.BtnAlerta.UseVisualStyleBackColor = true;
            this.BtnAlerta.Click += new System.EventHandler(this.BtnAlerta_Click);
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(81, 43);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(201, 27);
            this.TxtNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(19, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // BtnShowCadastro
            // 
            this.BtnShowCadastro.Location = new System.Drawing.Point(21, 22);
            this.BtnShowCadastro.Name = "BtnShowCadastro";
            this.BtnShowCadastro.Size = new System.Drawing.Size(110, 29);
            this.BtnShowCadastro.TabIndex = 1;
            this.BtnShowCadastro.Text = "Mostrar Cadastro";
            this.BtnShowCadastro.UseVisualStyleBackColor = true;
            this.BtnShowCadastro.Click += new System.EventHandler(this.BtnShowCadastro_Click);
            // 
            // PnlLista
            // 
            this.PnlLista.Controls.Add(this.dataGridView1);
            this.PnlLista.Controls.Add(this.label2);
            this.PnlLista.Location = new System.Drawing.Point(488, 68);
            this.PnlLista.Name = "PnlLista";
            this.PnlLista.Size = new System.Drawing.Size(430, 331);
            this.PnlLista.TabIndex = 2;
            this.PnlLista.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(361, 242);
            this.dataGridView1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(30, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Lista";
            // 
            // BtnShowLista
            // 
            this.BtnShowLista.Location = new System.Drawing.Point(488, 22);
            this.BtnShowLista.Name = "BtnShowLista";
            this.BtnShowLista.Size = new System.Drawing.Size(94, 29);
            this.BtnShowLista.TabIndex = 3;
            this.BtnShowLista.Text = "Mostrar Lista";
            this.BtnShowLista.UseVisualStyleBackColor = true;
            this.BtnShowLista.Click += new System.EventHandler(this.BtnShowLista_Click);
            // 
            // FrmPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 591);
            this.Controls.Add(this.BtnShowLista);
            this.Controls.Add(this.PnlLista);
            this.Controls.Add(this.BtnShowCadastro);
            this.Controls.Add(this.PnlCadastro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPanel";
            this.Text = "Mostrar Lista";
            this.Load += new System.EventHandler(this.FrmPanel_Load);
            this.PnlCadastro.ResumeLayout(false);
            this.PnlCadastro.PerformLayout();
            this.PnlLista.ResumeLayout(false);
            this.PnlLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlCadastro;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAlerta;
        private System.Windows.Forms.Button BtnShowCadastro;
        private System.Windows.Forms.Panel PnlLista;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnShowLista;
    }
}