using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Diagnostics;
using System.IO;

namespace ComSeries {
	public partial class SerialCommunication : UserControl {
		delegate void SetTextCallback(string text);
		private SerialPort mMyPort;

		public delegate void SerialPortChangeStateHandler(object sender, SerialPort e);
		public event SerialPortChangeStateHandler SerialPortChangeState;

		private bool bEnableAutoScroll = true;

		private string sNameOfPort;
		private int iNbBit;
		private int iVitesse;
		private Parity pBitParite;
		private StopBits sbStopBit;


		public bool EnableRead {
			get {
				return this.cbRead.Checked;
			}
			set {
				this.cbRead.Checked = value;
			}
		}

		public bool EnableWrite {
			get {
				return this.cbWrite.Checked;
			}
			set {
				this.cbWrite.Checked = value;
			}
		}

		public SerialCommunication(string sNameOfPort, int iNbBit, int iVitesse, Parity pBitParite, StopBits sbStopBit) {
			InitializeComponent();

			this.sNameOfPort = sNameOfPort;
			this.iNbBit = iNbBit;
			this.iVitesse = iVitesse;
			this.pBitParite = pBitParite;
			this.sbStopBit = sbStopBit;

			this.cbError.Checked = true;
			this.cbInfo.Checked = true;
			this.cbRead.Checked = true;
			this.cbWarning.Checked = true;
			this.cbWrite.Checked = true;
		}

