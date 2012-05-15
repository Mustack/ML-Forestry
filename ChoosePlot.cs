using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ML_Forest
{
    public partial class ChoosePlot : Form
    {
        Plot plot;
        CoutingTable countingTable;

        public ChoosePlot(Plot passedPlot, CoutingTable countingTable)
        {
            this.countingTable = countingTable;
            this.plot = passedPlot;
            InitializeComponent();
        }

        private void ChoosePlot_Load(object sender, EventArgs e)
        {
            loadComponents();
        }

        private void loadComponents()
        {
            textLong.Text = plot.longitude.ToString();
            textLat.Text = plot.latitude.ToString();

            labelPlot.Text = "Plot " + plot.plotNum.ToString();
            labelStand.Text = "Stand " + plot.standNum.ToString();

            textStation.Text = plot.station;
            textComment.Text = plot.comment;
        }

        private void textStation_TextChanged(object sender, EventArgs e)
        {
            plot.station = textStation.Text;
        }

        private void textComment_TextChanged(object sender, EventArgs e)
        {
            plot.comment = textComment.Text;
        }

        private void butNewPlot_Click(object sender, EventArgs e)
        {
            plot.exportFile();

            CurrentStand.plotNum++;
            CurrentStand.isChanged = true;
            CurrentStand.save();
            plot = new Plot(CurrentStand.standNum, CurrentStand.plotNum);
            countingTable.setPlot(plot);
            loadComponents();
        }

        private void butRegen_Click(object sender, EventArgs e)
        {
            Form regeneration = new Comment(plot);
            regeneration.Show();
        }

        private void butDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butForceGPS_Click(object sender, EventArgs e)
        {
            plot.pollGPS();
            loadComponents();
        }
    }
}