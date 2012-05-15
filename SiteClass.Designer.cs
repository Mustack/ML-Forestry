namespace ML_Forest
{
    partial class SiteClass
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
            this.labelPlot = new System.Windows.Forms.Label();
            this.labelStand = new System.Windows.Forms.Label();
            this.textHeight = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textAge = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSC = new System.Windows.Forms.Label();
            this.butDone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPlot
            // 
            this.labelPlot.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelPlot.Location = new System.Drawing.Point(282, 22);
            this.labelPlot.Name = "labelPlot";
            this.labelPlot.Size = new System.Drawing.Size(181, 67);
            this.labelPlot.Text = "Plot 1";
            // 
            // labelStand
            // 
            this.labelStand.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelStand.Location = new System.Drawing.Point(44, 22);
            this.labelStand.Name = "labelStand";
            this.labelStand.Size = new System.Drawing.Size(198, 67);
            this.labelStand.Text = "Stand 1";
            // 
            // textHeight
            // 
            this.textHeight.Location = new System.Drawing.Point(175, 310);
            this.textHeight.Name = "textHeight";
            this.textHeight.Size = new System.Drawing.Size(291, 49);
            this.textHeight.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.label2.Location = new System.Drawing.Point(6, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 49);
            this.label2.Text = "Height:";
            // 
            // textAge
            // 
            this.textAge.Location = new System.Drawing.Point(175, 255);
            this.textAge.Name = "textAge";
            this.textAge.Size = new System.Drawing.Size(291, 49);
            this.textAge.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.label1.Location = new System.Drawing.Point(6, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 49);
            this.label1.Text = "Age:";
            // 
            // labelSC
            // 
            this.labelSC.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.labelSC.Location = new System.Drawing.Point(75, 115);
            this.labelSC.Name = "labelSC";
            this.labelSC.Size = new System.Drawing.Size(340, 61);
            this.labelSC.Text = "Pw Site Class";
            this.labelSC.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // butDone
            // 
            this.butDone.Location = new System.Drawing.Point(151, 611);
            this.butDone.Name = "butDone";
            this.butDone.Size = new System.Drawing.Size(176, 55);
            this.butDone.TabIndex = 81;
            this.butDone.Text = "Done";
            this.butDone.Click += new System.EventHandler(this.butDone_Click);
            // 
            // SiteClass
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(480, 696);
            this.Controls.Add(this.butDone);
            this.Controls.Add(this.labelSC);
            this.Controls.Add(this.labelPlot);
            this.Controls.Add(this.labelStand);
            this.Controls.Add(this.textHeight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textAge);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(0, 52);
            this.Menu = this.mainMenu1;
            this.Name = "SiteClass";
            this.Text = "SiteClass";
            this.Load += new System.EventHandler(this.SiteClass_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelPlot;
        private System.Windows.Forms.Label labelStand;
        private System.Windows.Forms.TextBox textHeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textAge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSC;
        private System.Windows.Forms.Button butDone;
    }
}