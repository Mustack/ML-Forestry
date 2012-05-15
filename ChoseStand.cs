using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ML_Forest
{
    public partial class ChoseStand : Form
    {
        CoutingTable countingTable;
        Plot plot;

        public ChoseStand(CoutingTable countingTable, Plot plot)
        {
            this.countingTable = countingTable;
            this.plot = plot;

            InitializeComponent();
        }

        private void ChoseStand_Load(object sender, EventArgs e)
        {
            CurrentStand.loadStand(CurrentStand.standNum);

            loadComponents();
        }

        private void loadComponents()
        {
            labelStandNum.Text = "Stand " + CurrentStand.standNum.ToString();
            textDate.Text = CurrentStand.date;
            textOperator.Text = CurrentStand.standOperator;
            textBlock.Text = CurrentStand.block.ToString();
            textTWP.Text = CurrentStand.twp.ToString();
            textHistory.Text = CurrentStand.history;

            if (CurrentStand.isComplete() && CurrentStand.isLastStand)
            {
                butIncrement.Visible = false;
                butDecrement.Visible = true;
                butCreate.Visible = true;
                butCreate.Text = "Create New Stand";
            }
            else if (!CurrentStand.isComplete())
            {
                butIncrement.Visible = false;
                butDecrement.Visible = false;
                butCreate.Visible = true;
                butCreate.Text = "Cancel";
            }
            else if (CurrentStand.isComplete() && !CurrentStand.isLastStand)
            {
                butIncrement.Visible = true;
                butDecrement.Visible = true;
                butCreate.Visible = false;
            }
        }

        private void butIncrement_Click(object sender, EventArgs e)
        {
            CurrentStand.nextStand();

            loadComponents();
        }

        private void butDecrement_Click(object sender, EventArgs e)
        {
            CurrentStand.previousStand();
            loadComponents();
        }

        private void textDate_TextChanged(object sender, EventArgs e)
        {
            CurrentStand.date = textDate.Text;
            CurrentStand.isChanged = true;
        }

        private void textOperator_TextChanged(object sender, EventArgs e)
        {
            CurrentStand.standOperator = textOperator.Text;
            CurrentStand.isChanged = true;
            loadComponents();
        }

        private void textBlock_TextChanged(object sender, EventArgs e)
        {
            CurrentStand.block = textBlock.Text;
            CurrentStand.isChanged = true;
            loadComponents();
        }

        private void textTWP_TextChanged(object sender, EventArgs e)
        {
            CurrentStand.twp = textTWP.Text;
            CurrentStand.isChanged = true;
            loadComponents();
        }

        private void textHistory_TextChanged(object sender, EventArgs e)
        {
            CurrentStand.history = textHistory.Text;
            CurrentStand.isChanged = true;
        }

        private void butCreate_Click(object sender, EventArgs e)
        {            
            if (CurrentStand.isComplete())
            {
                plot.exportFile();
                CurrentStand.newStand();
                plot = new Plot(CurrentStand.standNum, CurrentStand.plotNum);
                loadComponents();
            }
            else
            {
                if (CurrentStand.standNum == 1)
                {
                    this.Close();
                }
                try
                {
                    CurrentStand.previousStand();
                    loadComponents();
                }catch (ObjectDisposedException exception)
                {
                    Application.Exit();
                }
            }
        }

        private void butEcosite_Click(object sender, EventArgs e)
        {
            Form ecosite = new Ecosite();
            ecosite.Show();
            ecosite.TopMost = true;
        }

        private void butDone_Click(object sender, EventArgs e)
        {
            if (CurrentStand.isComplete())
            {
                CurrentStand.save();
                plot = new Plot(CurrentStand.standNum, CurrentStand.plotNum);
                countingTable.setPlot(plot);
                this.Close();
            }
        }

    }
}