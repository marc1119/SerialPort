/*
Author: Marc-Antoine Beaudoin
Date: 2015-04-09
Ville: Sherbrooke
Version: 1.00
Id: Form1.Designer.cs
*/

namespace SimpleSerial
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.boutonDemarrer = new System.Windows.Forms.Button();
            this.boutonArret = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.temperature2 = new System.Windows.Forms.TextBox();
            this.temperature1 = new System.Windows.Forms.TextBox();
            this.nbDonneesText = new System.Windows.Forms.Label();
            this.temp1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Temp2 = new System.Windows.Forms.Label();
            this.choixBaurate = new System.Windows.Forms.ComboBox();
            this.dataBits = new System.Windows.Forms.Label();
            this.choixDataBits = new System.Windows.Forms.ComboBox();
            this.boutonQuitter = new System.Windows.Forms.Button();
            this.boutonEffacer = new System.Windows.Forms.Button();
            this.timerProgressBar = new System.Windows.Forms.Timer(this.components);
            this.choixPort = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox1Min = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox10Min = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox1Hr = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.textBoxTempsReel = new System.Windows.Forms.TextBox();
            this.timer1Min = new System.Windows.Forms.Timer(this.components);
            this.timer10Min = new System.Windows.Forms.Timer(this.components);
            this.timer1Hr = new System.Windows.Forms.Timer(this.components);
            this.baudRate = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // boutonDemarrer
            // 
            this.boutonDemarrer.Location = new System.Drawing.Point(485, 42);
            this.boutonDemarrer.Name = "boutonDemarrer";
            this.boutonDemarrer.Size = new System.Drawing.Size(77, 31);
            this.boutonDemarrer.TabIndex = 0;
            this.boutonDemarrer.Text = "Démarrer";
            this.boutonDemarrer.UseVisualStyleBackColor = true;
            this.boutonDemarrer.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // boutonArret
            // 
            this.boutonArret.Enabled = false;
            this.boutonArret.Location = new System.Drawing.Point(485, 97);
            this.boutonArret.Name = "boutonArret";
            this.boutonArret.Size = new System.Drawing.Size(77, 32);
            this.boutonArret.TabIndex = 1;
            this.boutonArret.Text = "Arrêt";
            this.boutonArret.UseVisualStyleBackColor = true;
            this.boutonArret.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(38, 127);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(259, 13);
            this.progressBar1.TabIndex = 60;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // temperature2
            // 
            this.temperature2.Location = new System.Drawing.Point(136, 95);
            this.temperature2.Name = "temperature2";
            this.temperature2.Size = new System.Drawing.Size(92, 20);
            this.temperature2.TabIndex = 59;
            this.temperature2.TextChanged += new System.EventHandler(this.temperature2_TextChanged);
            // 
            // temperature1
            // 
            this.temperature1.Location = new System.Drawing.Point(38, 95);
            this.temperature1.Name = "temperature1";
            this.temperature1.Size = new System.Drawing.Size(92, 20);
            this.temperature1.TabIndex = 58;
            this.temperature1.TextChanged += new System.EventHandler(this.temperature1_TextChanged);
            // 
            // nbDonneesText
            // 
            this.nbDonneesText.AutoSize = true;
            this.nbDonneesText.Location = new System.Drawing.Point(231, 97);
            this.nbDonneesText.Name = "nbDonneesText";
            this.nbDonneesText.Size = new System.Drawing.Size(70, 13);
            this.nbDonneesText.TabIndex = 56;
            this.nbDonneesText.Text = "Nb Données:";
            this.nbDonneesText.Click += new System.EventHandler(this.nbDonneesText_Click);
            // 
            // temp1
            // 
            this.temp1.AutoSize = true;
            this.temp1.Location = new System.Drawing.Point(46, 79);
            this.temp1.Name = "temp1";
            this.temp1.Size = new System.Drawing.Size(76, 13);
            this.temp1.TabIndex = 55;
            this.temp1.Text = "Température 1";
            this.temp1.Click += new System.EventHandler(this.temp1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "N° Port";
            this.label4.Click += new System.EventHandler(this.nPort_Click);
            // 
            // Temp2
            // 
            this.Temp2.AutoSize = true;
            this.Temp2.Location = new System.Drawing.Point(144, 79);
            this.Temp2.Name = "Temp2";
            this.Temp2.Size = new System.Drawing.Size(76, 13);
            this.Temp2.TabIndex = 53;
            this.Temp2.Text = "Température 2";
            this.Temp2.Click += new System.EventHandler(this.temp2_Click);
            // 
            // choixBaurate
            // 
            this.choixBaurate.FormattingEnabled = true;
            this.choixBaurate.Items.AddRange(new object[] {
            "100",
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "56000",
            "576000",
            "115200",
            "128000",
            "256000"});
            this.choixBaurate.Location = new System.Drawing.Point(136, 49);
            this.choixBaurate.Name = "choixBaurate";
            this.choixBaurate.Size = new System.Drawing.Size(72, 21);
            this.choixBaurate.TabIndex = 52;
            this.choixBaurate.SelectedIndexChanged += new System.EventHandler(this.baurate_SelectedIndexChanged);
            // 
            // dataBits
            // 
            this.dataBits.AutoSize = true;
            this.dataBits.Location = new System.Drawing.Point(235, 35);
            this.dataBits.Name = "dataBits";
            this.dataBits.Size = new System.Drawing.Size(50, 13);
            this.dataBits.TabIndex = 51;
            this.dataBits.Text = "Data Bits";
            this.dataBits.Click += new System.EventHandler(this.dataBits_Click);
            // 
            // choixDataBits
            // 
            this.choixDataBits.FormattingEnabled = true;
            this.choixDataBits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.choixDataBits.Location = new System.Drawing.Point(225, 49);
            this.choixDataBits.Name = "choixDataBits";
            this.choixDataBits.Size = new System.Drawing.Size(72, 21);
            this.choixDataBits.TabIndex = 49;
            this.choixDataBits.SelectedIndexChanged += new System.EventHandler(this.dataBits_SelectedIndexChanged);
            // 
            // boutonQuitter
            // 
            this.boutonQuitter.Location = new System.Drawing.Point(485, 373);
            this.boutonQuitter.Name = "boutonQuitter";
            this.boutonQuitter.Size = new System.Drawing.Size(77, 29);
            this.boutonQuitter.TabIndex = 62;
            this.boutonQuitter.Text = "Quitter";
            this.boutonQuitter.UseVisualStyleBackColor = true;
            this.boutonQuitter.Click += new System.EventHandler(this.boutonQuitter_Click);
            // 
            // boutonEffacer
            // 
            this.boutonEffacer.Location = new System.Drawing.Point(485, 323);
            this.boutonEffacer.Name = "boutonEffacer";
            this.boutonEffacer.Size = new System.Drawing.Size(77, 32);
            this.boutonEffacer.TabIndex = 61;
            this.boutonEffacer.Text = "Effacer";
            this.boutonEffacer.UseVisualStyleBackColor = true;
            this.boutonEffacer.Click += new System.EventHandler(this.effacer_Click);
            // 
            // timerProgressBar
            // 
            this.timerProgressBar.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // choixPort
            // 
            this.choixPort.FormattingEnabled = true;
            this.choixPort.Location = new System.Drawing.Point(49, 49);
            this.choixPort.Name = "choixPort";
            this.choixPort.Size = new System.Drawing.Size(72, 21);
            this.choixPort.TabIndex = 63;
            this.choixPort.SelectedIndexChanged += new System.EventHandler(this.port_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(305, 97);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 64;
            this.label7.Text = "nbDonnees";
            this.label7.Click += new System.EventHandler(this.nbDonnees_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(38, 164);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(404, 236);
            this.tabControl1.TabIndex = 65;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox1Min);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(396, 210);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "1min";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox1Min
            // 
            this.textBox1Min.Location = new System.Drawing.Point(0, 0);
            this.textBox1Min.Multiline = true;
            this.textBox1Min.Name = "textBox1Min";
            this.textBox1Min.ReadOnly = true;
            this.textBox1Min.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1Min.Size = new System.Drawing.Size(396, 210);
            this.textBox1Min.TabIndex = 2;
            this.textBox1Min.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1Min.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox10Min);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(396, 210);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "10min";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox10Min
            // 
            this.textBox10Min.Location = new System.Drawing.Point(0, 0);
            this.textBox10Min.Multiline = true;
            this.textBox10Min.Name = "textBox10Min";
            this.textBox10Min.ReadOnly = true;
            this.textBox10Min.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox10Min.Size = new System.Drawing.Size(396, 210);
            this.textBox10Min.TabIndex = 3;
            this.textBox10Min.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBox1Hr);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(396, 210);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "1hr";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBox1Hr
            // 
            this.textBox1Hr.Location = new System.Drawing.Point(-1, 0);
            this.textBox1Hr.Multiline = true;
            this.textBox1Hr.Name = "textBox1Hr";
            this.textBox1Hr.ReadOnly = true;
            this.textBox1Hr.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1Hr.Size = new System.Drawing.Size(396, 210);
            this.textBox1Hr.TabIndex = 3;
            this.textBox1Hr.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.textBoxTempsReel);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(396, 210);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Temps réel";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // textBoxTempsReel
            // 
            this.textBoxTempsReel.Location = new System.Drawing.Point(2, 1);
            this.textBoxTempsReel.Multiline = true;
            this.textBoxTempsReel.Name = "textBoxTempsReel";
            this.textBoxTempsReel.ReadOnly = true;
            this.textBoxTempsReel.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxTempsReel.Size = new System.Drawing.Size(396, 210);
            this.textBoxTempsReel.TabIndex = 3;
            this.textBoxTempsReel.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // timer1Min
            // 
            this.timer1Min.Interval = 60000;
            this.timer1Min.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer10Min
            // 
            this.timer10Min.Interval = 10000;
            this.timer10Min.Tick += new System.EventHandler(this.timer10Min_Tick);
            // 
            // timer1Hr
            // 
            this.timer1Hr.Interval = 3600000;
            this.timer1Hr.Tick += new System.EventHandler(this.timer1Hr_Tick);
            // 
            // baudRate
            // 
            this.baudRate.AutoSize = true;
            this.baudRate.Location = new System.Drawing.Point(145, 36);
            this.baudRate.Name = "baudRate";
            this.baudRate.Size = new System.Drawing.Size(55, 13);
            this.baudRate.TabIndex = 66;
            this.baudRate.Text = "BaudRate";
            this.baudRate.Click += new System.EventHandler(this.baudRate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 440);
            this.Controls.Add(this.baudRate);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.choixPort);
            this.Controls.Add(this.boutonQuitter);
            this.Controls.Add(this.boutonEffacer);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.temperature2);
            this.Controls.Add(this.temperature1);
            this.Controls.Add(this.nbDonneesText);
            this.Controls.Add(this.temp1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Temp2);
            this.Controls.Add(this.choixBaurate);
            this.Controls.Add(this.dataBits);
            this.Controls.Add(this.choixDataBits);
            this.Controls.Add(this.boutonArret);
            this.Controls.Add(this.boutonDemarrer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button boutonDemarrer;
        private System.Windows.Forms.Button boutonArret;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox temperature2;
        private System.Windows.Forms.TextBox temperature1;
        private System.Windows.Forms.Label nbDonneesText;
        private System.Windows.Forms.Label temp1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Temp2;
        private System.Windows.Forms.ComboBox choixBaurate;
        private System.Windows.Forms.Label dataBits;
        private System.Windows.Forms.ComboBox choixDataBits;
        private System.Windows.Forms.Button boutonQuitter;
        private System.Windows.Forms.Button boutonEffacer;
        private System.Windows.Forms.Timer timerProgressBar;
        private System.Windows.Forms.ComboBox choixPort;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Timer timer1Min;
        private System.Windows.Forms.Timer timer10Min;
        private System.Windows.Forms.Timer timer1Hr;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox textBox1Min;
        private System.Windows.Forms.TextBox textBox10Min;
        private System.Windows.Forms.TextBox textBox1Hr;
        private System.Windows.Forms.TextBox textBoxTempsReel;
        private System.Windows.Forms.Label baudRate;
    }
}

