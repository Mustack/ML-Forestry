using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ML_Forest
{
    public partial class Comment : Form
    {
        Plot plot;

        public Comment(Plot passedPlot)
        {
            this.plot = passedPlot;
            InitializeComponent();
        }

        private void Comment_Load(object sender, EventArgs e)
        {
            labelPlot.Text = "Plot "+ plot.plotNum.ToString();
            labelStand.Text = "Stand "+ plot.standNum.ToString();
        }

        private void cbPw_CheckStateChanged(object sender, EventArgs e)
        {
            plot.toggleRegen(Plot.Pw_AGS);
        }

        private void cbPr_CheckStateChanged(object sender, EventArgs e)
        {
            plot.toggleRegen(Plot.Pr_AGS);
        }

        private void cbSw_CheckStateChanged(object sender, EventArgs e)
        {
            plot.toggleRegen(Plot.Sw_AGS);
        }

        private void cbHe_CheckStateChanged(object sender, EventArgs e)
        {
            plot.toggleRegen(Plot.He_AGS);
        }

        private void cbCe_CheckStateChanged(object sender, EventArgs e)
        {
            plot.toggleRegen(Plot.Ce_AGS);
        }

        private void cbBf_CheckStateChanged(object sender, EventArgs e)
        {
            plot.toggleRegen(Plot.Bf_AGS);
        }

        private void cbLt_CheckStateChanged(object sender, EventArgs e)
        {
            plot.toggleRegen(Plot.Lt_AGS);
        }

        private void cbMh_CheckStateChanged(object sender, EventArgs e)
        {
            plot.toggleRegen(Plot.Mh_AGS);
        }

        private void cbMs_CheckStateChanged(object sender, EventArgs e)
        {
            plot.toggleRegen(Plot.Ms_AGS);
        }

        private void cbBe_CheckStateChanged(object sender, EventArgs e)
        {
            plot.toggleRegen(Plot.Be_AGS);
        }

        private void cbBd_CheckStateChanged(object sender, EventArgs e)
        {
            plot.toggleRegen(Plot.Bd_AGS);
        }

        private void cbBy_CheckStateChanged(object sender, EventArgs e)
        {
            plot.toggleRegen(Plot.By_AGS);
        }

        private void cbIw_CheckStateChanged(object sender, EventArgs e)
        {
            plot.toggleRegen(Plot.Iw_AGS);
        }

        private void cbPo_CheckStateChanged(object sender, EventArgs e)
        {
            plot.toggleRegen(Plot.Po_AGS);
        }

        private void cbOr_CheckStateChanged(object sender, EventArgs e)
        {
            plot.toggleRegen(Plot.Or_AGS);
        }

        private void cbAw_CheckStateChanged(object sender, EventArgs e)
        {
            plot.toggleRegen(Plot.Aw_AGS);
        }

        private void trackRegen_ValueChanged(object sender, EventArgs e)
        {
            string regenDensity = "";

            switch (trackRegen.Value)
            {
                case 0:
                    regenDensity = "Nil";
                    break;
                case 1:
                    regenDensity = "Nil/Light";
                    break;
                case 2:
                    regenDensity = "Light";
                    break;
                case 3:
                    regenDensity = "Light/Medium";
                    break;
                case 4:
                    regenDensity = "Medium";
                    break;
                case 5:
                    regenDensity = "Medium/Heavy";
                    break;
                case 6:
                    regenDensity = "Heavy";
                    break;
            }

            labelDensity.Text = regenDensity;
            plot.regenType = regenDensity;
        }

        private void butDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}