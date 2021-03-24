
namespace windows_forms_application
{
    partial class FrmImportador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmImportador));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.BtnImportar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtLogs = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(126, 108);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(442, 38);
            this.progressBar1.TabIndex = 0;
            // 
            // BtnImportar
            // 
            this.BtnImportar.Location = new System.Drawing.Point(298, 402);
            this.BtnImportar.Name = "BtnImportar";
            this.BtnImportar.Size = new System.Drawing.Size(94, 29);
            this.BtnImportar.TabIndex = 1;
            this.BtnImportar.Text = "Importar";
            this.BtnImportar.UseVisualStyleBackColor = true;
            this.BtnImportar.Click += new System.EventHandler(this.BtnImportar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(126, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Clique no botão importar para atualizar os dados";
            // 
            // TxtLogs
            // 
            this.TxtLogs.Enabled = false;
            this.TxtLogs.Location = new System.Drawing.Point(126, 162);
            this.TxtLogs.Multiline = true;
            this.TxtLogs.Name = "TxtLogs";
            this.TxtLogs.Size = new System.Drawing.Size(442, 228);
            this.TxtLogs.TabIndex = 3;
            // 
            // FrmImportador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 469);
            this.Controls.Add(this.TxtLogs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnImportar);
            this.Controls.Add(this.progressBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmImportador";
            this.Text = "FrmImportador";
            this.Load += new System.EventHandler(this.FrmImportador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button BtnImportar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtLogs;
    }
}