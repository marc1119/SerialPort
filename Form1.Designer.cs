/*
Author: Marc-Antoine Beaudoin
Date: 2015-04-09
Ville: Sherbrooke
Version: 1.00
Id: Form1.Designer.cs
*/

namespace SimpleSerial
{
    partial class PuriSerial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PuriSerial));
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
            this.tab1Min = new System.Windows.Forms.TabPage();
            this.list1Min = new System.Windows.Forms.ListView();
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tab10Min = new System.Windows.Forms.TabPage();
            this.list10Min = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tab1Hr = new System.Windows.Forms.TabPage();
            this.list1Heure = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabTempsReel = new System.Windows.Forms.TabPage();
            this.listTempsReel = new System.Windows.Forms.ListView();
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader24 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabTest = new System.Windows.Forms.TabPage();
            this.textBoxTempsReel = new System.Windows.Forms.TextBox();
            this.timer1Min = new System.Windows.Forms.Timer(this.components);
            this.timer10Min = new System.Windows.Forms.Timer(this.components);
            this.timer1Hr = new System.Windows.Forms.Timer(this.components);
            this.baudRate = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tab1Min.SuspendLayout();
            this.tab10Min.SuspendLayout();
            this.tab1Hr.SuspendLayout();
            this.tabTempsReel.SuspendLayout();
            this.tabTest.SuspendLayout();
            this.SuspendLayout();
            // 
            // boutonDemarrer
            // 
            resources.ApplyResources(this.boutonDemarrer, "boutonDemarrer");
            this.boutonDemarrer.Name = "boutonDemarrer";
            this.boutonDemarrer.UseVisualStyleBackColor = true;
            this.boutonDemarrer.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // boutonArret
            // 
            resources.ApplyResources(this.boutonArret, "boutonArret");
            this.boutonArret.Name = "boutonArret";
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
            resources.ApplyResources(this.progressBar1, "progressBar1");
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // temperature2
            // 
            resources.ApplyResources(this.temperature2, "temperature2");
            this.temperature2.Name = "temperature2";
            this.temperature2.TextChanged += new System.EventHandler(this.temperature2_TextChanged);
            // 
            // temperature1
            // 
            resources.ApplyResources(this.temperature1, "temperature1");
            this.temperature1.Name = "temperature1";
            this.temperature1.TextChanged += new System.EventHandler(this.temperature1_TextChanged);
            // 
            // nbDonneesText
            // 
            resources.ApplyResources(this.nbDonneesText, "nbDonneesText");
            this.nbDonneesText.Name = "nbDonneesText";
            this.nbDonneesText.Click += new System.EventHandler(this.nbDonneesText_Click);
            // 
            // temp1
            // 
            resources.ApplyResources(this.temp1, "temp1");
            this.temp1.Name = "temp1";
            this.temp1.Click += new System.EventHandler(this.temp1_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            this.label4.Click += new System.EventHandler(this.nPort_Click);
            // 
            // Temp2
            // 
            resources.ApplyResources(this.Temp2, "Temp2");
            this.Temp2.Name = "Temp2";
            this.Temp2.Click += new System.EventHandler(this.temp2_Click);
            // 
            // choixBaurate
            // 
            resources.ApplyResources(this.choixBaurate, "choixBaurate");
            this.choixBaurate.FormattingEnabled = true;
            this.choixBaurate.Items.AddRange(new object[] {
            resources.GetString("choixBaurate.Items"),
            resources.GetString("choixBaurate.Items1"),
            resources.GetString("choixBaurate.Items2"),
            resources.GetString("choixBaurate.Items3"),
            resources.GetString("choixBaurate.Items4"),
            resources.GetString("choixBaurate.Items5"),
            resources.GetString("choixBaurate.Items6"),
            resources.GetString("choixBaurate.Items7"),
            resources.GetString("choixBaurate.Items8"),
            resources.GetString("choixBaurate.Items9"),
            resources.GetString("choixBaurate.Items10"),
            resources.GetString("choixBaurate.Items11"),
            resources.GetString("choixBaurate.Items12"),
            resources.GetString("choixBaurate.Items13"),
            resources.GetString("choixBaurate.Items14")});
            this.choixBaurate.Name = "choixBaurate";
            this.choixBaurate.SelectedIndexChanged += new System.EventHandler(this.baurate_SelectedIndexChanged);
            // 
            // dataBits
            // 
            resources.ApplyResources(this.dataBits, "dataBits");
            this.dataBits.Name = "dataBits";
            this.dataBits.Click += new System.EventHandler(this.dataBits_Click);
            // 
            // choixDataBits
            // 
            resources.ApplyResources(this.choixDataBits, "choixDataBits");
            this.choixDataBits.FormattingEnabled = true;
            this.choixDataBits.Items.AddRange(new object[] {
            resources.GetString("choixDataBits.Items"),
            resources.GetString("choixDataBits.Items1"),
            resources.GetString("choixDataBits.Items2"),
            resources.GetString("choixDataBits.Items3")});
            this.choixDataBits.Name = "choixDataBits";
            this.choixDataBits.SelectedIndexChanged += new System.EventHandler(this.dataBits_SelectedIndexChanged);
            // 
            // boutonQuitter
            // 
            resources.ApplyResources(this.boutonQuitter, "boutonQuitter");
            this.boutonQuitter.Name = "boutonQuitter";
            this.boutonQuitter.UseVisualStyleBackColor = true;
            this.boutonQuitter.Click += new System.EventHandler(this.boutonQuitter_Click);
            // 
            // boutonEffacer
            // 
            resources.ApplyResources(this.boutonEffacer, "boutonEffacer");
            this.boutonEffacer.Name = "boutonEffacer";
            this.boutonEffacer.UseVisualStyleBackColor = true;
            this.boutonEffacer.Click += new System.EventHandler(this.effacer_Click);
            // 
            // timerProgressBar
            // 
            this.timerProgressBar.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // choixPort
            // 
            resources.ApplyResources(this.choixPort, "choixPort");
            this.choixPort.FormattingEnabled = true;
            this.choixPort.Name = "choixPort";
            this.choixPort.SelectedIndexChanged += new System.EventHandler(this.port_SelectedIndexChanged);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            this.label7.Click += new System.EventHandler(this.nbDonnees_Click);
            // 
            // tabControl1
            // 
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Controls.Add(this.tab1Min);
            this.tabControl1.Controls.Add(this.tab10Min);
            this.tabControl1.Controls.Add(this.tab1Hr);
            this.tabControl1.Controls.Add(this.tabTempsReel);
            this.tabControl1.Controls.Add(this.tabTest);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tab1Min
            // 
            resources.ApplyResources(this.tab1Min, "tab1Min");
            this.tab1Min.Controls.Add(this.list1Min);
            this.tab1Min.Name = "tab1Min";
            this.tab1Min.UseVisualStyleBackColor = true;
            // 
            // list1Min
            // 
            resources.ApplyResources(this.list1Min, "list1Min");
            this.list1Min.BackColor = System.Drawing.SystemColors.Window;
            this.list1Min.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18});
            this.list1Min.Name = "list1Min";
            this.list1Min.UseCompatibleStateImageBehavior = false;
            this.list1Min.View = System.Windows.Forms.View.Details;
            this.list1Min.SelectedIndexChanged += new System.EventHandler(this.list1Min_SelectedIndexChanged);
            // 
            // columnHeader13
            // 
            resources.ApplyResources(this.columnHeader13, "columnHeader13");
            // 
            // columnHeader14
            // 
            resources.ApplyResources(this.columnHeader14, "columnHeader14");
            // 
            // columnHeader15
            // 
            resources.ApplyResources(this.columnHeader15, "columnHeader15");
            // 
            // columnHeader16
            // 
            resources.ApplyResources(this.columnHeader16, "columnHeader16");
            // 
            // columnHeader17
            // 
            resources.ApplyResources(this.columnHeader17, "columnHeader17");
            // 
            // columnHeader18
            // 
            resources.ApplyResources(this.columnHeader18, "columnHeader18");
            // 
            // tab10Min
            // 
            resources.ApplyResources(this.tab10Min, "tab10Min");
            this.tab10Min.Controls.Add(this.list10Min);
            this.tab10Min.Name = "tab10Min";
            this.tab10Min.UseVisualStyleBackColor = true;
            // 
            // list10Min
            // 
            resources.ApplyResources(this.list10Min, "list10Min");
            this.list10Min.BackColor = System.Drawing.SystemColors.Window;
            this.list10Min.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.list10Min.Name = "list10Min";
            this.list10Min.UseCompatibleStateImageBehavior = false;
            this.list10Min.View = System.Windows.Forms.View.Details;
            this.list10Min.SelectedIndexChanged += new System.EventHandler(this.list10Min_SelectedIndexChanged);
            // 
            // columnHeader7
            // 
            resources.ApplyResources(this.columnHeader7, "columnHeader7");
            // 
            // columnHeader8
            // 
            resources.ApplyResources(this.columnHeader8, "columnHeader8");
            // 
            // columnHeader9
            // 
            resources.ApplyResources(this.columnHeader9, "columnHeader9");
            // 
            // columnHeader10
            // 
            resources.ApplyResources(this.columnHeader10, "columnHeader10");
            // 
            // columnHeader11
            // 
            resources.ApplyResources(this.columnHeader11, "columnHeader11");
            // 
            // columnHeader12
            // 
            resources.ApplyResources(this.columnHeader12, "columnHeader12");
            // 
            // tab1Hr
            // 
            resources.ApplyResources(this.tab1Hr, "tab1Hr");
            this.tab1Hr.Controls.Add(this.list1Heure);
            this.tab1Hr.Name = "tab1Hr";
            this.tab1Hr.UseVisualStyleBackColor = true;
            // 
            // list1Heure
            // 
            resources.ApplyResources(this.list1Heure, "list1Heure");
            this.list1Heure.BackColor = System.Drawing.SystemColors.Window;
            this.list1Heure.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.list1Heure.Name = "list1Heure";
            this.list1Heure.UseCompatibleStateImageBehavior = false;
            this.list1Heure.View = System.Windows.Forms.View.Details;
            this.list1Heure.SelectedIndexChanged += new System.EventHandler(this.list1Heure_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // columnHeader2
            // 
            resources.ApplyResources(this.columnHeader2, "columnHeader2");
            // 
            // columnHeader3
            // 
            resources.ApplyResources(this.columnHeader3, "columnHeader3");
            // 
            // columnHeader4
            // 
            resources.ApplyResources(this.columnHeader4, "columnHeader4");
            // 
            // columnHeader5
            // 
            resources.ApplyResources(this.columnHeader5, "columnHeader5");
            // 
            // columnHeader6
            // 
            resources.ApplyResources(this.columnHeader6, "columnHeader6");
            // 
            // tabTempsReel
            // 
            resources.ApplyResources(this.tabTempsReel, "tabTempsReel");
            this.tabTempsReel.Controls.Add(this.listTempsReel);
            this.tabTempsReel.Name = "tabTempsReel";
            this.tabTempsReel.UseVisualStyleBackColor = true;
            // 
            // listTempsReel
            // 
            resources.ApplyResources(this.listTempsReel, "listTempsReel");
            this.listTempsReel.BackColor = System.Drawing.SystemColors.Window;
            this.listTempsReel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader19,
            this.columnHeader20,
            this.columnHeader21,
            this.columnHeader22,
            this.columnHeader23,
            this.columnHeader24});
            this.listTempsReel.Name = "listTempsReel";
            this.listTempsReel.UseCompatibleStateImageBehavior = false;
            this.listTempsReel.View = System.Windows.Forms.View.Details;
            this.listTempsReel.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged_1);
            // 
            // columnHeader19
            // 
            resources.ApplyResources(this.columnHeader19, "columnHeader19");
            // 
            // columnHeader20
            // 
            resources.ApplyResources(this.columnHeader20, "columnHeader20");
            // 
            // columnHeader21
            // 
            resources.ApplyResources(this.columnHeader21, "columnHeader21");
            // 
            // columnHeader22
            // 
            resources.ApplyResources(this.columnHeader22, "columnHeader22");
            // 
            // columnHeader23
            // 
            resources.ApplyResources(this.columnHeader23, "columnHeader23");
            // 
            // columnHeader24
            // 
            resources.ApplyResources(this.columnHeader24, "columnHeader24");
            // 
            // tabTest
            // 
            resources.ApplyResources(this.tabTest, "tabTest");
            this.tabTest.Controls.Add(this.textBoxTempsReel);
            this.tabTest.Name = "tabTest";
            this.tabTest.UseVisualStyleBackColor = true;
            // 
            // textBoxTempsReel
            // 
            resources.ApplyResources(this.textBoxTempsReel, "textBoxTempsReel");
            this.textBoxTempsReel.Name = "textBoxTempsReel";
            this.textBoxTempsReel.ReadOnly = true;
            this.textBoxTempsReel.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
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
            resources.ApplyResources(this.baudRate, "baudRate");
            this.baudRate.Name = "baudRate";
            this.baudRate.Click += new System.EventHandler(this.baudRate_Click);
            // 
            // PuriSerial
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PuriSerial";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tab1Min.ResumeLayout(false);
            this.tab10Min.ResumeLayout(false);
            this.tab1Hr.ResumeLayout(false);
            this.tabTempsReel.ResumeLayout(false);
            this.tabTest.ResumeLayout(false);
            this.tabTest.PerformLayout();
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
        private System.Windows.Forms.TabPage tab1Min;
        private System.Windows.Forms.TabPage tab10Min;
        private System.Windows.Forms.TabPage tab1Hr;
        private System.Windows.Forms.Timer timer1Min;
        private System.Windows.Forms.Timer timer10Min;
        private System.Windows.Forms.Timer timer1Hr;
        private System.Windows.Forms.TextBox textBoxTempsReel;
        private System.Windows.Forms.Label baudRate;
        private System.Windows.Forms.ListView list1Min;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ListView list10Min;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ListView list1Heure;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TabPage tabTempsReel;
        private System.Windows.Forms.ListView listTempsReel;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private System.Windows.Forms.ColumnHeader columnHeader23;
        private System.Windows.Forms.ColumnHeader columnHeader24;
        private System.Windows.Forms.TabPage tabTest;
    }
}

