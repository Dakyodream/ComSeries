using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Pipes;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComSeries {
    public partial class Form1 : Form {

        // This delegate enables asynchronous calls for setting
        // the text property on a TextBox control.
        delegate void SetTextCallback(string text);
        private List<String> mListPortCo;
        private int[] miValBaude = new int[] { 300, 600, 1200, 2400, 4800, 9600, 14400, 19200, 28800, 38400, 57600, 115200 };


        //pipe
        //private StreamReader mPipeServAReader; //No used


        public Form1() {
            string[] strBitStop = { StopBits.None.ToString(), StopBits.One.ToString(),
                                    StopBits.OnePointFive.ToString(), StopBits.Two.ToString() };
            string[] strNbBit = { "7", "8" };
            string[] strParite = { Parity.None.ToString(), Parity.Mark.ToString(), Parity.Even.ToString(),
                                     Parity.Odd.ToString(), Parity.Space.ToString() };

            InitializeComponent();
            //mMyPort = new SerialPort();

            string[] sValeur = new string[this.miValBaude.Length];

            for(int iCptBaude = 0; iCptBaude < this.miValBaude.Length; iCptBaude++) {
                sValeur[iCptBaude] = this.miValBaude[iCptBaude].ToString() + " baud";
            }

            this.cbVitesse.Items.AddRange(sValeur);
            this.cbVitesse.SelectedIndex = 5;

            this.cbBitStop.Items.AddRange(strBitStop);
            this.cbBitStop.SelectedIndex = 1;

            this.cbNbBit.Items.AddRange(strNbBit);
            this.cbNbBit.SelectedIndex = 1;

            this.cbParite.Items.AddRange(strParite);
            this.cbParite.SelectedIndex = 0;

            this.ListOfPorts.Text = "No ports";
            this.gbConfigPort.Enabled = false;
            this.gbStartCo.Enabled = false;

            mListPortCo = new List<String>();

        }

        private void bpAnalysPorts_Click(object sender, EventArgs e) {
			// Get a list of serial port names.

			string[] ports = SerialPort.GetPortNames();

			this.ListOfPorts.Items.Clear();
            this.ListOfPorts.Items.AddRange(ports);

            this.gbConfigPort.Enabled = false;
            this.gbStartCo.Enabled = false;

            if(ports.Length > 0) {
                this.ListOfPorts.SelectedIndex = 0;

                this.gbConfigPort.Enabled = true;
                this.gbStartCo.Enabled = true;
                
            }
            else if(ports.Length == 0) {
                this.ListOfPorts.Text = "No ports";
                MessageBox.Show("Pas de port détecté.", "Analyse des ports", MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            else {
                MessageBox.Show("Erreur lors de la détection des ports.", "Détections des ports", MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }
        
        

        private void bpParametre_Click(object sender, EventArgs e) {
            //this.tcControlPric.SelectedIndex = 0;
        }
        

        private void pbStart_Click(object sender, EventArgs e) {
			this.OpenNewSerialCommunication(true);
        }
        
        
        private void pbModif_Click(object sender, EventArgs e) {
			this.OpenNewSerialCommunication(false);            
        }

		private void OpenNewSerialCommunication(bool bStart) {
			TabPage tabPage;
			SerialCommunication myCom;
			int iIndex = 0;
			bool bAlreadyExisting = false;

			//on récupère les information
			string sNameOfPort = (string)this.ListOfPorts.SelectedItem;
			int iNbBit = Convert.ToInt32(this.cbNbBit.SelectedItem);
			int iVitesse = miValBaude[this.cbVitesse.SelectedIndex];
			StopBits sbStopBit = StopBits.None;
			switch(this.cbBitStop.SelectedIndex) {
				case 0:
					sbStopBit = StopBits.None;
					break;
				case 1:
					sbStopBit = StopBits.One;
					break;
				case 2:
					sbStopBit = StopBits.OnePointFive;
					break;
				case 3:
					sbStopBit = StopBits.Two;
					break;
			}
			Parity pBitParite = Parity.None;
			switch(this.cbParite.SelectedIndex) {
				case 0:
					pBitParite = Parity.None;
					break;
				case 1:
					pBitParite = Parity.Mark;
					break;
				case 2:
					pBitParite = Parity.Even;
					break;
				case 3:
					pBitParite = Parity.Odd;
					break;
				case 4:
					pBitParite = Parity.Space;
					break;
			}

			if(!mListPortCo.Contains(sNameOfPort)) {
				mListPortCo.Add(sNameOfPort);
				tabPage = new TabPage(sNameOfPort);
				myCom = new SerialCommunication(sNameOfPort, iNbBit, iVitesse, pBitParite, sbStopBit);
				myCom.AutoSize = true;
				myCom.Dock = System.Windows.Forms.DockStyle.Fill;


				tabPage.Controls.Add(myCom);
				tabPage.Name = "tab" + sNameOfPort;
				foreach(Control cControl in this.tabControlAll.Controls) {
					if(cControl.Name == tabPage.Name) {
						bAlreadyExisting = true;
						iIndex = this.tabControlAll.Controls.IndexOf(cControl);
					}
				}

				if(!bAlreadyExisting) {
					myCom.EnableRead = this.cbRead.Checked;
					myCom.EnableWrite = this.cbWrite.Checked;

					this.tabControlAll.Controls.Add(tabPage);
					this.tabControlAll.SelectedIndex = this.tabControlAll.Controls.IndexOf(tabPage);
					if(bStart) {
						myCom.startConnection();
					}
				}
				else {
					this.tabControlAll.SelectedIndex = iIndex;
				}
			}
			else {
				MessageBox.Show("Port déja connécté", "Configuration du port", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void mettreAuPremierPlanToolStripMenuItem_Click(object sender, EventArgs e) {
			this.mettreAuPremierPlanToolStripMenuItem.Checked = !this.mettreAuPremierPlanToolStripMenuItem.Checked;
			this.TopMost = this.mettreAuPremierPlanToolStripMenuItem.Checked;
		}

		private void aProposDeComSeriesToolStripMenuItem_Click(object sender, EventArgs e) {
			AboutBox1 myForm = new AboutBox1();
			myForm.ShowDialog();
			myForm.Dispose();
		}
	}
}
