using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ML_Forest
{
    public partial class SiteClass : Form
    {
        Plot plot;
        string species;
        int speciesIndex;
        CoutingTable countingTable;

        public SiteClass(Plot plot, string species, int speciesIndex, CoutingTable countingTable)
        {
            this.plot = plot;
            this.species = species;
            this.speciesIndex = speciesIndex;
            this.countingTable = countingTable;

            InitializeComponent();
        }

        private void butDone_Click(object sender, EventArgs e)
        {
            string age = textAge.Text;
            string height = textHeight.Text;

            if (age.Length > 0 && height.Length > 0)
            {
                plot.setSiteClass(speciesIndex, age, height);
                countingTable.loadComponents();
            }

            this.Close();
        }

        private void SiteClass_Load(object sender, EventArgs e)
        {
            labelStand.Text = "Stand " + plot.standNum;
            labelPlot.Text = "Plot " + plot.plotNum;

            labelSC.Text = species + " Site Class";
            textAge.Text = plot.getSiteClass(speciesIndex);
            textHeight.Text = plot.getSiteClass(speciesIndex);
        }
    }
}