		private void MMyPort_PinChanged(object sender, SerialPinChangedEventArgs e) {
			if(this.mMyPort.IsOpen) {
				this.CloseConnection();
			}
			MessageBox.Show("L'évenement Pinchanged à été détécté : " + e.ToString(), "Port déconnecté", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void MMyPort_DataReceived(object sender, SerialDataReceivedEventArgs e) {
			this.readTxt(this.mMyPort.ReadExisting());
		}

		private void MMyPort_ErrorReceived(object sender, SerialErrorReceivedEventArgs e) {
			this.readTxt("[Reception error detected]\n");
		}

		private void MMyPort_Disposed(object sender, EventArgs e) {
			if(this.mMyPort != null) {
				if(this.mMyPort.IsOpen) {
					this.CloseConnection();
				}

			}
			MessageBox.Show("Le port à été supprimer (événement Disposed détécté) : \n" + e.ToString(), "Port déconnecté", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		public void CloseConnection() {
			if(this.mMyPort == null) {
				throw new Exception("Error when we call closePort methode :  this.mOpenPort == null");
			}
			else {
				if(this.mMyPort.IsOpen) {
					try {
						InformUserIfInfoWhenItIsNotVisible();
						this.mMyPort.DataReceived -= MMyPort_DataReceived;
						this.mMyPort.ErrorReceived -= MMyPort_ErrorReceived;
						this.mMyPort.PinChanged -= MMyPort_PinChanged;

						this.mMyPort.Close();
						if(SerialPortChangeState != null)
							SerialPortChangeState(this, this.mMyPort);

						this.mMyPort = null;
					}
					catch(Exception e) {
						throw new Exception("Error when we call closePort methode :  " + e.ToString());
					}

					this.pbStop.Enabled = false;
					this.pbStart.Enabled = true;
					this.groupBox2.Enabled = true;
					this.pbPause.Enabled = false;
				}
			}
			MessageBox.Show("Le port est dorénavant déconneté : \n", "Port déconnecté", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void readTxt(string sTextToWrite) {

			if(this.rtbRead.InvokeRequired) {
				SetTextCallback d = new SetTextCallback(readTxt);
				this.Invoke(d, new object[] { sTextToWrite });
			}
			else {
				if(this.rtbRead.TextLength + sTextToWrite.Length > (rtbRead.MaxLength * 0.99)) {
					saveData();
				}

				try {

					if(this.cbHorodatage.Checked) {
						sTextToWrite = DateTime.Now.ToString("hh:mm:ss.fffffff;") + sTextToWrite + "\n";
					}
					if(sTextToWrite.Contains("[INFO]") && this.cbInfo.Checked) {
						this.ColorRTB(this.rtbRead, sTextToWrite, Color.DarkBlue); //DarkBlue
					}
					else if(sTextToWrite.Contains("[WARNING]") && this.cbWarning.Checked) {
						this.ColorRTB(this.rtbRead, sTextToWrite, Color.DarkOrange);
					}
					else if(sTextToWrite.Contains("[ERROR]") && this.cbError.Checked) {
						this.ColorRTB(this.rtbRead, sTextToWrite, Color.DarkRed);
					}
					else {
						this.rtbRead.AppendText(sTextToWrite);
					}

					if(sTextToWrite.Contains('\n')) {
						this.rtbRead.SelectionColor = this.rtbRead.ForeColor;
					}


				}
				catch(Exception e) {
					MessageBox.Show("Error when we call Contains() methode :  " + e.ToString(), "Read data", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

				//<========================= manage autoscroll
				if(bEnableAutoScroll) {
					
					this.rtbRead.AutoScrollOffset = new Point(this.rtbRead.AutoScrollOffset.Y, this.rtbRead.AutoScrollOffset.X);
					this.rtbRead.ScrollToCaret();
				}
			}
		}

		private void ColorRTB(RichTextBox txtBox, string sText, Color cColor) {
			try {
				txtBox.SelectionStart = txtBox.TextLength;
			}
			catch(Exception e) {
				MessageBox.Show("Error when we call txtBox.SelectionStart :  " + e.ToString(), "Read data", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			txtBox.SelectionLength = 0;
			txtBox.SelectionColor = cColor;
			txtBox.AppendText(sText);
			//txtBox.SelectionColor = txtBox.ForeColor;
		}

		private void pbClearTerm_Click(object sender, EventArgs e) {
			this.rtbRead.Clear();
		}

		private void bpStart_Click(object sender, EventArgs e) {
			this.startConnection();
		}

		public void startConnection() {
			if(this.mMyPort == null) {

				try {
					this.mMyPort = new SerialPort(sNameOfPort, iVitesse, pBitParite, iNbBit, sbStopBit);
					this.mMyPort.DataReceived += MMyPort_DataReceived;
					this.mMyPort.Disposed += MMyPort_Disposed;
					this.mMyPort.ErrorReceived += MMyPort_ErrorReceived;
					this.mMyPort.PinChanged += MMyPort_PinChanged;

					this.mMyPort.Open();
					this.pbStop.Enabled = true;
					this.pbStart.Enabled = false;
					this.gbRead.Enabled = this.cbRead.Checked;
					this.gbWrite.Enabled = this.cbWrite.Checked;
					this.groupBox2.Enabled = false;
					this.pbPause.Enabled = true;

				}
				catch(Exception eSerialPortException) {
					MessageBox.Show("Erreur d'ouverture du port : " + eSerialPortException.ToString(), "Start connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
					throw new Exception("Erreur d'ouverture du port : " + eSerialPortException.ToString());
				}
			}
			else {
				MessageBox.Show("Erreur d'ouverture du port : le port est déja configurere", "Start connexion", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}


		private void bpStop_Click(object sender, EventArgs e) {
			if(this.mMyPort != null) {
				try {
					if(this.mMyPort.IsOpen) {
						CloseConnection();
					}
				}
				catch(Exception eSerialPortException) {
					MessageBox.Show("Erreur de fermeture du port : " + eSerialPortException.ToString(), "Stop connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
					throw new Exception("Erreur d'fermeture du port : " + eSerialPortException.ToString());
				}
			}
		}

		private void pbSend_Click(object sender, EventArgs e) {
			if(this.mMyPort != null) {
				try {
					if(this.mMyPort.IsOpen) {
						this.mMyPort.Write(this.tbWrite.Text + '\n');
					}
					else {
						MessageBox.Show("Le port de communication est inaccessible.", "Port déconnecté", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				catch(Exception eSerialPortException) {
					MessageBox.Show("Erreur lors de l'émission de données sur le port : " + eSerialPortException.ToString(), "Start connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
					throw new Exception("Erreur lors de l'émission de données sur le port : " + eSerialPortException.ToString());
				}
			}
		}

		private void pbExport_Click(object sender, EventArgs e) {
			RichTextBox rtbBoxToExport = new RichTextBox();
			DateTime ExportDate = DateTime.Now;

			SaveFileDialog saveFile = new SaveFileDialog();

			saveFile.DefaultExt = "*.csv";

			saveFile.FileName = "Export_" + ExportDate.ToString("yyyyMMdd_hhmmss") + ".csv";

			try {
				saveFile.Filter = "RTF Files|*.rtf|TEXT Texte|*.txt|CSV (séparateur: point-virgule)|*.csv";
				saveFile.Title = "Save file";
				if(!Directory.Exists(System.IO.Directory.GetCurrentDirectory() + "\\Backup")) {
					Directory.CreateDirectory(System.IO.Directory.GetCurrentDirectory() + "\\Backup");
				}
				saveFile.InitialDirectory = System.IO.Directory.GetCurrentDirectory() + "\\Backup";

				if(saveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
				   saveFile.FileName.Length > 0) {

					// Save the contents of the RichTextBox into the file.
					if(saveFile.FileName.EndsWith(".csv")) {
						rtbBoxToExport.AppendText("Auteur :; " + Application.ProductName.ToString() + ";\n");
						rtbBoxToExport.AppendText("Configuration du port : \n");
						rtbBoxToExport.AppendText("Nom : ;" + this.mMyPort.PortName + ";\n");
						rtbBoxToExport.AppendText("Vitesse : ;" + this.mMyPort.BaudRate + ";\n");
						rtbBoxToExport.AppendText("Bite de parité : ;" + this.mMyPort.Parity + ";\n");
						rtbBoxToExport.AppendText("Nombre de bits : ;" + this.mMyPort.DataBits + ";\n");
						rtbBoxToExport.AppendText("Bit de stop : ;" + this.mMyPort.StopBits + ";\n");
						rtbBoxToExport.AppendText("Data :; " + ExportDate.ToString("s") + ";\n");
						rtbBoxToExport.AppendText(this.rtbRead.Text);
						rtbBoxToExport.SaveFile(saveFile.FileName, RichTextBoxStreamType.UnicodePlainText);
					}
					else {
						rtbBoxToExport.AppendText("Auteur :; " + Application.ProductName.ToString() + ";\n");
						rtbBoxToExport.AppendText("Configuration du port : \n");
						rtbBoxToExport.AppendText("\t- Nom : " + this.mMyPort.PortName + " \n");
						rtbBoxToExport.AppendText("\t- Vitesse : " + this.mMyPort.BaudRate + " \n");
						rtbBoxToExport.AppendText("\t- Bite de parité : " + this.mMyPort.Parity + " \n");
						rtbBoxToExport.AppendText("\t- Nombre de bits : " + this.mMyPort.DataBits + " \n");
						rtbBoxToExport.AppendText("\t- Bit de stop : " + this.mMyPort.StopBits + " \n");
						rtbBoxToExport.AppendText("Data :; " + ExportDate.ToString("s") + ";\n");
						rtbBoxToExport.AppendText(this.rtbRead.Text);
						rtbBoxToExport.SaveFile(saveFile.FileName);
					}

				}
			}
			catch(Exception saveException) {
				MessageBox.Show("Une erreur à été rencontré lors de la sauvegarde du document : " + saveException.ToString(), "Sauvegarde des données", MessageBoxButtons.OK, MessageBoxIcon.Error);
				//throw new Exception("Une erreur à été rencontré lors de la sauvegarde du document : " + saveException.ToString());
			}
		}

		private void saveData() {
			RichTextBox rtbBoxToExport = new RichTextBox();
			DateTime ExportDate = DateTime.Now;

			SaveFileDialog saveFile = new SaveFileDialog();

			saveFile.DefaultExt = "*.csv";

			saveFile.FileName = "Export_" + ExportDate.ToString("yyyyMMdd_hhmmss") + ".csv";

			try {

				if(!Directory.Exists(System.IO.Directory.GetCurrentDirectory() + "\\Backup")) {
					Directory.CreateDirectory(System.IO.Directory.GetCurrentDirectory() + "\\Backup");
				}
				saveFile.InitialDirectory = System.IO.Directory.GetCurrentDirectory() + "\\Backup";

				rtbBoxToExport.AppendText("Auteur :; " + Application.ProductName.ToString() + ";\n");
				rtbBoxToExport.AppendText("Configuration du port : ;\n");
				rtbBoxToExport.AppendText("Nom : ;" + this.mMyPort.PortName + ";\n");
				rtbBoxToExport.AppendText("Vitesse : ;" + this.mMyPort.BaudRate + ";\n");
				rtbBoxToExport.AppendText("Bite de parité : ;" + this.mMyPort.Parity + ";\n");
				rtbBoxToExport.AppendText("Nombre de bits : ;" + this.mMyPort.DataBits + ";\n");
				rtbBoxToExport.AppendText("Bit de stop : ;" + this.mMyPort.StopBits + ";\n");
				rtbBoxToExport.AppendText("Data :; " + ExportDate.ToString("s") + ";\n");
				rtbBoxToExport.AppendText(this.rtbRead.Text);
				rtbBoxToExport.SaveFile(saveFile.FileName, RichTextBoxStreamType.UnicodePlainText);

				this.rtbRead.Clear();
				this.rtbRead.AppendText("Fragmented data, address of previously file :;" 
										+ saveFile.InitialDirectory.ToString() + "\\" + saveFile.FileName.ToString() + ";\n");
			}
			catch(Exception saveException) {
				MessageBox.Show("Une erreur à été rencontré lors de la sauvegarde du document : " + saveException.ToString(), "Sauvegarde des données", MessageBoxButtons.OK, MessageBoxIcon.Error);
				//throw new Exception("Une erreur à été rencontré lors de la sauvegarde du document : " + saveException.ToString());
			}
		}

		private void pbPause_Click(object sender, EventArgs e) {
			if(bEnableAutoScroll) {
				bEnableAutoScroll = false;
				this.pbPause.Text = "Enable autoscroll";
			}
			else {
				bEnableAutoScroll = true;
				this.pbPause.Text = "Disable autoscroll";
			}
		}

		private void InformUserIfInfoWhenItIsNotVisible() {
			System.Media.SystemSounds.Exclamation.Play();
		}

		private void cbRead_CheckedChanged(object sender, EventArgs e) {
			this.gbRead.Enabled = this.cbRead.Checked;
		}

		private void cbWrite_CheckedChanged(object sender, EventArgs e) {
			this.gbWrite.Enabled = this.cbWrite.Checked;
		}
	}
}
