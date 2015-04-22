/*
Author: Marc-Antoine Beaudoin
Date: 2015-04-21
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
        string path = @"..\sauvegarde.txt";         //path du fichier de sauvegarde
        string data="";                             //sert a stocker les donnees lues
        string gauche="";                           //partie gauche de la string de temperature
        string droite = "";                         //partie droite de la string de temperature
        string temperatureData_1 = "";              //sert a inscrire les temperatures 1 lues dans le tableau
        string temperatureData_2 = "";              //sert a inscrire les temperatures 2 lues dans le tableau
        
        string varTempsReel_1 = "";                 //variation temperature_1  en temps reel
        string varTempsReel_2 = "";                 //variation temperature_2  en temps reel
        string var1Min_1 = "";                      //variation temperature_1  a chaque minutes
        string var1Min_2 = "";                      //variation temperature_2  a chaque minutes
        string var10Min_1 = "";                     //variation temperature_1  a chaque 10 minutes
        string var10Min_2 = "";                     //variation temperature_2  a chaque 10 minutes
        string var1Hr_1 = "";                       //variation temperature_1  a chaque heure
        string var1Hr_2 = "";                       //variation temperature_1  a chaque heure

        int compteur = 0;                           //sert a compter le nombre de donnees totales et temps reel
        int compteur1Min = 0;                       //sert a compter le nombre de donnees pour 1 minutes
        int compteur10Min = 0;                      //sert a compter le nombre de donnees pour 10 minutes
        int compteur1Hr = 0;                        //sert a compter le nombre de donnees pour 1 heure

        double tempIni_1 = 0.00;                    //defini la temperature 1 de reference pour le calcul de variation temps reel
        double tempIni_2 = 0.00;                    //defini la temperature 2 de reference pour le calcul de variation temps reel
        double tempIni1Min_1 = 0.00;                //defini la temperature 1 de reference pour le calcul de variation 1 minute
        double tempIni1Min_2 = 0.00;                //defini la temperature 2 de reference pour le calcul de variation 1 minute
        double tempIni10Min_1 = 0.00;               //defini la temperature 1 de reference pour le calcul de variation 10 minute
        double tempIni10Min_2 = 0.00;               //defini la temperature 2 de reference pour le calcul de variation 10 minute
        double tempIni1Hr_1 = 0.00;                 //defini la temperature 1 de reference pour le calcul de variation 1 heure
        double tempIni1Hr_2 = 0.00;                 //defini la temperature 2 de reference pour le calcul de variation 1 heure

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
            if (serialPort.IsOpen)
            {
                serialPort.Close();
            }
        }
        private void serialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            //Permet d'inscrire les donnees dans un fichier texte, soit l'heure et la temperature
            Thread.Sleep(300);
            data = serialPort.ReadExisting();
            StreamWriter MyStreamWriter = new StreamWriter(path, true);
            MyStreamWriter.Write(DateTime.Now);
            MyStreamWriter.WriteLine("");
            MyStreamWriter.Write(data);
            MyStreamWriter.WriteLine("");
            MyStreamWriter.Flush();
            MyStreamWriter.Close();
            this.Invoke(new EventHandler(triData));
         }

        private void triData(object sender, EventArgs e)
        {
            //pour diviser le buffer en deux strings, soit temperature 1 et temperature 2
            gauche = data.Substring(0, data.Length/2);
            droite = data.Substring(gauche.Length);
            this.Invoke(new EventHandler(temperature_1));
            this.Invoke(new EventHandler(temperature_2));
            this.Invoke(new EventHandler(DisplayText));
            this.Invoke(new EventHandler(listTempsReel_SelectedIndexChanged_1));
        }
        
        private void temperature_1(object sender, EventArgs e)
        {
            temperatureData_1 = gauche.Substring(14); //sert a enlever temperature_1= de la chaine pour ne garder que les chiffres
        }

        private void temperature_2(object sender, EventArgs e)
        {
            temperatureData_2 = droite.Substring(14); //sert a enlever temperature_2= de la chaine pour ne garder que les chiffres
        }

#endregion

#region boutons
        //Les boutons
        //bouton demarrer
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
            //pour arreter la barre de progression et la remettre a zero
            timerProgressBar.Stop();
            progressBar1.Value = 0;

            //arret de tout les timers
            timer1Min.Stop();
            timer10Min.Stop();
            timer1Hr.Stop();
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
            //Demarer les timers qui vont synchro le projet
            timerProgressBar.Start();
            timer1Min.Start();
            timer10Min.Start();
            timer1Hr.Start();
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
            this.Invoke(new EventHandler(list1Min_SelectedIndexChanged));
            timer1Min.Stop();
            timer1Min.Start();
        }
        
        private void timer10Min_Tick(object sender, EventArgs e)
        {
            //Pour 10 minutes
            this.Invoke(new EventHandler(list10Min_SelectedIndexChanged));
            timer10Min.Stop();
            timer10Min.Start();
        }

        private void timer1Hr_Tick(object sender, EventArgs e)
        {
            //Pour 1 heure
            this.Invoke(new EventHandler(list1Heure_SelectedIndexChanged));
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
        //Pour les listes pour l'affichage des donnees

        private void list1Min_SelectedIndexChanged(object sender, EventArgs e)
        {
            //pour calculer la variation de la temperature 1
            var1Min_1 = (Convert.ToDouble(temperatureData_1.Replace('.', ',')) - tempIni1Min_1).ToString("0.##");

            //pour calculer la variation de la temperature 2
            var1Min_2 = (Convert.ToDouble(temperatureData_2.Replace('.', ',')) - tempIni1Min_2).ToString("0.##");

            //Pour mettre les elements dans la liste 1 minutes
            compteur1Min = compteur1Min + 1;
            ListViewItem uneMin = new ListViewItem(DateTime.Now.ToLongTimeString());            //temps
            uneMin.SubItems.Add(temperatureData_1);                                             //temperature 1
            uneMin.SubItems.Add(var1Min_1.Replace(',', '.'));                                   //variation
            uneMin.SubItems.Add(temperatureData_2);                                             //temperature 2
            uneMin.SubItems.Add(var1Min_2.Replace(',', '.'));                                   //variation
            uneMin.SubItems.Add(compteur1Min.ToString());                                       //nombre de donnees
            list1Min.Items.Add(uneMin);

            tempIni1Min_1 = Convert.ToDouble(temperatureData_1.Replace('.', ','));
            tempIni1Min_2 = Convert.ToDouble(temperatureData_2.Replace('.', ','));
        }

        private void list10Min_SelectedIndexChanged(object sender, EventArgs e)
        {
            //pour calculer la variation de la temperature 1
            var10Min_1 = (Convert.ToDouble(temperatureData_1.Replace('.', ',')) - tempIni10Min_1).ToString("0.##");

            //pour calculer la variation de la temperature 2
            var10Min_2 = (Convert.ToDouble(temperatureData_2.Replace('.', ',')) - tempIni10Min_2).ToString("0.##");

            //Pour mettre les elements dans la liste 10 minutes

            compteur10Min = compteur10Min + 1;
            ListViewItem dixMin = new ListViewItem(DateTime.Now.ToLongTimeString());            //temps
            dixMin.SubItems.Add(temperatureData_1);                                             //temperature 1
            dixMin.SubItems.Add(var10Min_1.Replace(',', '.'));                                  //variation
            dixMin.SubItems.Add(temperatureData_2);                                             //temperature 2
            dixMin.SubItems.Add(var10Min_2.Replace(',', '.'));                                  //variation
            dixMin.SubItems.Add(compteur10Min.ToString());                                      //nombre de donnees
            list10Min.Items.Add(dixMin);

            tempIni10Min_1 = Convert.ToDouble(temperatureData_1.Replace('.', ','));
            tempIni10Min_2 = Convert.ToDouble(temperatureData_2.Replace('.', ','));
        }

        private void list1Heure_SelectedIndexChanged(object sender, EventArgs e)
        {
            //pour calculer la variation de la temperature 1
            var1Hr_1 = (Convert.ToDouble(temperatureData_1.Replace('.', ',')) - tempIni1Hr_1).ToString("0.##");

            //pour calculer la variation de la temperature 2
            var1Hr_2 = (Convert.ToDouble(temperatureData_2.Replace('.', ',')) - tempIni1Hr_2).ToString("0.##");

            //Pour mettre les elements dans la liste 1 heure

            compteur1Hr = compteur1Hr + 1;
            ListViewItem uneHeure = new ListViewItem(DateTime.Now.ToLongTimeString());          //temps
            uneHeure.SubItems.Add(temperatureData_1);                                           //temperature 1
            uneHeure.SubItems.Add(var1Hr_1.Replace(',', '.'));                                  //variation 1
            uneHeure.SubItems.Add(temperatureData_2);                                           //temperature 2
            uneHeure.SubItems.Add(var1Hr_2.Replace(',', '.'));                                  //variation 2
            uneHeure.SubItems.Add(compteur1Hr.ToString());                                      //nombre de donnees
            list1Heure.Items.Add(uneHeure);

            tempIni1Hr_1 = Convert.ToDouble(temperatureData_1.Replace('.', ','));
            tempIni1Hr_2 = Convert.ToDouble(temperatureData_2.Replace('.', ','));
        }

        private void listTempsReel_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //pour calculer la variation de la temperature 1
            varTempsReel_1 = (Convert.ToDouble(temperatureData_1.Replace('.', ',')) - tempIni_1).ToString("0.##");

            //pour calculer la variation de la temperature 2
            varTempsReel_2 = (Convert.ToDouble(temperatureData_2.Replace('.', ',')) - tempIni_2).ToString("0.##");

            //Pour mettre les elements dans la liste temps reel
            ListViewItem tempsReel = new ListViewItem(DateTime.Now.ToLongTimeString());         //temps
            tempsReel.SubItems.Add(temperatureData_1);                                          //temperature 1
            tempsReel.SubItems.Add(varTempsReel_1.Replace(',', '.'));                           //variation1
            tempsReel.SubItems.Add(temperatureData_2);                                          //temperature 2
            tempsReel.SubItems.Add(varTempsReel_2.Replace(',', '.'));                           //variation2
            tempsReel.SubItems.Add(compteur.ToString());                                        //nombre de donnees
            listTempsReel.Items.Add(tempsReel);
            
            tempIni_1 = Convert.ToDouble(temperatureData_1.Replace('.', ','));
            tempIni_2 = Convert.ToDouble(temperatureData_2.Replace('.', ','));

        }

        private void DisplayText(object sender, EventArgs e)
        {
                compteur = compteur + 1;
                temperature1.Clear();
                temperature2.Clear();
                nbDonnees.Clear();
                        
                temperature1.AppendText(temperatureData_1);     //afficher la derniere temperature 1 lue 
                temperature2.AppendText(temperatureData_2);     //afficher la derniere temperature 2 lue 
                nbDonnees.AppendText(compteur.ToString());      //afficher le nombre de donnees au compteur
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

        private void temperature1_TextChanged(object sender, EventArgs e)
        {

        }

        private void temperature2_TextChanged(object sender, EventArgs e)
        {

        }
    }
#endregion
}
