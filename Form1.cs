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

        // variables du programme
#region variables
        string data="";                         // set à stocker les donnees lues
        string test="";                         //Pour identifier si temperature 1 ou 2
        string temp_2 = "Temperature_1";        //string pour la comparaison
        string temp_1 = "Temperature_2";        //string pour la comparaison
        string temperatureData_1 = "0";          //sert à inscrire les températures 1 lues dans le tableau
        string temperatureData_2 = "0";          //sert à inscrire les températures 2 lues dans le tableau
        string path = @"..\temp.txt";           //path du fichier de sauvegarde
        int compteur = 0;                       //sert à compter le nombre de données
#endregion 


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
        private void serialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            //Permet d'inscrire les donnees dans un fichier text pour le debug
            Thread.Sleep(300);
            data = serialPort.ReadExisting();
            StreamWriter MyStreamWriter = new StreamWriter(path, true);
            MyStreamWriter.Write(data);
            MyStreamWriter.Flush();
            MyStreamWriter.Close();
            this.Invoke(new EventHandler(triData));
         }

        private void triData(object sender, EventArgs e)
        {
            
            //Pour determiner si temperature 1 ou 2
            test = data.Substring(0, 13); //je dois déterminer comment attendre qu'il rentre la chaine au complet avant de la lire, sinon, ça bug.

            if (String.ReferenceEquals(test, temp_1))
            {
                this.Invoke(new EventHandler(temperature_1));
            }
            else if (String.ReferenceEquals(test, temp_2))
            {
                this.Invoke(new EventHandler(temperature_2));
            }
            this.Invoke(new EventHandler(DisplayText));
        }
        
        private void temperature_1(object sender, EventArgs e)
        {
            temperatureData_1 = data.Substring(14, 3); //sert à enlever temperature_1= de la chaine pour ne garder que les chiffres
            this.Invoke(new EventHandler(listTempsReel_SelectedIndexChanged_1)); //envois les valeurs au tableau
        }

        private void temperature_2(object sender, EventArgs e)
        {
            temperatureData_2 = data.Substring(14); //sert à enlever temperature_2= de la chaine pour ne garder que les chiffres
            this.Invoke(new EventHandler(listTempsReel_SelectedIndexChanged_1)); //envois les valeurs au tableau
        }
            
        private void temperature1_TextChanged(object sender, EventArgs e)
        {

        }

        private void temperature2_TextChanged(object sender, EventArgs e)
        {

        }
#endregion

#region boutons
        //Les boutons
        //bouton démarrer
        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
            }
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
            this.Invoke(new EventHandler(TimerStart));
            serialPort.PortName = choixPort.Text.ToString();
            serialPort.BaudRate = Convert.ToInt32(choixBaurate.Text);
            serialPort.DataBits = Convert.ToInt16(choixDataBits.Text);
            serialPort.Open();

            if (serialPort.IsOpen)
            {
                boutonDemarrer.Enabled = false;
                boutonArret.Enabled = true;
            }
        }

        //bouton arret
        private void buttonStop_Click(object sender, EventArgs e)
        {
            //pour arreter la barre de progression et la remettre à zéro
            timerProgressBar.Stop();
            progressBar1.Value = 0;
            //arrêt de tout les timers
            timer1Min.Stop();
            timer10Min.Stop();
            timer1Hr.Stop();
            timer1Sec.Stop();
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
            textBox1.Clear();
            temperature1.Clear();
            temperature2.Clear();
            nbDonnees.Clear();
            list1Min.Items.Clear();
            list10Min.Items.Clear();
            list1Heure.Items.Clear();
            listTempsReel.Items.Clear();
        }

        //bouton quitter
        private void boutonQuitter_Click(object sender, EventArgs e)
        {
            serialPort.Close();
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
        private void TimerStart(object sender, EventArgs e)
        {
            //Démarer les timers qui vont synchro le projet
            timerProgressBar.Start();
            timer1Min.Start();
            timer10Min.Start();
            timer1Hr.Start();
            timer1Sec.Start();
        }

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
        private void timer1Sec_Tick(object sender, EventArgs e)
        {

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

#region Affichage
        //Pour les listes pour l'affichage des données

        private void list1Min_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Pour mettre les éléments dans la liste 1 minutes
            ListViewItem uneMin = new ListViewItem("temps"); //temps
            uneMin.SubItems.Add("température");              //temperature 1
            uneMin.SubItems.Add("var");                      //variation
            uneMin.SubItems.Add("t2");                       //temperature 2
            uneMin.SubItems.Add("var");                      //variation
            uneMin.SubItems.Add("Nbdata");                   //nombre de données
            list1Min.Items.Add(uneMin);
        }

        private void list10Min_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Pour mettre les éléments dans la liste 10 minutes
            ListViewItem dixMin = new ListViewItem("temps"); //temps
            dixMin.SubItems.Add("t1");                       //temperature 1
            dixMin.SubItems.Add("var");                      //variation
            dixMin.SubItems.Add("t2");                       //temperature 2
            dixMin.SubItems.Add("var");                      //variation
            dixMin.SubItems.Add("Nbdata");                   //nombre de données
            list10Min.Items.Add(dixMin);
        }

        private void list1Heure_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Pour mettre les éléments dans la liste 1 heure
            ListViewItem uneHeure = new ListViewItem("temps"); //temps
            uneHeure.SubItems.Add("t1");                        //temperature 1
            uneHeure.SubItems.Add("var");                      //variation
            uneHeure.SubItems.Add("t2");                       //temperature 2
            uneHeure.SubItems.Add("var");                      //variation
            uneHeure.SubItems.Add("Nbdata");                   //nombre de données
            list1Heure.Items.Add(uneHeure);

        }

        private void listTempsReel_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //Pour mettre les éléments dans la liste temps réel
            ListViewItem tempsReel = new ListViewItem("temps"); //temps
            tempsReel.SubItems.Add("t1");                        //temperature 1
            tempsReel.SubItems.Add("var");                      //variation
            tempsReel.SubItems.Add("t2");                       //temperature 2
            tempsReel.SubItems.Add("var");                      //variation
            tempsReel.SubItems.Add("Nbdata");                   //nombre de données
            listTempsReel.Items.Add(tempsReel);
        }

        private void DisplayText(object sender, EventArgs e)
        {
                compteur = compteur + 1;
                textBox1.AppendText(data); //Pour l'affichage de l'onglet debug
                temperature1.Clear();
                temperature2.Clear();
                nbDonnees.Clear();
                temperature1.AppendText(temperatureData_1);     //afficher la dernière température 1 lue 
                temperature2.AppendText(temperatureData_1);     //afficher la dernière température 1 lue 
                nbDonnees.AppendText(compteur.ToString());


        }

        private void nbDonnees_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void PuriSerial_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
#endregion
}
