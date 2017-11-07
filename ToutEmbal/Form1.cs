using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToutEmbal
{
    public partial class Form1 : Form
    {
        public Production production;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            production = new Production();
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem button = sender as ToolStripMenuItem;
            timer1.Dispose();
            timer1.Enabled = true;
            if (button.Tag != null)
            {
                if (button.Tag.ToString() == "1")
                {
                    progressBar1.Enabled = true;
                    progressBar1.Maximum = (int)production.nbrOfBoxes_typeA;
                    progressBar1.Value = 0;
                    production.faultsRateOfLastHour = 0;
                    production.faultsRateSBegining = 0;
                    production.nbrOfBoxesSBegining = 0;
                }
                else if (button.Tag.ToString() == "2")
                {
                    progressBar2.Enabled = true;
                    progressBar2.Maximum = (int)production.nbrOfBoxes_typeB;
                    progressBar2.Value = 0;
                    production.faultsRateOfLastHour = 0;
                    production.faultsRateSBegining = 0;
                    production.nbrOfBoxesSBegining = 0;
                }
                else if (button.Tag.ToString() == "3")
                {
                    progressBar3.Enabled = true;
                    progressBar3.Maximum = (int)production.nbrOfBoxes_typeC;
                    progressBar3.Value = 0;
                    production.faultsRateOfLastHour = 0;
                    production.faultsRateSBegining = 0;
                    production.nbrOfBoxesSBegining = 0;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (progressBar1.Enabled == true)
            {
                if (textBoxNbrOfBoxes.Text != string.Empty)
                {
                    production.faultsRateSBegining = Convert.ToDouble(textBoxFaultsRateSinceBegining.Text);
                    production.faultsRateOfLastHour = Convert.ToDouble(textBoxFaultsRateOneHour.Text);
                    production.nbrOfBoxesSBegining = Convert.ToDouble(textBoxNbrOfBoxes.Text);
                }

                production.RunProduction(1000);

                if (production.nbrOfBoxesSBegining <= production.nbrOfBoxes_typeA)
                    progressBar1.Value = (int)production.nbrOfBoxesSBegining;

                textBoxFaultsRateSinceBegining.Text = production.faultsRateSBegining.ToString("N4");
                textBoxFaultsRateOneHour.Text = production.faultsRateOfLastHour.ToString("N4");
                textBoxNbrOfBoxes.Text = production.nbrOfBoxesSBegining.ToString();
               

            }

            else if (progressBar2.Enabled == true)
            {
                if (textBoxBNbrBoxes.Text != string.Empty)
                {
                    production.faultsRateOfLastHour = Convert.ToDouble(textBoxBDefaultHour.Text);
                    production.faultsRateSBegining = Convert.ToDouble(textBoxBSBegining.Text);
                    production.nbrOfBoxesSBegining = Convert.ToDouble(textBoxBNbrBoxes.Text);
                }
                production.RunProduction(5000);

                if (production.nbrOfBoxesSBegining <= production.nbrOfBoxes_typeB)
                    progressBar2.Value = (int)production.nbrOfBoxesSBegining;

                textBoxBSBegining.Text = production.faultsRateSBegining.ToString("N4");
                textBoxBDefaultHour.Text = production.faultsRateOfLastHour.ToString("N4");
                textBoxBNbrBoxes.Text = production.nbrOfBoxesSBegining.ToString();

            }
            else if (progressBar3.Enabled == true)
            {
                if (textBoxCNbrBoxes.Text != string.Empty)
                {

                    production.faultsRateOfLastHour = Convert.ToDouble(textBoxCDefaultHour.Text);
                    production.faultsRateSBegining = Convert.ToDouble(textBoxCSBegining.Text);
                    production.nbrOfBoxesSBegining = Convert.ToDouble(textBoxCNbrBoxes.Text);
                }
                production.RunProduction(10000);

                if (production.nbrOfBoxesSBegining <= production.nbrOfBoxes_typeC)
                    progressBar3.Value = (int)production.nbrOfBoxesSBegining;

                textBoxCSBegining.Text = production.faultsRateSBegining.ToString("N4");
                textBoxCDefaultHour.Text = production.faultsRateOfLastHour.ToString("N4");
                textBoxCNbrBoxes.Text = production.nbrOfBoxesSBegining.ToString();

            }

            if (progressBar1.Value == production.nbrOfBoxes_typeA)
            {
                timer1.Stop();
                MessageBox.Show("Taux de défauts de la dernière heure : " + textBoxFaultsRateOneHour.Text + "\nNombre de boîtes valides créées : " + textBoxNbrOfBoxes.Text +
                    "\nTaux de défauts depuis le début : " + textBoxFaultsRateSinceBegining.Text);
                ZeroVar(progressBar1);
                textBoxNbrOfBoxes.Text = string.Empty;
                textBoxFaultsRateSinceBegining.Text = string.Empty;
                textBoxFaultsRateOneHour.Text = string.Empty;
            }
            else if (progressBar2.Value == production.nbrOfBoxes_typeB)
            {
                timer1.Stop();
                MessageBox.Show("Taux de défauts de la dernière heure : " + textBoxBDefaultHour.Text + "\nNombre de boîtes valides créées : " + textBoxBNbrBoxes.Text +
                    "\nTaux de défauts depuis le début : " + textBoxBSBegining.Text);
                ZeroVar(progressBar2);
                textBoxBDefaultHour.Text = string.Empty;
                textBoxBNbrBoxes.Text = string.Empty;
                textBoxBSBegining.Text = string.Empty;
            }
            else if (progressBar3.Value == production.nbrOfBoxes_typeC)
            {
                timer1.Stop();
                MessageBox.Show("Taux de défauts de la dernière heure : " + textBoxCDefaultHour.Text + "\nNombre de boîtes valides créées : " + textBoxCNbrBoxes.Text +
                    "\nTaux de défauts depuis le début : " + textBoxCSBegining.Text);
                ZeroVar(progressBar3);
                textBoxCDefaultHour.Text = string.Empty;
                textBoxCNbrBoxes.Text = string.Empty;
                textBoxCSBegining.Text = string.Empty;
            }



            if (production.faultsRateOfLastHour > production.maxFaultsInOneHour)
            {

                timer1.Stop();
                MessageBox.Show(production.faultsRateOfLastHour.ToString());
                progressBar1.Enabled = false;
            }

        }

        private void aToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem button = sender as ToolStripMenuItem;

            if (button.Tag.ToString() == "1")
            {
                progressBar1.Enabled = false;

            }
            else if (button.Tag.ToString() == "2")
            {
                progressBar2.Enabled = false;
            }
            else if (button.Tag.ToString() == "3")
            {
                progressBar3.Enabled = false;
            }
        }

        private void aToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem button = sender as ToolStripMenuItem;
            timer1.Enabled = true;
            timer1.Start();
            if (button.Tag.ToString() == "1")
            {
                progressBar1.Enabled = true;
                progressBar2.Enabled = false;
                progressBar3.Enabled = false;
            }
            else if (button.Tag.ToString() == "2")
            {
                progressBar1.Enabled = false;
                progressBar2.Enabled = true;
                progressBar3.Enabled = false;

            }
            else if (button.Tag.ToString() == "3")
            {
                progressBar1.Enabled = false;
                progressBar2.Enabled = false;
                progressBar3.Enabled = true;
            }
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ZeroVar(ProgressBar _progressBar)
        {
            _progressBar.Enabled = false;
            _progressBar.Value = 0;
            production.faultsRateOfLastHour = 0;
            production.faultsRateSBegining = 0;
            production.nbrOfBoxesSBegining = 0;
            
        }

    }
}
