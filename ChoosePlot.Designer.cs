namespace ML_Forest
{
    partial class ChoosePlot
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
            this.textComment = new System.Windows.Forms.TextBox();
            this.textStation = new System.Windows.Forms.TextBox();
            this.textLat = new System.Windows.Forms.TextBox();
            this.textLong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPlot = new System.Windows.Forms.Label();
            this.labelStand = new System.Windows.Forms.Label();
            this.butNewPlot = new System.Windows.Forms.Button();
            this.butRegen = new System.Windows.Forms.Button();
            this.butForceGPS = new System.Windows.Forms.Button();
            this.butDone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textComment
            // 
            this.textComment.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.textComment.Location = new System.Drawing.Point(220, 304);
            this.textComment.Multiline = true;
            this.textComment.Name = "textComment";
            this.textComment.Size = new System.Drawing.Size(238, 111);
            this.textComment.TabIndex = 23;
            this.textComment.TextChanged += new System.EventHandler(this.textComment_TextChanged);
            // 
            // textStation
            // 
            this.textStation.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.textStation.Location = new System.Drawing.Point(220, 253);
            this.textStation.Name = "textStation";
            this.textStation.Size = new System.Drawing.Size(238, 41);
            this.textStation.TabIndex = 22;
            this.textStation.TextChanged += new System.EventHandler(this.textStation_TextChanged);
            // 
            // textLat
            // 
            this.textLat.Enabled = false;
            this.textLat.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.textLat.Location = new System.Drawing.Point(220, 179);
            this.textLat.Name = "textLat";
            this.textLat.Size = new System.Drawing.Size(238, 41);
            this.textLat.TabIndex = 21;
            // 
            // textLong
            // 
            this.textLong.Enabled = false;
            this.textLong.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.textLong.Location = new System.Drawing.Point(220, 128);
            this.textLong.Name = "textLong";
            this.textLong.Size = new System.Drawing.Size(238, 41);
            this.textLong.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(22, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 45);
            this.label4.Text = "Comment:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(22, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 45);
            this.label3.Text = "Station:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(22, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 45);
            this.label2.Text = "Latitude:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(22, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 45);
            this.label1.Text = "Longitude:";
            // 
            // labelPlot
            // 
            this.labelPlot.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.labelPlot.Location = new System.Drawing.Point(0, 37);
            this.labelPlot.Name = "labelPlot";
            this.labelPlot.Size = new System.Drawing.Size(480, 66);
            this.labelPlot.Text = "Plot 1";
            this.labelPlot.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelStand
            // 
            this.labelStand.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelStand.Location = new System.Drawing.Point(0, 0);
            this.labelStand.Name = "labelStand";
            this.labelStand.Size = new System.Drawing.Size(477, 37);
            this.labelStand.Text = "Stand 1";
            this.labelStand.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // butNewPlot
            // 
            this.butNewPlot.Location = new System.Drawing.Point(136, 445);
            this.butNewPlot.Name = "butNewPlot";
            this.butNewPlot.Size = new System.Drawing.Size(211, 78);
            this.butNewPlot.TabIndex = 32;
            this.butNewPlot.Text = "New Plot";
            this.butNewPlot.Click += new System.EventHandler(this.butNewPlot_Click);
            // 
            // butRegen
            // 
            this.butRegen.Location = new System.Drawing.Point(3, 541);
            this.butRegen.Name = "butRegen";
            this.butRegen.Size = new System.Drawing.Size(223, 70);
            this.butRegen.TabIndex = 39;
            this.butRegen.Text = "Regeneration";
            this.butRegen.Click += new System.EventHandler(this.butRegen_Click);
            // 
            // butForceGPS
            // 
            this.butForceGPS.Location = new System.Drawing.Point(254, 541);
            this.butForceGPS.Name = "butForceGPS";
            this.butForceGPS.Size = new System.Drawing.Size(223, 70);
            this.butForceGPS.TabIndex = 40;
            this.butForceGPS.Text = "Force GPS";
            this.butForceGPS.Click += new System.EventHandler(this.butForceGPS_Click);
            // 
            // butDone
            // 
            this.butDone.Location = new System.Drawing.Point(153, 626);
            this.butDone.Name = "butDone";
            this.butDone.Size = new System.Drawing.Size(176, 55);
            this.butDone.TabIndex = 80;
            this.butDone.Text = "Done";
            this.butDone.Click += new System.EventHandler(this.butDone_Click);
            // 
            // ChoosePlot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(480, 696);
            this.Controls.Add(this.butDone);
            this.Controls.Add(this.butForceGPS);
            this.Controls.Add(this.butRegen);
            this.Controls.Add(this.butNewPlot);
            this.Controls.Add(this.textComment);
            this.Controls.Add(this.textStation);
            this.Controls.Add(this.textLat);
            this.Controls.Add(this.textLong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPlot);
            this.Controls.Add(this.labelStand);
            this.Location = new System.Drawing.Point(0, 52);
            this.Menu = this.mainMenu1;
            this.Name = "ChoosePlot";
            this.Text = "ChoosePlot";
            this.Load += new System.EventHandler(this.ChoosePlot_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textComment;
        private System.Windows.Forms.TextBox textStation;
        private System.Windows.Forms.TextBox textLat;
        private System.Windows.Forms.TextBox textLong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPlot;
        private System.Windows.Forms.Label labelStand;
        private System.Windows.Forms.Button butNewPlot;
        private System.Windows.Forms.Button butRegen;
        private System.Windows.Forms.Button butForceGPS;
        private System.Windows.Forms.Button butDone;
    }
}