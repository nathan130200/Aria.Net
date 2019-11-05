namespace Aria.Net.Test
{
    partial class DownloadUserControl
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbFileNameOrTitle = new System.Windows.Forms.CopyableLabel();
            this.pgStatus = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // tbFileNameOrTitle
            // 
            this.tbFileNameOrTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFileNameOrTitle.BackColor = System.Drawing.SystemColors.Window;
            this.tbFileNameOrTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbFileNameOrTitle.Location = new System.Drawing.Point(4, 4);
            this.tbFileNameOrTitle.Name = "tbFileNameOrTitle";
            this.tbFileNameOrTitle.ReadOnly = true;
            this.tbFileNameOrTitle.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbFileNameOrTitle.Size = new System.Drawing.Size(396, 14);
            this.tbFileNameOrTitle.TabIndex = 0;
            // 
            // pgStatus
            // 
            this.pgStatus.Location = new System.Drawing.Point(4, 24);
            this.pgStatus.Name = "pgStatus";
            this.pgStatus.Size = new System.Drawing.Size(396, 16);
            this.pgStatus.TabIndex = 1;
            // 
            // DownloadUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pgStatus);
            this.Controls.Add(this.tbFileNameOrTitle);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.MaximumSize = new System.Drawing.Size(404, 999999);
            this.Name = "DownloadUserControl";
            this.Size = new System.Drawing.Size(404, 46);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CopyableLabel tbFileNameOrTitle;
        private System.Windows.Forms.ProgressBar pgStatus;
    }
}
