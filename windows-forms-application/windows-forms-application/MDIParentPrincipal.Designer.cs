
namespace windows_forms_application
{
    partial class MDIParentPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIParentPrincipal));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.MenuArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.NovoFormulario = new System.Windows.Forms.ToolStripMenuItem();
            this.AbrirFormulario = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Sair = new System.Windows.Forms.ToolStripMenuItem();
            this.AbrirForm1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuArquivo});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip.Size = new System.Drawing.Size(2077, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // MenuArquivo
            // 
            this.MenuArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NovoFormulario,
            this.AbrirFormulario,
            this.AbrirForm1,
            this.toolStripSeparator1,
            this.Sair});
            this.MenuArquivo.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.MenuArquivo.Name = "MenuArquivo";
            this.MenuArquivo.Size = new System.Drawing.Size(53, 18);
            this.MenuArquivo.Text = "Arquivo";
            // 
            // NovoFormulario
            // 
            this.NovoFormulario.Image = ((System.Drawing.Image)(resources.GetObject("NovoFormulario.Image")));
            this.NovoFormulario.ImageTransparentColor = System.Drawing.Color.Black;
            this.NovoFormulario.Name = "NovoFormulario";
            this.NovoFormulario.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.NovoFormulario.Size = new System.Drawing.Size(191, 26);
            this.NovoFormulario.Text = "Novo Formulário";
            this.NovoFormulario.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // AbrirFormulario
            // 
            this.AbrirFormulario.Image = ((System.Drawing.Image)(resources.GetObject("AbrirFormulario.Image")));
            this.AbrirFormulario.ImageTransparentColor = System.Drawing.Color.Black;
            this.AbrirFormulario.Name = "AbrirFormulario";
            this.AbrirFormulario.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.AbrirFormulario.Size = new System.Drawing.Size(191, 26);
            this.AbrirFormulario.Text = "Abrir";
            this.AbrirFormulario.Click += new System.EventHandler(this.OpenFile);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(188, 6);
            // 
            // Sair
            // 
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(191, 26);
            this.Sair.Text = "Sair";
            this.Sair.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // AbrirForm1
            // 
            this.AbrirForm1.Image = global::windows_forms_application.Properties.Resources.formularios_do_google;
            this.AbrirForm1.Name = "AbrirForm1";
            this.AbrirForm1.Size = new System.Drawing.Size(191, 26);
            this.AbrirForm1.Text = "Form 1";
            this.AbrirForm1.Click += new System.EventHandler(this.AbrirForm1_Click);
            // 
            // MDIParentPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2077, 1325);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MDIParentPrincipal";
            this.Text = "MDIParentPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem MenuArquivo;
        private System.Windows.Forms.ToolStripMenuItem NovoFormulario;
        private System.Windows.Forms.ToolStripMenuItem AbrirFormulario;
        private System.Windows.Forms.ToolStripMenuItem Sair;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem AbrirForm1;
    }
}



