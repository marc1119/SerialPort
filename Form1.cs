/*
Author: Marc-Antoine Beaudoin
Date: 2015-04-09
Ville: Sherbrooke
Version: 1.00
Id: Form1.cs
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Threading;
using System.Windows;

#region Gestion
namespace SimpleSerial
{
    public partial class PuriSerial : Form
    {
        // variable pour stocker les données
        string RxString;

        //path du fichier de sauvegarde
        string path = @"F:\test.txt";

        public PuriSerial()
        {
            InitializeComponent();

            //Pour obtenir les ports et les afficher
            string[] ports;
            ports = SerialPort.GetPortNames();
            choixPort.Items.AddRange(ports);
        }
        
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort.IsOpen) serialPort.Close();
        }

        private void DisplayText(object sender, EventArgs e)
        {
            //Pour stocker les data
            serialPort.Handshake = Handshake.None;
            serialPort.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived);        
        }


        void sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data = serialPort.ReadLine(); //Bug quand on arrête le programme
            StreamWriter MyStreamWriter = new StreamWriter(path, true);
            MyStreamWriter.WriteLine(data);
            MyStreamWriter.Flush();
            MyStreamWriter.Close();


        }
        
        private void serialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            RxString = serialPort.ReadExisting();
            this.Invoke(new EventHandler(DisplayText));
        }
        

        private void temperature1_TextChanged(object sender, EventArgs e)
        {
            //afficher la dernière température 1 lue
            temperature1.AppendText("");
        }

        private void temperature2_TextChanged(object sender, EventArgs e)
        {
            //afficher la dernière température 2 lue
           temperature2.AppendText("");
        }
#endregion

#region boutons
        //Les boutons
        //bouton démarrer
        private void buttonStart_Click(object sender, EventArgs e)
        {
            //Pour effacer le fichier de sauvegarde
            if (File.Exists(path))
            {
                File.Delete(path);
            }

            //Pour s'assurer que tout les cases sont remplies
            string testBaudRate = choixBaurate.Text.ToString();
            string testDataBits = choixDataBits.Text.ToString();
            string testPortName = choixPort.Text.ToString();
            if (String.IsNullOrEmpty(testPortName))
            {
                MessageBox.Show("Le port est vide", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else

                if (String.IsNullOrEmpty(testBaudRate))
                {
                    MessageBox.Show("Le Baud Rate est vide", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                    if (String.IsNullOrEmpty(testDataBits))
                    {
                        MessageBox.Show("Le Data Bits est vide", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
            serialPort.PortName = choixPort.Text.ToString();
            serialPort.BaudRate = Convert.ToInt32(choixBaurate.Text);
            serialPort.DataBits = Convert.ToInt16(choixDataBits.Text);
            serialPort.Open();
            timerProgressBar.Start();
            timer1Min.Start();
            timer10Min.Start();
            timer1Hr.Start();

            if (serialPort.IsOpen)
            {
                boutonDemarrer.Enabled = false;
                boutonArret.Enabled = true;
            }

            //Pour mettre les éléments dans la liste
            ListViewItem tempsReel = new ListViewItem("temps"); //temps
            tempsReel.SubItems.Add("température");              //temperature 1
            tempsReel.SubItems.Add("var");                      //variation
            tempsReel.SubItems.Add("t2");                       //temperature 2
            tempsReel.SubItems.Add("var");                      //variation
            tempsReel.SubItems.Add("Nbdata");                   //nombre de données
            listTempsReel.Items.Add(tempsReel);
        }
        
        //bouton arret
        private void buttonStop_Click(object sender, EventArgs e)
        {

            //pour arreter la barre de progression
            timerProgressBar.Stop();
            progressBar1.Value = 0;
            if (serialPort.IsOpen)
            {
                serialPort.Close();
                boutonDemarrer.Enabled = true;
                boutonArret.Enabled = false;
            }
        }

        //bouton effacer
        private void effacer_Click(object sender, EventArgs e)
        {
            list1Min.Items.Clear();
            list10Min.Items.Clear();
            list1Heure.Items.Clear();
            listTempsReel.Items.Clear();
        }

        //bouton quitter
        private void boutonQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
#endregion
        
#region progressBar
        //La barre de progression
        private void progressBar1_Click(object sender, EventArgs e)
        {
            this.timerProgressBar.Start();
        }
        #endregion

#region timers
        //Les timers
        private void timer_Tick(object sender, EventArgs e)
        {
         //Pour la barre de progression et le timer
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 120;
            progressBar1.Step = 3;
            progressBar1.PerformStep();
            if (progressBar1.Value == 120)
            {
                progressBar1.Value = 0;
                timerProgressBar.Stop();
                timerProgressBar.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Pour 1 minutes
            timer1Min.Stop();
            timer1Min.Start();
        }
        
        private void timer10Min_Tick(object sender, EventArgs e)
        {
            //Pour 10 minutes
            timer10Min.Stop();
            timer10Min.Start();
        }

        private void timer1Hr_Tick(object sender, EventArgs e)
        {
            //Pour 1 heure
            timer1Min.Stop();
            timer1Min.Start();
        }
#endregion

#region comboBox
        //Les comboBox
        private void port_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void baurate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataBits_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
#endregion

#region labels
        //Les labels
        private void nbDonneesText_Click(object sender, EventArgs e)
        {

        }

        private void nbDonnees_Click(object sender, EventArgs e)
        {

        }

        private void nPort_Click(object sender, EventArgs e)
        {

        }

        private void baudRate_Click(object sender, EventArgs e)
        {

        }

        private void dataBits_Click(object sender, EventArgs e)
        {

        }

        private void temp2_Click(object sender, EventArgs e)
        {

        }

        private void temp1_Click(object sender, EventArgs e)
        {

        }
#endregion

#region listes
        //Pour les listes pour l'affichage des données

        private void list1Min_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void list10Min_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void list1Heure_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listTempsReel_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
#endregion