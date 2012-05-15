using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ML_Forest
{
    public partial class CoutingTable : Form
    {
        int currentTab;
        public Plot plot;

        public CoutingTable()
        {
            InitializeComponent();
            currentTab = Plot.SAP_SC;
        }

        private void CoutingTable_Load(object sender, EventArgs e)
        {
            plot = new Plot(1, 1);
            Form choseStand = new ChoseStand(this, plot);
            choseStand.Show();
            choseStand.TopMost = true;
        }

        public void setPlot(Plot newPlot)
        {
            this.plot = newPlot;

            loadComponents();
        }

        //Uses currentTab to figure out values for the buttons's text.
        public void loadComponents()
        {
            labelStand.Text = "Stand " + CurrentStand.standNum;
            labelPlot.Text = "Plot " + CurrentStand.plotNum;

            //Set all of the buttons in the AGS column
            butPwAGS.Text = plot.getCount(currentTab, Plot.Pw_AGS).ToString();
            butPrAGS.Text = plot.getCount(currentTab, Plot.Pr_AGS).ToString();
            butSwAGS.Text = plot.getCount(currentTab, Plot.Sw_AGS).ToString();
            butHeAGS.Text = plot.getCount(currentTab, Plot.He_AGS).ToString();
            butCeAGS.Text = plot.getCount(currentTab, Plot.Ce_AGS).ToString();
            butBfAGS.Text = plot.getCount(currentTab, Plot.Bf_AGS).ToString();
            butLtAGS.Text = plot.getCount(currentTab, Plot.Lt_AGS).ToString();
            butMhAGS.Text = plot.getCount(currentTab, Plot.Mh_AGS).ToString();
            butMsAGS.Text = plot.getCount(currentTab, Plot.Ms_AGS).ToString();
            butOrAGS.Text = plot.getCount(currentTab, Plot.Or_AGS).ToString();
            butBeAGS.Text = plot.getCount(currentTab, Plot.Be_AGS).ToString();
            butBdAGS.Text = plot.getCount(currentTab, Plot.Bd_AGS).ToString();
            butAwAGS.Text = plot.getCount(currentTab, Plot.Aw_AGS).ToString();
            butByAGS.Text = plot.getCount(currentTab, Plot.By_AGS).ToString();
            butIwAGS.Text = plot.getCount(currentTab, Plot.Iw_AGS).ToString();
            butPoAGS.Text = plot.getCount(currentTab, Plot.Po_AGS).ToString();
            butBwAGS.Text = plot.getCount(currentTab, Plot.Bw_AGS).ToString();

            //Set all of the buttons in the UGS column
            butPwUGS.Text = plot.getCount(currentTab, Plot.Pw_UGS).ToString();
            butPrUGS.Text = plot.getCount(currentTab, Plot.Pr_UGS).ToString();
            butSwUGS.Text = plot.getCount(currentTab, Plot.Sw_UGS).ToString();
            butHeUGS.Text = plot.getCount(currentTab, Plot.He_UGS).ToString();
            butCeUGS.Text = plot.getCount(currentTab, Plot.Ce_UGS).ToString();
            butBfUGS.Text = plot.getCount(currentTab, Plot.Bf_UGS).ToString();
            butLtUGS.Text = plot.getCount(currentTab, Plot.Lt_UGS).ToString();
            butMhUGS.Text = plot.getCount(currentTab, Plot.Mh_UGS).ToString();
            butMsUGS.Text = plot.getCount(currentTab, Plot.Ms_UGS).ToString();
            butOrUGS.Text = plot.getCount(currentTab, Plot.Or_UGS).ToString();
            butBeUGS.Text = plot.getCount(currentTab, Plot.Be_UGS).ToString();
            butBdUGS.Text = plot.getCount(currentTab, Plot.Bd_UGS).ToString();
            butAwUGS.Text = plot.getCount(currentTab, Plot.Aw_UGS).ToString();
            butByUGS.Text = plot.getCount(currentTab, Plot.By_UGS).ToString();
            butIwUGS.Text = plot.getCount(currentTab, Plot.Iw_UGS).ToString();
            butPoUGS.Text = plot.getCount(currentTab, Plot.Po_UGS).ToString();
            butBwUGS.Text = plot.getCount(currentTab, Plot.Bw_UGS).ToString();

            butPwSC.Text = plot.getSiteClass(Plot.Pw_AGS);
            butPrSC.Text = plot.getSiteClass(Plot.Pr_AGS);
            butHeSC.Text = plot.getSiteClass(Plot.He_AGS);
            butSwSC.Text = plot.getSiteClass(Plot.Sw_AGS);
            butCeSC.Text = plot.getSiteClass(Plot.Ce_AGS);
            butBfSC.Text = plot.getSiteClass(Plot.Bf_AGS);
            butLtSC.Text = plot.getSiteClass(Plot.Lt_AGS);
            butMhSC.Text = plot.getSiteClass(Plot.Mh_AGS);
            butMsSC.Text = plot.getSiteClass(Plot.Ms_AGS);
            butOrSC.Text = plot.getSiteClass(Plot.Or_AGS);
            butBeSC.Text = plot.getSiteClass(Plot.Be_AGS);
            butBdSC.Text = plot.getSiteClass(Plot.Bd_AGS);
            butAwSC.Text = plot.getSiteClass(Plot.Aw_AGS);
            butBySC.Text = plot.getSiteClass(Plot.By_AGS);
            butIwSC.Text = plot.getSiteClass(Plot.Iw_AGS);
            butPoSC.Text = plot.getSiteClass(Plot.Po_AGS);
            butBwSC.Text = plot.getSiteClass(Plot.Bw_AGS);
        }

        private void butPoleTab_Click(object sender, EventArgs e)
        {
            changeTab(Plot.POLEWOOD);
        }

        private void changeTab(int newTab)
        {
            //Unfocus the current tab.
            switch (currentTab)
            {
                case Plot.SAP_SC:
                    butSapTab.BackColor = System.Drawing.Color.LightSteelBlue;
                    break;
                case Plot.POLEWOOD:
                    butPoleTab.BackColor = System.Drawing.Color.LightSteelBlue;
                    break;
                case Plot.SMALL:
                    butSmallTab.BackColor = System.Drawing.Color.LightSteelBlue;
                    break;
                case Plot.MEDIUM:
                    butMediumTab.BackColor = System.Drawing.Color.LightSteelBlue;
                    break;
                case Plot.LARGE:
                    butLargeTab.BackColor = System.Drawing.Color.LightSteelBlue;
                    break;
            }

            //Focus the new tab.
            switch (newTab)
            {
                case Plot.SAP_SC:
                    butSapTab.BackColor = System.Drawing.Color.LimeGreen;
                    break;
                case Plot.POLEWOOD:
                    butPoleTab.BackColor = System.Drawing.Color.LimeGreen;
                    break;
                case Plot.SMALL:
                    butSmallTab.BackColor = System.Drawing.Color.LimeGreen;
                    break;
                case Plot.MEDIUM:
                    butMediumTab.BackColor = System.Drawing.Color.LimeGreen;
                    break;
                case Plot.LARGE:
                    butLargeTab.BackColor = System.Drawing.Color.LimeGreen;
                    break;
            }

            //If moving to or from the Sapling tab...
            if ((currentTab != newTab) && ((currentTab == Plot.SAP_SC) || (newTab == Plot.SAP_SC)))
            {
                toggleScButtons();
            }

            //Now that all changes have been made, we need to set the new value to the current tab.
            currentTab = newTab;

            loadComponents();
        }


        //This function is called before changing currentTab to transition to and from
        //the Sappling/SC tab.
        private void toggleScButtons()
        {
            Boolean isChangingToSapling;

            if (currentTab == Plot.SAP_SC)
            {
                //Change the labels to AGS, UGS
                labelLeftCol.Text = "AGS";
                labelRightCol.Text = "UGS";

                //Set the proper value for the function's flag
                isChangingToSapling = false;
            }
            else
            {
                //Change the labels to Sapling, SC
                labelLeftCol.Text = "Sapling";
                labelRightCol.Text = "SC";

                //Set the proper value for the function's flag
                isChangingToSapling = true;
            }

            //Show/hide all UGS buttons
            butPwUGS.Visible = !isChangingToSapling;
            butPrUGS.Visible = !isChangingToSapling;
            butSwUGS.Visible = !isChangingToSapling;
            butHeUGS.Visible = !isChangingToSapling;
            butCeUGS.Visible = !isChangingToSapling;
            butBfUGS.Visible = !isChangingToSapling;
            butLtUGS.Visible = !isChangingToSapling;
            butMhUGS.Visible = !isChangingToSapling;
            butMsUGS.Visible = !isChangingToSapling;
            butOrUGS.Visible = !isChangingToSapling;
            butBeUGS.Visible = !isChangingToSapling;
            butBdUGS.Visible = !isChangingToSapling;
            butAwUGS.Visible = !isChangingToSapling;
            butByUGS.Visible = !isChangingToSapling;
            butIwUGS.Visible = !isChangingToSapling;
            butPoUGS.Visible = !isChangingToSapling;
            butBwUGS.Visible = !isChangingToSapling;

            //Show/hide all SC buttons
            butPwSC.Visible = isChangingToSapling;
            butPrSC.Visible = isChangingToSapling;
            butSwSC.Visible = isChangingToSapling;
            butHeSC.Visible = isChangingToSapling;
            butCeSC.Visible = isChangingToSapling;
            butBfSC.Visible = isChangingToSapling;
            butLtSC.Visible = isChangingToSapling;
            butMhSC.Visible = isChangingToSapling;
            butMsSC.Visible = isChangingToSapling;
            butOrSC.Visible = isChangingToSapling;
            butBeSC.Visible = isChangingToSapling;
            butBdSC.Visible = isChangingToSapling;
            butAwSC.Visible = isChangingToSapling;
            butBySC.Visible = isChangingToSapling;
            butIwSC.Visible = isChangingToSapling;
            butPoSC.Visible = isChangingToSapling;
            butBwSC.Visible = isChangingToSapling;
        }

        private void butSapTab_Click(object sender, EventArgs e)
        {
            changeTab(Plot.SAP_SC);
        }

        private void butSmallTab_Click(object sender, EventArgs e)
        {
            changeTab(Plot.SMALL);
        }

        private void butMediumTab_Click(object sender, EventArgs e)
        {
            changeTab(Plot.MEDIUM);
        }

        private void butLargeTab_Click(object sender, EventArgs e)
        {
            changeTab(Plot.LARGE);
        }

        private void butPwAGS_Click(object sender, EventArgs e)
        {
            plot.increment(currentTab, Plot.Pw_AGS);
            butPwAGS.Text = plot.getCount(currentTab, Plot.Pw_AGS).ToString();            
        }

        private void butPrAGS_Click(object sender, EventArgs e)
        {
            plot.increment(currentTab, Plot.Pr_AGS);
            butPrAGS.Text = plot.getCount(currentTab, Plot.Pr_AGS).ToString();
        }

        private void butSwAGS_Click(object sender, EventArgs e)
        {
            plot.increment(currentTab, Plot.Sw_AGS);
            butSwAGS.Text = plot.getCount(currentTab, Plot.Sw_AGS).ToString();
        }

        private void butHeAGS_Click(object sender, EventArgs e)
        {
            plot.increment(currentTab, Plot.He_AGS);
            butHeAGS.Text = plot.getCount(currentTab, Plot.He_AGS).ToString();
        }

        private void butCeAGS_Click(object sender, EventArgs e)
        {
            plot.increment(currentTab, Plot.Ce_AGS);
            butCeAGS.Text = plot.getCount(currentTab, Plot.Ce_AGS).ToString();
        }

        private void butBfAGS_Click(object sender, EventArgs e)
        {
            plot.increment(currentTab, Plot.Bf_AGS);
            butBfAGS.Text = plot.getCount(currentTab, Plot.Bf_AGS).ToString();
        }

        private void butLtAGS_Click(object sender, EventArgs e)
        {
            plot.increment(currentTab, Plot.Lt_AGS);
            butLtAGS.Text = plot.getCount(currentTab, Plot.Lt_AGS).ToString();
        }

        private void butMhAGS_Click(object sender, EventArgs e)
        {
            plot.increment(currentTab, Plot.Mh_AGS);
            butMhAGS.Text = plot.getCount(currentTab, Plot.Mh_AGS).ToString();
        }

        private void butMsAGS_Click(object sender, EventArgs e)
        {
            plot.increment(currentTab, Plot.Ms_AGS);
            butMsAGS.Text = plot.getCount(currentTab, Plot.Ms_AGS).ToString();
        }

        private void butOrAGS_Click(object sender, EventArgs e)
        {
            plot.increment(currentTab, Plot.Or_AGS);
            butOrAGS.Text = plot.getCount(currentTab, Plot.Or_AGS).ToString();
        }

        private void butBeAGS_Click(object sender, EventArgs e)
        {
            plot.increment(currentTab, Plot.Be_AGS);
            butBeAGS.Text = plot.getCount(currentTab, Plot.Be_AGS).ToString();
        }

        private void butBdAGS_Click(object sender, EventArgs e)
        {
            plot.increment(currentTab, Plot.Bd_AGS);
            butBdAGS.Text = plot.getCount(currentTab, Plot.Bd_AGS).ToString();
        }

        private void butAwAGS_Click(object sender, EventArgs e)
        {
            plot.increment(currentTab, Plot.Aw_AGS);
            butAwAGS.Text = plot.getCount(currentTab, Plot.Aw_AGS).ToString();
        }

        private void butByAGS_Click(object sender, EventArgs e)
        {
            plot.increment(currentTab, Plot.By_AGS);
            butByAGS.Text = plot.getCount(currentTab, Plot.By_AGS).ToString();
        }

        private void butIwAGS_Click(object sender, EventArgs e)
        {
            plot.increment(currentTab, Plot.Iw_AGS);
            butIwAGS.Text = plot.getCount(currentTab, Plot.Iw_AGS).ToString();
        }

        private void butPoAGS_Click(object sender, EventArgs e)
        {
            plot.increment(currentTab, Plot.Po_AGS);
            butPoAGS.Text = plot.getCount(currentTab, Plot.Po_AGS).ToString();
        }

        private void butPwUGS_Click(object sender, EventArgs e)
        {
            plot.increment(currentTab, Plot.Pw_UGS);
            butPwUGS.Text = plot.getCount(currentTab, Plot.Pw_UGS).ToString();
        }

        private void butPrUGS_Click(object sender, EventArgs e)
        {
            plot.increment(currentTab, Plot.Pr_UGS);
            butPrUGS.Text = plot.getCount(currentTab, Plot.Pr_UGS).ToString();
        }

        private void butSwUGS_Click(object sender, EventArgs e)
        {
            plot.increment(currentTab, Plot.Sw_UGS);
            butSwUGS.Text = plot.getCount(currentTab, Plot.Sw_UGS).ToString();
        }

        private void butHeUGS_Click(object sender, EventArgs e)
        {
            plot.increment(currentTab, Plot.He_UGS);
            butHeUGS.Text = plot.getCount(currentTab, Plot.He_UGS).ToString();
        }

        private void butCeUGS_Click(object sender, EventArgs e)
        {
            plot.increment(currentTab, Plot.Ce_UGS);
            butCeUGS.Text = plot.getCount(currentTab, Plot.Ce_UGS).ToString();
        }

        private void butBfUGS_Click(object sender, EventArgs e)
        {
            plot.increment(currentTab, Plot.Bf_UGS);
            butBfUGS.Text = plot.getCount(currentTab, Plot.Bf_UGS).ToString();
        }

        private void butLtUGS_Click(object sender, EventArgs e)
        {
            plot.increment(currentTab, Plot.Lt_UGS);
            butLtUGS.Text = plot.getCount(currentTab, Plot.Lt_UGS).ToString();
        }

        private void butMhUGS_Click(object sender, EventArgs e)
        {
            plot.increment(currentTab, Plot.Mh_UGS);
            butMhUGS.Text = plot.getCount(currentTab, Plot.Mh_UGS).ToString();
        }

        private void butMsUGS_Click(object sender, EventArgs e)
        {
            plot.increment(currentTab, Plot.Ms_UGS);
            butMsUGS.Text = plot.getCount(currentTab, Plot.Ms_UGS).ToString();
        }

        private void butOrUGS_Click(object sender, EventArgs e)
        {
            plot.increment(currentTab, Plot.Or_UGS);
            butOrUGS.Text = plot.getCount(currentTab, Plot.Or_UGS).ToString();
        }

        private void butBeUGS_Click(object sender, EventArgs e)
        {
            plot.increment(currentTab, Plot.Be_UGS);
            butBeUGS.Text = plot.getCount(currentTab, Plot.Be_UGS).ToString();
        }

        private void butBdUGS_Click(object sender, EventArgs e)
        {
            plot.increment(currentTab, Plot.Bd_UGS);
            butBdUGS.Text = plot.getCount(currentTab, Plot.Bd_UGS).ToString();
        }

        private void butAwUGS_Click(object sender, EventArgs e)
        {
            plot.increment(currentTab, Plot.Aw_UGS);
            butAwUGS.Text = plot.getCount(currentTab, Plot.Aw_UGS).ToString();
        }

        private void butByUGS_Click(object sender, EventArgs e)
        {
            plot.increment(currentTab, Plot.By_UGS);
            butByUGS.Text = plot.getCount(currentTab, Plot.By_UGS).ToString();
        }

        private void butIwUGS_Click(object sender, EventArgs e)
        {
            plot.increment(currentTab, Plot.Iw_UGS);
            butIwUGS.Text = plot.getCount(currentTab, Plot.Iw_UGS).ToString();
        }

        private void butPoUGS_Click(object sender, EventArgs e)
        {
            plot.increment(currentTab, Plot.Po_UGS);
            butPoUGS.Text = plot.getCount(currentTab, Plot.Po_UGS).ToString();
        }

        private void butUndo_Click(object sender, EventArgs e)
        {
            plot.undo(currentTab);
            loadComponents();
        }

        public void butComment_Click(object sender, EventArgs e)
        {
            Form chosePlot = new ChoosePlot(plot, this);
            chosePlot.Show();
        }

        private void butBwUGS_Click(object sender, EventArgs e)
        {
            plot.increment(currentTab, Plot.Bw_UGS);
            butBwUGS.Text = plot.getCount(currentTab, Plot.Bw_UGS).ToString();
        }

        private void butBwAGS_Click(object sender, EventArgs e)
        {
            plot.increment(currentTab, Plot.Bw_AGS);
            butBwAGS.Text = plot.getCount(currentTab, Plot.Bw_AGS).ToString();
        }

        private void butStandInfo_Click(object sender, EventArgs e)
        {
            Form choseStand = new ChoseStand(this, plot);
            choseStand.Show();
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            plot.exportFile();
            CurrentStand.plotNum++;
            CurrentStand.isChanged = true;
            CurrentStand.save();
            Application.Exit();
        }

        private void butPwSC_Click(object sender, EventArgs e)
        {
            Form sc = new SiteClass(plot, "Pw", Plot.Pw_AGS, this);
            sc.Show();
        }

        private void butPrSC_Click(object sender, EventArgs e)
        {
            Form sc = new SiteClass(plot, "Pr", Plot.Pr_AGS, this);
            sc.Show();
        }

        private void butHeSC_Click(object sender, EventArgs e)
        {
            Form sc = new SiteClass(plot, "He", Plot.He_AGS, this);
            sc.Show();
        }

        private void butSwSC_Click(object sender, EventArgs e)
        {
            Form sc = new SiteClass(plot, "Sw", Plot.Sw_AGS, this);
            sc.Show();
        }

        private void butCeSC_Click(object sender, EventArgs e)
        {
            Form sc = new SiteClass(plot, "Ce", Plot.Ce_AGS, this);
            sc.Show();
        }

        private void butBfSC_Click(object sender, EventArgs e)
        {
            Form sc = new SiteClass(plot, "Bf", Plot.Bf_AGS, this);
            sc.Show();
        }

        private void butLtSC_Click(object sender, EventArgs e)
        {
            Form sc = new SiteClass(plot, "Lt", Plot.Lt_AGS, this);
            sc.Show();
        }

        private void butMhSC_Click(object sender, EventArgs e)
        {
            Form sc = new SiteClass(plot, "Mh", Plot.Mh_AGS, this);
            sc.Show();
        }

        private void butMsSC_Click(object sender, EventArgs e)
        {
            Form sc = new SiteClass(plot, "Ms", Plot.Ms_AGS, this);
            sc.Show();
        }

        private void butOrSC_Click(object sender, EventArgs e)
        {
            Form sc = new SiteClass(plot, "Or", Plot.Or_AGS, this);
            sc.Show();
        }

        private void butBeSC_Click(object sender, EventArgs e)
        {
            Form sc = new SiteClass(plot, "Be", Plot.Be_AGS, this);
            sc.Show();
        }

        private void butBdSC_Click(object sender, EventArgs e)
        {
            Form sc = new SiteClass(plot, "Bd", Plot.Bd_AGS, this);
            sc.Show();
        }

        private void butAwSC_Click(object sender, EventArgs e)
        {
            Form sc = new SiteClass(plot, "Aw", Plot.Aw_AGS, this);
            sc.Show();
        }

        private void butBySC_Click(object sender, EventArgs e)
        {
            Form sc = new SiteClass(plot, "By", Plot.By_AGS, this);
            sc.Show();
        }

        private void butIwSC_Click(object sender, EventArgs e)
        {
            Form sc = new SiteClass(plot, "Iw", Plot.Iw_AGS, this);
            sc.Show();
        }

        private void butPoSC_Click(object sender, EventArgs e)
        {
            Form sc = new SiteClass(plot, "Po", Plot.Po_AGS, this);
            sc.Show();
        }

        private void butBwSC_Click(object sender, EventArgs e)
        {
            Form sc = new SiteClass(plot, "Bw", Plot.Bw_AGS, this);
            sc.Show();
        }

    }
}