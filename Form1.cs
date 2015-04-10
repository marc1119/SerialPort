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

namespace SimpleSerial
{
    public partial class Form1 : Form
    {
        // variable pour stocker les données
        string RxString;

        public Form1()
        {
            InitializeComponent();

            //Pour obtenir les ports et les afficher
            string[] ports;
            ports = SerialPort.GetPortNames();
            choixPort.Items.AddRange(ports);
        }
        
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen) serialPort1.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Si le port est fermé, ne pas essayer d'envoyer un caractère.
            if (!serialPort1.IsOpen) return;

            // Si le port est ouvert, déclarer un char[] array avec un élément.
            char[] buff = new char[1];

            // Charger l'élément 0 avec une clef de caractère.
            buff[0] = e.KeyChar;

            // Send the one character buffer.
            serialPort1.Write(buff, 0, 1);

            // Set the KeyPress event as handled so the character won't
            // display locally. If you want it to display, omit the next line.
            e.Handled = true;
        }

        private void DisplayText(object sender, EventArgs e)
        {
            //Pour toutes les données
            textBoxTempsReel.AppendText(RxString);
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            RxString = serialPort1.ReadExisting();
            this.Invoke(new EventHandler(DisplayText));

            //Compter les donnees
            int compteur=0;
            compteur = compteur + 1;
            string data;
            data = compteur.ToString();
            //nbDonnees.AppendText(data);

        }

        private void temperature1_TextChanged(object sender, EventArgs e)
        {
            //afficher la dernière température 1 lue
            temperature1.AppendText(RxString);
        }

        private void temperature2_TextChanged(object sender, EventArgs e)
        {
            //afficher la dernière température 2 lue
           temperature2.AppendText(RxString);
        }



        //Les boutons
        //bouton démarrer
        private void buttonStart_Click(object sender, EventArgs e)
        {
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
            serialPort1.PortName = choixPort.Text.ToString();
            serialPort1.BaudRate = Convert.ToInt32(choixBaurate.Text);
            serialPort1.DataBits = Convert.ToInt16(choixDataBits.Text);
            serialPort1.Open();
            timerProgressBar.Start();
            timer1Min.Start();
            timer10Min.Start();
            timer1Hr.Start();

            if (serialPort1.IsOpen)
            {
                boutonDemarrer.Enabled = false;
                boutonArret.Enabled = true;
                textBox1Min.ReadOnly = false;
                textBox10Min.ReadOnly = false;
                textBox1Hr.ReadOnly = false;
                textBoxTempsReel.ReadOnly = false;
            }
        }

        //bouton arret
        private void buttonStop_Click(object sender, EventArgs e)
        {

            //pour arreter la barre de progression
            timerProgressBar.Stop();
            progressBar1.Value = 0;

            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                boutonDemarrer.Enabled = true;
                boutonArret.Enabled = false;
                textBox1Min.ReadOnly = true;
            }
        }

        //bouton effacer
        private void effacer_Click(object sender, EventArgs e)
        {
            textBox1Min.Clear();
        }

        //bouton quitter
        private void boutonQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        //Les textBox
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }



        //La barre de progression
        private void progressBar1_Click(object sender, EventArgs e)
        {

            this.timerProgressBar.Start();
        }



        //Les timers
        private void timer_Tick(object sender, EventArgs e)
        {
         //Pour la barre de progression et le timer
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Step = 4;
            progressBar1.PerformStep();
            if (progressBar1.Value == 100)
            {
                progressBar1.Value = 0;
                timerProgressBar.Stop();
                timerProgressBar.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Pour 1 minutes
            textBox1Min.AppendText(RxString);
            timer1Min.Stop();
            timer1Min.Start();
        }
        
        private void timer10Min_Tick(object sender, EventArgs e)
        {
            //Pour 10 minutes
            textBox1Hr.AppendText(RxString);
            timer10Min.Stop();
            timer10Min.Start();
        }

        private void timer1Hr_Tick(object sender, EventArgs e)
        {
            //Pour 1 heure
            textBox1Hr.AppendText(RxString);
            timer1Min.Stop();
            timer1Min.Start();
        }



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

        private void label1_Click(object sender, EventArgs e)
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
    }
}