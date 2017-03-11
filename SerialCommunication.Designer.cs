namespace ComSeries {
    partial class SerialCommunication {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent() {
			this.panel2 = new System.Windows.Forms.Panel();
			this.gbWrite = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.tbWrite = new System.Windows.Forms.TextBox();
			this.pbSend = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.cbError = new System.Windows.Forms.CheckBox();
			this.cbWarning = new System.Windows.Forms.CheckBox();
			this.cbInfo = new System.Windows.Forms.CheckBox();
			this.gbRead = new System.Windows.Forms.GroupBox();
			this.rtbRead = new System.Windows.Forms.RichTextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.cbWrite = new System.Windows.Forms.CheckBox();
			this.cbRead = new System.Windows.Forms.CheckBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.pbExport = new System.Windows.Forms.Button();
			this.pbStop = new System.Windows.Forms.Button();
			this.pbPause = new System.Windows.Forms.Button();
			this.pbStart = new System.Windows.Forms.Button();
			this.pbClearTerm = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.cbHorodatage = new System.Windows.Forms.CheckBox();
			this.gbWrite.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.gbRead.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.AutoSize = true;
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(475, 0);
			this.panel2.TabIndex = 12;
			// 
			// gbWrite
			// 
			this.gbWrite.AutoSize = true;
			this.gbWrite.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel1.SetColumnSpan(this.gbWrite, 2);
			this.gbWrite.Controls.Add(this.tableLayoutPanel2);
			this.gbWrite.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gbWrite.Enabled = false;
			this.gbWrite.Location = new System.Drawing.Point(3, 360);
			this.gbWrite.MaximumSize = new System.Drawing.Size(0, 53);
			this.gbWrite.MinimumSize = new System.Drawing.Size(0, 53);
			this.gbWrite.Name = "gbWrite";
			this.gbWrite.Size = new System.Drawing.Size(469, 53);
			this.gbWrite.TabIndex = 7;
			this.gbWrite.TabStop = false;
			this.gbWrite.Text = "Write";
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.AutoSize = true;
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.Controls.Add(this.tbWrite, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.pbSend, 1, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(463, 34);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// tbWrite
			// 
			this.tbWrite.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbWrite.Location = new System.Drawing.Point(3, 3);
			this.tbWrite.Name = "tbWrite";
			this.tbWrite.Size = new System.Drawing.Size(358, 20);
			this.tbWrite.TabIndex = 4;
			// 
			// pbSend
			// 
			this.pbSend.AutoSize = true;
			this.pbSend.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pbSend.Location = new System.Drawing.Point(367, 3);
			this.pbSend.MaximumSize = new System.Drawing.Size(93, 23);
			this.pbSend.MinimumSize = new System.Drawing.Size(93, 23);
			this.pbSend.Name = "pbSend";
			this.pbSend.Size = new System.Drawing.Size(93, 23);
			this.pbSend.TabIndex = 4;
			this.pbSend.Text = "Send";
			this.pbSend.UseVisualStyleBackColor = true;
			this.pbSend.Click += new System.EventHandler(this.pbSend_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.AutoSize = true;
			this.groupBox3.Controls.Add(this.cbHorodatage);
			this.groupBox3.Controls.Add(this.cbError);
			this.groupBox3.Controls.Add(this.cbWarning);
			this.groupBox3.Controls.Add(this.cbInfo);
			this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox3.Location = new System.Drawing.Point(322, 228);
			this.groupBox3.MinimumSize = new System.Drawing.Size(120, 102);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(150, 125);
			this.groupBox3.TabIndex = 10;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Options d\'affichage";
			// 
			// cbError
			// 
			this.cbError.AutoSize = true;
			this.cbError.Location = new System.Drawing.Point(7, 66);
			this.cbError.Name = "cbError";
			this.cbError.Size = new System.Drawing.Size(48, 17);
			this.cbError.TabIndex = 2;
			this.cbError.Text = "Error";
			this.cbError.UseVisualStyleBackColor = true;
			// 
			// cbWarning
			// 
			this.cbWarning.AutoSize = true;
			this.cbWarning.Location = new System.Drawing.Point(7, 43);
			this.cbWarning.Name = "cbWarning";
			this.cbWarning.Size = new System.Drawing.Size(66, 17);
			this.cbWarning.TabIndex = 1;
			this.cbWarning.Text = "Warning";
			this.cbWarning.UseVisualStyleBackColor = true;
			// 
			// cbInfo
			// 
			this.cbInfo.AutoSize = true;
			this.cbInfo.Location = new System.Drawing.Point(7, 20);
			this.cbInfo.Name = "cbInfo";
			this.cbInfo.Size = new System.Drawing.Size(44, 17);
			this.cbInfo.TabIndex = 0;
			this.cbInfo.Text = "Info";
			this.cbInfo.UseVisualStyleBackColor = true;
			// 
			// gbRead
			// 
			this.gbRead.Controls.Add(this.rtbRead);
			this.gbRead.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gbRead.Enabled = false;
			this.gbRead.Location = new System.Drawing.Point(3, 3);
			this.gbRead.Name = "gbRead";
			this.tableLayoutPanel1.SetRowSpan(this.gbRead, 4);
			this.gbRead.Size = new System.Drawing.Size(313, 351);
			this.gbRead.TabIndex = 6;
			this.gbRead.TabStop = false;
			this.gbRead.Text = "Read";
			// 
			// rtbRead
			// 
			this.rtbRead.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rtbRead.Location = new System.Drawing.Point(3, 16);
			this.rtbRead.Name = "rtbRead";
			this.rtbRead.ReadOnly = true;
			this.rtbRead.Size = new System.Drawing.Size(307, 332);
			this.rtbRead.TabIndex = 3;
			this.rtbRead.Text = "";
			// 
			// groupBox2
			// 
			this.groupBox2.AutoSize = true;
			this.groupBox2.Controls.Add(this.cbWrite);
			this.groupBox2.Controls.Add(this.cbRead);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox2.Location = new System.Drawing.Point(322, 143);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(150, 79);
			this.groupBox2.TabIndex = 9;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Options ";
			// 
			// cbWrite
			// 
			this.cbWrite.AutoSize = true;
			this.cbWrite.Location = new System.Drawing.Point(7, 43);
			this.cbWrite.Name = "cbWrite";
			this.cbWrite.Size = new System.Drawing.Size(51, 17);
			this.cbWrite.TabIndex = 1;
			this.cbWrite.Text = "Write";
			this.cbWrite.UseVisualStyleBackColor = true;
			this.cbWrite.CheckedChanged += new System.EventHandler(this.cbWrite_CheckedChanged);
			// 
			// cbRead
			// 
			this.cbRead.AutoSize = true;
			this.cbRead.Location = new System.Drawing.Point(7, 20);
			this.cbRead.Name = "cbRead";
			this.cbRead.Size = new System.Drawing.Size(52, 17);
			this.cbRead.TabIndex = 0;
			this.cbRead.Text = "Read";
			this.cbRead.UseVisualStyleBackColor = true;
			this.cbRead.CheckedChanged += new System.EventHandler(this.cbRead_CheckedChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.AutoSize = true;
			this.groupBox1.Controls.Add(this.pbExport);
			this.groupBox1.Controls.Add(this.pbStop);
			this.groupBox1.Controls.Add(this.pbPause);
			this.groupBox1.Controls.Add(this.pbStart);
			this.groupBox1.Controls.Add(this.pbClearTerm);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(322, 3);
			this.groupBox1.MinimumSize = new System.Drawing.Size(150, 134);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(150, 134);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Options de connexion";
			// 
			// pbExport
			// 
			this.pbExport.AutoSize = true;
			this.pbExport.Dock = System.Windows.Forms.DockStyle.Top;
			this.pbExport.Location = new System.Drawing.Point(3, 108);
			this.pbExport.Name = "pbExport";
			this.pbExport.Size = new System.Drawing.Size(144, 23);
			this.pbExport.TabIndex = 13;
			this.pbExport.Text = "Exporter la communication";
			this.pbExport.UseVisualStyleBackColor = true;
			this.pbExport.Click += new System.EventHandler(this.pbExport_Click);
			// 
			// pbStop
			// 
			this.pbStop.Dock = System.Windows.Forms.DockStyle.Top;
			this.pbStop.Enabled = false;
			this.pbStop.Location = new System.Drawing.Point(3, 85);
			this.pbStop.Name = "pbStop";
			this.pbStop.Size = new System.Drawing.Size(144, 23);
			this.pbStop.TabIndex = 3;
			this.pbStop.Text = "Stop";
			this.pbStop.UseVisualStyleBackColor = true;
			this.pbStop.Click += new System.EventHandler(this.bpStop_Click);
			// 
			// pbPause
			// 
			this.pbPause.Dock = System.Windows.Forms.DockStyle.Top;
			this.pbPause.Enabled = false;
			this.pbPause.Location = new System.Drawing.Point(3, 62);
			this.pbPause.Name = "pbPause";
			this.pbPause.Size = new System.Drawing.Size(144, 23);
			this.pbPause.TabIndex = 14;
			this.pbPause.Text = "Disable autoscroll";
			this.pbPause.UseVisualStyleBackColor = true;
			this.pbPause.Click += new System.EventHandler(this.pbPause_Click);
			// 
			// pbStart
			// 
			this.pbStart.Dock = System.Windows.Forms.DockStyle.Top;
			this.pbStart.Location = new System.Drawing.Point(3, 39);
			this.pbStart.Name = "pbStart";
			this.pbStart.Size = new System.Drawing.Size(144, 23);
			this.pbStart.TabIndex = 2;
			this.pbStart.Text = "Start";
			this.pbStart.UseVisualStyleBackColor = true;
			this.pbStart.Click += new System.EventHandler(this.bpStart_Click);
			// 
			// pbClearTerm
			// 
			this.pbClearTerm.AutoSize = true;
			this.pbClearTerm.Dock = System.Windows.Forms.DockStyle.Top;
			this.pbClearTerm.Location = new System.Drawing.Point(3, 16);
			this.pbClearTerm.Name = "pbClearTerm";
			this.pbClearTerm.Size = new System.Drawing.Size(144, 23);
			this.pbClearTerm.TabIndex = 13;
			this.pbClearTerm.Text = "Effacer le treminal";
			this.pbClearTerm.UseVisualStyleBackColor = true;
			this.pbClearTerm.Click += new System.EventHandler(this.pbClearTerm_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.gbRead, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.groupBox3, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.gbWrite, 0, 4);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(0, 392);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 5;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(475, 416);
			this.tableLayoutPanel1.TabIndex = 13;
			// 
			// cbHorodatage
			// 
			this.cbHorodatage.AutoSize = true;
			this.cbHorodatage.Location = new System.Drawing.Point(7, 89);
			this.cbHorodatage.Name = "cbHorodatage";
			this.cbHorodatage.Size = new System.Drawing.Size(82, 17);
			this.cbHorodatage.TabIndex = 2;
			this.cbHorodatage.Text = "Horodatage";
			this.cbHorodatage.UseVisualStyleBackColor = true;
			// 
			// SerialCommunication
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.panel2);
			this.MinimumSize = new System.Drawing.Size(400, 416);
			this.Name = "SerialCommunication";
			this.Size = new System.Drawing.Size(475, 416);
			this.gbWrite.ResumeLayout(false);
			this.gbWrite.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.gbRead.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.GroupBox gbWrite;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button pbExport;
		private System.Windows.Forms.Button pbStop;
		private System.Windows.Forms.Button pbPause;
		private System.Windows.Forms.Button pbStart;
		private System.Windows.Forms.Button pbClearTerm;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.CheckBox cbWrite;
		private System.Windows.Forms.CheckBox cbRead;
		private System.Windows.Forms.GroupBox gbRead;
		private System.Windows.Forms.RichTextBox rtbRead;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.CheckBox cbError;
		private System.Windows.Forms.CheckBox cbWarning;
		private System.Windows.Forms.CheckBox cbInfo;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.TextBox tbWrite;
		private System.Windows.Forms.Button pbSend;
		private System.Windows.Forms.CheckBox cbHorodatage;
	}
}
