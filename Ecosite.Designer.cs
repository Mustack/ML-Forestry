namespace ML_Forest
{
    partial class Ecosite
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.label1 = new System.Windows.Forms.Label();
            this.textSoil = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textEcosite = new System.Windows.Forms.TextBox();
            this.textPlantsOb = new System.Windows.Forms.TextBox();
            this.labelPlot = new System.Windows.Forms.Label();
            this.labelStand = new System.Windows.Forms.Label();
            this.butDone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.label1.Location = new System.Drawing.Point(3, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 49);
            this.label1.Text = "Soil:";
            // 
            // textSoil
            // 
            this.textSoil.Location = new System.Drawing.Point(172, 89);
            this.textSoil.Name = "textSoil";
            this.textSoil.Size = new System.Drawing.Size(291, 49);
            this.textSoil.TabIndex = 3;
            this.textSoil.TextChanged += new System.EventHandler(this.textSoil_TextChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.label2.Location = new System.Drawing.Point(3, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 49);
            this.label2.Text = "Ecosite:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.label3.Location = new System.Drawing.Point(3, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(351, 49);
            this.label3.Text = "Plants Observed:";
            // 
            // textEcosite
            // 
            this.textEcosite.Location = new System.Drawing.Point(172, 144);
            this.textEcosite.Name = "textEcosite";
            this.textEcosite.Size = new System.Drawing.Size(291, 49);
            this.textEcosite.TabIndex = 8;
            this.textEcosite.TextChanged += new System.EventHandler(this.textEcosite_TextChanged);
            // 
            // textPlantsOb
            // 
            this.textPlantsOb.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.textPlantsOb.Location = new System.Drawing.Point(172, 279);
            this.textPlantsOb.Multiline = true;
            this.textPlantsOb.Name = "textPlantsOb";
            this.textPlantsOb.Size = new System.Drawing.Size(291, 130);
            this.textPlantsOb.TabIndex = 24;
            this.textPlantsOb.TextChanged += new System.EventHandler(this.textPlantsOb_TextChanged);
            // 
            // labelPlot
            // 
            this.labelPlot.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelPlot.Location = new System.Drawing.Point(270, 10);
            this.labelPlot.Name = "labelPlot";
            this.labelPlot.Size = new System.Drawing.Size(181, 67);
            this.labelPlot.Text = "Plot 1";
            // 
            // labelStand
            // 
            this.labelStand.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelStand.Location = new System.Drawing.Point(32, 10);
            this.labelStand.Name = "labelStand";
            this.labelStand.Size = new System.Drawing.Size(198, 67);
            this.labelStand.Text = "Stand 1";
            // 
            // butDone
            // 
            this.butDone.Location = new System.Drawing.Point(154, 620);
            this.butDone.Name = "butDone";
            this.butDone.Size = new System.Drawing.Size(176, 55);
            this.butDone.TabIndex = 81;
            this.butDone.Text = "Done";
            this.butDone.Click += new System.EventHandler(this.butDone_Click);
            // 
            // Ecosite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(480, 696);
            this.Controls.Add(this.butDone);
            this.Controls.Add(this.labelPlot);
            this.Controls.Add(this.labelStand);
            this.Controls.Add(this.textPlantsOb);
            this.Controls.Add(this.textEcosite);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textSoil);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(0, 52);
            this.Menu = this.mainMenu1;
            this.Name = "Ecosite";
            this.Text = "Ecosite";
            this.Load += new System.EventHandler(this.Ecosite_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textSoil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textEcosite;
        private System.Windows.Forms.TextBox textPlantsOb;
        private System.Windows.Forms.Label labelPlot;
        private System.Windows.Forms.Label labelStand;
        private System.Windows.Forms.Button butDone;
    }
}