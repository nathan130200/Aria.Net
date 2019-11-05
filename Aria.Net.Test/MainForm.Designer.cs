namespace Aria.Net.Test
{
    partial class MainForm
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
            this.tbEndPoint = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.gbxStats = new System.Windows.Forms.GroupBox();
            this.lbDownloadSpeed = new System.Windows.Forms.Label();
            this.lbUploadSpeed = new System.Windows.Forms.Label();
            this.lbWaitingDownloads = new System.Windows.Forms.Label();
            this.lbStoppedDownloads = new System.Windows.Forms.Label();
            this.lbTotalStoppedDownloads = new System.Windows.Forms.Label();
            this.lbActiveDownloads = new System.Windows.Forms.Label();
            this.tbActiveDownloads = new System.Windows.Forms.CopyableLabel();
            this.tbTotalDownloads = new System.Windows.Forms.CopyableLabel();
            this.tbStoppedDownloads = new System.Windows.Forms.CopyableLabel();
            this.tbDownloadsInQueue = new System.Windows.Forms.CopyableLabel();
            this.tbUploadSpeed = new System.Windows.Forms.CopyableLabel();
            this.tbDownloadSpeed = new System.Windows.Forms.CopyableLabel();
            this.flpDownloads = new System.Windows.Forms.FlowLayoutPanel();
            this.gbxStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbEndPoint
            // 
            this.tbEndPoint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEndPoint.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEndPoint.Location = new System.Drawing.Point(8, 8);
            this.tbEndPoint.Name = "tbEndPoint";
            this.tbEndPoint.Size = new System.Drawing.Size(332, 14);
            this.tbEndPoint.TabIndex = 0;
            this.tbEndPoint.Text = "ws://127.0.0.1:6800";
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnect.Location = new System.Drawing.Point(344, 4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(68, 24);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // gbxStats
            // 
            this.gbxStats.Controls.Add(this.tbActiveDownloads);
            this.gbxStats.Controls.Add(this.tbTotalDownloads);
            this.gbxStats.Controls.Add(this.tbStoppedDownloads);
            this.gbxStats.Controls.Add(this.tbDownloadsInQueue);
            this.gbxStats.Controls.Add(this.tbUploadSpeed);
            this.gbxStats.Controls.Add(this.tbDownloadSpeed);
            this.gbxStats.Controls.Add(this.lbActiveDownloads);
            this.gbxStats.Controls.Add(this.lbTotalStoppedDownloads);
            this.gbxStats.Controls.Add(this.lbStoppedDownloads);
            this.gbxStats.Controls.Add(this.lbWaitingDownloads);
            this.gbxStats.Controls.Add(this.lbUploadSpeed);
            this.gbxStats.Controls.Add(this.lbDownloadSpeed);
            this.gbxStats.Location = new System.Drawing.Point(4, 32);
            this.gbxStats.Name = "gbxStats";
            this.gbxStats.Size = new System.Drawing.Size(412, 140);
            this.gbxStats.TabIndex = 2;
            this.gbxStats.TabStop = false;
            this.gbxStats.Text = "Aria Stats";
            // 
            // lbDownloadSpeed
            // 
            this.lbDownloadSpeed.Location = new System.Drawing.Point(8, 20);
            this.lbDownloadSpeed.MaximumSize = new System.Drawing.Size(9999, 13);
            this.lbDownloadSpeed.MinimumSize = new System.Drawing.Size(0, 13);
            this.lbDownloadSpeed.Name = "lbDownloadSpeed";
            this.lbDownloadSpeed.Size = new System.Drawing.Size(160, 13);
            this.lbDownloadSpeed.TabIndex = 0;
            this.lbDownloadSpeed.Tag = "";
            this.lbDownloadSpeed.Text = "Download Speed:";
            this.lbDownloadSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbUploadSpeed
            // 
            this.lbUploadSpeed.Location = new System.Drawing.Point(8, 40);
            this.lbUploadSpeed.MaximumSize = new System.Drawing.Size(9999, 13);
            this.lbUploadSpeed.MinimumSize = new System.Drawing.Size(1, 13);
            this.lbUploadSpeed.Name = "lbUploadSpeed";
            this.lbUploadSpeed.Size = new System.Drawing.Size(160, 13);
            this.lbUploadSpeed.TabIndex = 1;
            this.lbUploadSpeed.Tag = "";
            this.lbUploadSpeed.Text = "Upload Speed:";
            this.lbUploadSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbWaitingDownloads
            // 
            this.lbWaitingDownloads.Location = new System.Drawing.Point(8, 60);
            this.lbWaitingDownloads.MaximumSize = new System.Drawing.Size(9999, 13);
            this.lbWaitingDownloads.MinimumSize = new System.Drawing.Size(1, 13);
            this.lbWaitingDownloads.Name = "lbWaitingDownloads";
            this.lbWaitingDownloads.Size = new System.Drawing.Size(160, 13);
            this.lbWaitingDownloads.TabIndex = 1;
            this.lbWaitingDownloads.Tag = "";
            this.lbWaitingDownloads.Text = "Downloads In Queue:";
            this.lbWaitingDownloads.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbStoppedDownloads
            // 
            this.lbStoppedDownloads.Location = new System.Drawing.Point(8, 80);
            this.lbStoppedDownloads.MaximumSize = new System.Drawing.Size(9999, 13);
            this.lbStoppedDownloads.MinimumSize = new System.Drawing.Size(1, 13);
            this.lbStoppedDownloads.Name = "lbStoppedDownloads";
            this.lbStoppedDownloads.Size = new System.Drawing.Size(160, 13);
            this.lbStoppedDownloads.TabIndex = 1;
            this.lbStoppedDownloads.Tag = "";
            this.lbStoppedDownloads.Text = "Stopped Downloads:";
            this.lbStoppedDownloads.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbTotalStoppedDownloads
            // 
            this.lbTotalStoppedDownloads.Location = new System.Drawing.Point(8, 100);
            this.lbTotalStoppedDownloads.MaximumSize = new System.Drawing.Size(9999, 13);
            this.lbTotalStoppedDownloads.MinimumSize = new System.Drawing.Size(1, 13);
            this.lbTotalStoppedDownloads.Name = "lbTotalStoppedDownloads";
            this.lbTotalStoppedDownloads.Size = new System.Drawing.Size(160, 13);
            this.lbTotalStoppedDownloads.TabIndex = 1;
            this.lbTotalStoppedDownloads.Tag = "";
            this.lbTotalStoppedDownloads.Text = "Total Downloads:";
            this.lbTotalStoppedDownloads.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbActiveDownloads
            // 
            this.lbActiveDownloads.Location = new System.Drawing.Point(8, 120);
            this.lbActiveDownloads.MaximumSize = new System.Drawing.Size(9999, 13);
            this.lbActiveDownloads.MinimumSize = new System.Drawing.Size(1, 13);
            this.lbActiveDownloads.Name = "lbActiveDownloads";
            this.lbActiveDownloads.Size = new System.Drawing.Size(160, 13);
            this.lbActiveDownloads.TabIndex = 1;
            this.lbActiveDownloads.Tag = "";
            this.lbActiveDownloads.Text = "Active Downloads:";
            this.lbActiveDownloads.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbActiveDownloads
            // 
            this.tbActiveDownloads.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbActiveDownloads.BackColor = System.Drawing.SystemColors.Window;
            this.tbActiveDownloads.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbActiveDownloads.Location = new System.Drawing.Point(168, 120);
            this.tbActiveDownloads.Name = "tbActiveDownloads";
            this.tbActiveDownloads.ReadOnly = true;
            this.tbActiveDownloads.Size = new System.Drawing.Size(244, 14);
            this.tbActiveDownloads.TabIndex = 2;
            // 
            // tbTotalDownloads
            // 
            this.tbTotalDownloads.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTotalDownloads.BackColor = System.Drawing.SystemColors.Window;
            this.tbTotalDownloads.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTotalDownloads.Location = new System.Drawing.Point(168, 100);
            this.tbTotalDownloads.Name = "tbTotalDownloads";
            this.tbTotalDownloads.ReadOnly = true;
            this.tbTotalDownloads.Size = new System.Drawing.Size(244, 14);
            this.tbTotalDownloads.TabIndex = 2;
            // 
            // tbStoppedDownloads
            // 
            this.tbStoppedDownloads.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbStoppedDownloads.BackColor = System.Drawing.SystemColors.Window;
            this.tbStoppedDownloads.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbStoppedDownloads.Location = new System.Drawing.Point(168, 80);
            this.tbStoppedDownloads.Name = "tbStoppedDownloads";
            this.tbStoppedDownloads.ReadOnly = true;
            this.tbStoppedDownloads.Size = new System.Drawing.Size(244, 14);
            this.tbStoppedDownloads.TabIndex = 2;
            // 
            // tbDownloadsInQueue
            // 
            this.tbDownloadsInQueue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDownloadsInQueue.BackColor = System.Drawing.SystemColors.Window;
            this.tbDownloadsInQueue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDownloadsInQueue.Location = new System.Drawing.Point(168, 60);
            this.tbDownloadsInQueue.Name = "tbDownloadsInQueue";
            this.tbDownloadsInQueue.ReadOnly = true;
            this.tbDownloadsInQueue.Size = new System.Drawing.Size(244, 14);
            this.tbDownloadsInQueue.TabIndex = 2;
            // 
            // tbUploadSpeed
            // 
            this.tbUploadSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUploadSpeed.BackColor = System.Drawing.SystemColors.Window;
            this.tbUploadSpeed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUploadSpeed.Location = new System.Drawing.Point(168, 40);
            this.tbUploadSpeed.Name = "tbUploadSpeed";
            this.tbUploadSpeed.ReadOnly = true;
            this.tbUploadSpeed.Size = new System.Drawing.Size(244, 14);
            this.tbUploadSpeed.TabIndex = 2;
            // 
            // tbDownloadSpeed
            // 
            this.tbDownloadSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDownloadSpeed.BackColor = System.Drawing.SystemColors.Window;
            this.tbDownloadSpeed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDownloadSpeed.Location = new System.Drawing.Point(168, 20);
            this.tbDownloadSpeed.Name = "tbDownloadSpeed";
            this.tbDownloadSpeed.ReadOnly = true;
            this.tbDownloadSpeed.Size = new System.Drawing.Size(244, 14);
            this.tbDownloadSpeed.TabIndex = 2;
            // 
            // flpDownloads
            // 
            this.flpDownloads.AutoScroll = true;
            this.flpDownloads.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpDownloads.Location = new System.Drawing.Point(4, 172);
            this.flpDownloads.Name = "flpDownloads";
            this.flpDownloads.Size = new System.Drawing.Size(412, 256);
            this.flpDownloads.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(419, 431);
            this.Controls.Add(this.flpDownloads);
            this.Controls.Add(this.gbxStats);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.tbEndPoint);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aria.Test";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gbxStats.ResumeLayout(false);
            this.gbxStats.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.TextBox tbEndPoint;
		private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.GroupBox gbxStats;
        private System.Windows.Forms.Label lbActiveDownloads;
        private System.Windows.Forms.Label lbTotalStoppedDownloads;
        private System.Windows.Forms.Label lbStoppedDownloads;
        private System.Windows.Forms.Label lbWaitingDownloads;
        private System.Windows.Forms.Label lbUploadSpeed;
        private System.Windows.Forms.Label lbDownloadSpeed;
        private System.Windows.Forms.CopyableLabel tbDownloadSpeed;
        private System.Windows.Forms.CopyableLabel tbTotalDownloads;
        private System.Windows.Forms.CopyableLabel tbStoppedDownloads;
        private System.Windows.Forms.CopyableLabel tbDownloadsInQueue;
        private System.Windows.Forms.CopyableLabel tbUploadSpeed;
        private System.Windows.Forms.CopyableLabel tbActiveDownloads;
        private System.Windows.Forms.FlowLayoutPanel flpDownloads;
    }
}

