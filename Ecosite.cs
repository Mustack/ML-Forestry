using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ML_Forest
{
    public partial class Ecosite : Form
    {
        public Ecosite()
        {
            InitializeComponent();
        }

        private void Ecosite_Load(object sender, EventArgs e)
        {
            labelStand.Text = "Stand "+ CurrentStand.standNum.ToString();
            labelPlot.Text = "Plot "+ CurrentStand.plotNum.ToString();
            textSoil.Text = CurrentStand.soil;
            textEcosite.Text = CurrentStand.ecosite;
            textPlantsOb.Text = CurrentStand.plantsObserved;
        }

        private void textSoil_TextChanged(object sender, EventArgs e)
        {
            CurrentStand.soil = textSoil.Text;
            CurrentStand.isChanged = true;
        }

        private void textEcosite_TextChanged(object sender, EventArgs e)
        {
            CurrentStand.ecosite = textEcosite.Text;
            CurrentStand.isChanged = true;
        }

        private void textPlantsOb_TextChanged(object sender, EventArgs e)
        {
            CurrentStand.plantsObserved = textPlantsOb.Text;
            CurrentStand.isChanged = true;
        }

        private void butDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}