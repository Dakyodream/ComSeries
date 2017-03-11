namespace ComSeries {
    partial class Form1 {
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.tabControlAll = new System.Windows.Forms.TabControl();
			this.tableParam = new System.Windows.Forms.TabPage();
			this.gbStartCo = new System.Windows.Forms.GroupBox();
			this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
			this.pbModif = new System.Windows.Forms.Button();
			this.pbStart = new System.Windows.Forms.Button();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.cbRead = new System.Windows.Forms.CheckBox();
			this.cbWrite = new System.Windows.Forms.CheckBox();
			this.gbConfigPort = new System.Windows.Forms.GroupBox();
			this.lPortCom = new System.Windows.Forms.Label();
			this.lStop = new System.Windows.Forms.Label();
			this.cbBitStop = new System.Windows.Forms.ComboBox();
			this.lData = new System.Windows.Forms.Label();
			this.lBaudeRate = new System.Windows.Forms.Label();
			this.lParity = new System.Windows.Forms.Label();
			this.ListOfPorts = new System.Windows.Forms.ComboBox();
			this.cbVitesse = new System.Windows.Forms.ComboBox();
			this.cbNbBit = new System.Windows.Forms.ComboBox();
			this.cbParite = new System.Windows.Forms.ComboBox();
			this.pbAnalysPorts = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.préférencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mettreAuPremierPlanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aProposDeComSeriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tabControlAll.SuspendLayout();
			this.tableParam.SuspendLayout();
			this.gbStartCo.SuspendLayout();
			this.flowLayoutPanel3.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.gbConfigPort.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControlAll
			// 
			this.tabControlAll.Controls.Add(this.tableParam);
			resources.ApplyResources(this.tabControlAll, "tabControlAll");
			this.tabControlAll.Multiline = true;
			this.tabControlAll.Name = "tabControlAll";
			this.tabControlAll.SelectedIndex = 0;
			// 
			// tableParam
			// 
			this.tableParam.Controls.Add(this.gbStartCo);
			this.tableParam.Controls.Add(this.gbConfigPort);
			this.tableParam.Controls.Add(this.pbAnalysPorts);
			resources.ApplyResources(this.tableParam, "tableParam");
			this.tableParam.Name = "tableParam";
			this.tableParam.UseVisualStyleBackColor = true;
			// 
			// gbStartCo
			// 
			resources.ApplyResources(this.gbStartCo, "gbStartCo");
			this.gbStartCo.Controls.Add(this.flowLayoutPanel3);
			this.gbStartCo.Controls.Add(this.flowLayoutPanel1);
			this.gbStartCo.Name = "gbStartCo";
			this.gbStartCo.TabStop = false;
			// 
			// flowLayoutPanel3
			// 
			resources.ApplyResources(this.flowLayoutPanel3, "flowLayoutPanel3");
			this.flowLayoutPanel3.Controls.Add(this.pbModif);
			this.flowLayoutPanel3.Controls.Add(this.pbStart);
			this.flowLayoutPanel3.Name = "flowLayoutPanel3";
			// 
			// pbModif
			// 
			resources.ApplyResources(this.pbModif, "pbModif");
			this.pbModif.Name = "pbModif";
			this.pbModif.UseVisualStyleBackColor = true;
			this.pbModif.Click += new System.EventHandler(this.pbModif_Click);
			// 
			// pbStart
			// 
			resources.ApplyResources(this.pbStart, "pbStart");
			this.pbStart.Name = "pbStart";
			this.pbStart.UseVisualStyleBackColor = true;
			this.pbStart.Click += new System.EventHandler(this.pbStart_Click);
			// 
			// flowLayoutPanel1
			// 
			resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
			this.flowLayoutPanel1.Controls.Add(this.cbRead);
			this.flowLayoutPanel1.Controls.Add(this.cbWrite);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			// 
			// cbRead
			// 
			resources.ApplyResources(this.cbRead, "cbRead");
			this.cbRead.Checked = true;
			this.cbRead.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbRead.Name = "cbRead";
			this.cbRead.UseVisualStyleBackColor = true;
			// 
			// cbWrite
			// 
			resources.ApplyResources(this.cbWrite, "cbWrite");
			this.cbWrite.Checked = true;
			this.cbWrite.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbWrite.Name = "cbWrite";
			this.cbWrite.UseVisualStyleBackColor = true;
			// 
			// gbConfigPort
			// 
			resources.ApplyResources(this.gbConfigPort, "gbConfigPort");
			this.gbConfigPort.Controls.Add(this.lPortCom);
			this.gbConfigPort.Controls.Add(this.lStop);
			this.gbConfigPort.Controls.Add(this.cbBitStop);
			this.gbConfigPort.Controls.Add(this.lData);
			this.gbConfigPort.Controls.Add(this.lBaudeRate);
			this.gbConfigPort.Controls.Add(this.lParity);
			this.gbConfigPort.Controls.Add(this.ListOfPorts);
			this.gbConfigPort.Controls.Add(this.cbVitesse);
			this.gbConfigPort.Controls.Add(this.cbNbBit);
			this.gbConfigPort.Controls.Add(this.cbParite);
			this.gbConfigPort.Name = "gbConfigPort";
			this.gbConfigPort.TabStop = false;
			// 
			// lPortCom
			// 
			resources.ApplyResources(this.lPortCom, "lPortCom");
			this.lPortCom.Name = "lPortCom";
			// 
			// lStop
			// 
			resources.ApplyResources(this.lStop, "lStop");
			this.lStop.Name = "lStop";
			// 
			// cbBitStop
			// 
			this.cbBitStop.FormattingEnabled = true;
			resources.ApplyResources(this.cbBitStop, "cbBitStop");
			this.cbBitStop.Name = "cbBitStop";
			// 
			// lData
			// 
			resources.ApplyResources(this.lData, "lData");
			this.lData.Name = "lData";
			// 
			// lBaudeRate
			// 
			resources.ApplyResources(this.lBaudeRate, "lBaudeRate");
			this.lBaudeRate.Name = "lBaudeRate";
			// 
			// lParity
			// 
			resources.ApplyResources(this.lParity, "lParity");
			this.lParity.Name = "lParity";
			// 
			// ListOfPorts
			// 
			this.ListOfPorts.FormattingEnabled = true;
			resources.ApplyResources(this.ListOfPorts, "ListOfPorts");
			this.ListOfPorts.Name = "ListOfPorts";
			// 
			// cbVitesse
			// 
			this.cbVitesse.FormattingEnabled = true;
			resources.ApplyResources(this.cbVitesse, "cbVitesse");
			this.cbVitesse.Name = "cbVitesse";
			// 
			// cbNbBit
			// 
			this.cbNbBit.FormattingEnabled = true;
			resources.ApplyResources(this.cbNbBit, "cbNbBit");
			this.cbNbBit.Name = "cbNbBit";
			// 
			// cbParite
			// 
			this.cbParite.FormattingEnabled = true;
			resources.ApplyResources(this.cbParite, "cbParite");
			this.cbParite.Name = "cbParite";
			// 
			// pbAnalysPorts
			// 
			resources.ApplyResources(this.pbAnalysPorts, "pbAnalysPorts");
			this.pbAnalysPorts.Name = "pbAnalysPorts";
			this.pbAnalysPorts.UseVisualStyleBackColor = true;
			this.pbAnalysPorts.Click += new System.EventHandler(this.bpAnalysPorts_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.préférencesToolStripMenuItem,
            this.aideToolStripMenuItem});
			resources.ApplyResources(this.menuStrip1, "menuStrip1");
			this.menuStrip1.Name = "menuStrip1";
			// 
			// préférencesToolStripMenuItem
			// 
			this.préférencesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mettreAuPremierPlanToolStripMenuItem});
			this.préférencesToolStripMenuItem.Name = "préférencesToolStripMenuItem";
			resources.ApplyResources(this.préférencesToolStripMenuItem, "préférencesToolStripMenuItem");
			// 
			// mettreAuPremierPlanToolStripMenuItem
			// 
			this.mettreAuPremierPlanToolStripMenuItem.Name = "mettreAuPremierPlanToolStripMenuItem";
			resources.ApplyResources(this.mettreAuPremierPlanToolStripMenuItem, "mettreAuPremierPlanToolStripMenuItem");
			this.mettreAuPremierPlanToolStripMenuItem.Click += new System.EventHandler(this.mettreAuPremierPlanToolStripMenuItem_Click);
			// 
			// aideToolStripMenuItem
			// 
			this.aideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aProposDeComSeriesToolStripMenuItem});
			this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
			resources.ApplyResources(this.aideToolStripMenuItem, "aideToolStripMenuItem");
			// 
			// aProposDeComSeriesToolStripMenuItem
			// 
			this.aProposDeComSeriesToolStripMenuItem.Name = "aProposDeComSeriesToolStripMenuItem";
			resources.ApplyResources(this.aProposDeComSeriesToolStripMenuItem, "aProposDeComSeriesToolStripMenuItem");
			this.aProposDeComSeriesToolStripMenuItem.Click += new System.EventHandler(this.aProposDeComSeriesToolStripMenuItem_Click);
			// 
			// Form1
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tabControlAll);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.tabControlAll.ResumeLayout(false);
			this.tableParam.ResumeLayout(false);
			this.tableParam.PerformLayout();
			this.gbStartCo.ResumeLayout(false);
			this.gbStartCo.PerformLayout();
			this.flowLayoutPanel3.ResumeLayout(false);
			this.flowLayoutPanel3.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.gbConfigPort.ResumeLayout(false);
			this.gbConfigPort.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlAll;
        private System.Windows.Forms.TabPage tableParam;
        private System.Windows.Forms.Button pbAnalysPorts;
        private System.Windows.Forms.GroupBox gbConfigPort;
        private System.Windows.Forms.Label lPortCom;
        private System.Windows.Forms.Label lStop;
        private System.Windows.Forms.ComboBox cbBitStop;
        private System.Windows.Forms.Label lData;
        private System.Windows.Forms.Label lBaudeRate;
        private System.Windows.Forms.Label lParity;
        private System.Windows.Forms.ComboBox ListOfPorts;
        private System.Windows.Forms.ComboBox cbVitesse;
        private System.Windows.Forms.ComboBox cbNbBit;
        private System.Windows.Forms.ComboBox cbParite;
        private System.Windows.Forms.GroupBox gbStartCo;
        private System.Windows.Forms.CheckBox cbRead;
        private System.Windows.Forms.CheckBox cbWrite;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button pbModif;
        private System.Windows.Forms.Button pbStart;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem préférencesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mettreAuPremierPlanToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aProposDeComSeriesToolStripMenuItem;
	}
}

