namespace ML_Forest
{
    partial class ChoseStand
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
            this.butDecrement = new System.Windows.Forms.Button();
            this.butIncrement = new System.Windows.Forms.Button();
            this.labelStandNum = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textDate = new System.Windows.Forms.TextBox();
            this.textOperator = new System.Windows.Forms.TextBox();
            this.textBlock = new System.Windows.Forms.TextBox();
            this.textTWP = new System.Windows.Forms.TextBox();
            this.textHistory = new System.Windows.Forms.TextBox();
            this.butEcosite = new System.Windows.Forms.Button();
            this.butCreate = new System.Windows.Forms.Button();
            this.butDone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butDecrement
            // 
            this.butDecrement.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.butDecrement.Location = new System.Drawing.Point(70, 4);
            this.butDecrement.Name = "butDecrement";
            this.butDecrement.Size = new System.Drawing.Size(70, 60);
            this.butDecrement.TabIndex = 0;
            this.butDecrement.Text = "-";
            this.butDecrement.Click += new System.EventHandler(this.butDecrement_Click);
            // 
            // butIncrement
            // 
            this.butIncrement.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.butIncrement.Location = new System.Drawing.Point(348, 4);
            this.butIncrement.Name = "butIncrement";
            this.butIncrement.Size = new System.Drawing.Size(70, 60);
            this.butIncrement.TabIndex = 2;
            this.butIncrement.Text = "+";
            this.butIncrement.Click += new System.EventHandler(this.butIncrement_Click);
            // 
            // labelStandNum
            // 
            this.labelStandNum.Font = new System.Drawing.Font("Tahoma", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.labelStandNum.Location = new System.Drawing.Point(146, 4);
            this.labelStandNum.Name = "labelStandNum";
            this.labelStandNum.Size = new System.Drawing.Size(202, 53);
            this.labelStandNum.Text = "Stand X";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(4, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 45);
            this.label3.Text = "Date:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(4, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 45);
            this.label4.Text = "Operator:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(4, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 45);
            this.label5.Text = "Block #:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(4, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 45);
            this.label6.Text = "TWP:";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(4, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 45);
            this.label7.Text = "History:";
            // 
            // textDate
            // 
            this.textDate.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.textDate.Location = new System.Drawing.Point(198, 97);
            this.textDate.Name = "textDate";
            this.textDate.Size = new System.Drawing.Size(226, 41);
            this.textDate.TabIndex = 13;
            this.textDate.TextChanged += new System.EventHandler(this.textDate_TextChanged);
            // 
            // textOperator
            // 
            this.textOperator.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.textOperator.Location = new System.Drawing.Point(198, 145);
            this.textOperator.Name = "textOperator";
            this.textOperator.Size = new System.Drawing.Size(226, 41);
            this.textOperator.TabIndex = 14;
            this.textOperator.TextChanged += new System.EventHandler(this.textOperator_TextChanged);
            // 
            // textBlock
            // 
            this.textBlock.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.textBlock.Location = new System.Drawing.Point(198, 193);
            this.textBlock.Name = "textBlock";
            this.textBlock.Size = new System.Drawing.Size(226, 41);
            this.textBlock.TabIndex = 15;
            this.textBlock.TextChanged += new System.EventHandler(this.textBlock_TextChanged);
            // 
            // textTWP
            // 
            this.textTWP.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.textTWP.Location = new System.Drawing.Point(198, 241);
            this.textTWP.Name = "textTWP";
            this.textTWP.Size = new System.Drawing.Size(226, 41);
            this.textTWP.TabIndex = 16;
            this.textTWP.TextChanged += new System.EventHandler(this.textTWP_TextChanged);
            // 
            // textHistory
            // 
            this.textHistory.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.textHistory.Location = new System.Drawing.Point(145, 302);
            this.textHistory.Multiline = true;
            this.textHistory.Name = "textHistory";
            this.textHistory.Size = new System.Drawing.Size(324, 167);
            this.textHistory.TabIndex = 17;
            this.textHistory.TextChanged += new System.EventHandler(this.textHistory_TextChanged);
            // 
            // butEcosite
            // 
            this.butEcosite.Location = new System.Drawing.Point(4, 662);
            this.butEcosite.Name = "butEcosite";
            this.butEcosite.Size = new System.Drawing.Size(209, 58);
            this.butEcosite.TabIndex = 19;
            this.butEcosite.Text = "Ecosite";
            this.butEcosite.Click += new System.EventHandler(this.butEcosite_Click);
            // 
            // butCreate
            // 
            this.butCreate.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Bold);
            this.butCreate.Location = new System.Drawing.Point(119, 533);
            this.butCreate.Name = "butCreate";
            this.butCreate.Size = new System.Drawing.Size(247, 67);
            this.butCreate.TabIndex = 20;
            this.butCreate.Text = "Create New Stand";
            this.butCreate.Visible = false;
            this.butCreate.Click += new System.EventHandler(this.butCreate_Click);
            // 
            // butDone
            // 
            this.butDone.Location = new System.Drawing.Point(268, 662);
            this.butDone.Name = "butDone";
            this.butDone.Size = new System.Drawing.Size(209, 58);
            this.butDone.TabIndex = 80;
            this.butDone.Text = "Done";
            this.butDone.Click += new System.EventHandler(this.butDone_Click);
            // 
            // ChoseStand
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(480, 741);
            this.Controls.Add(this.butDone);
            this.Controls.Add(this.butCreate);
            this.Controls.Add(this.butEcosite);
            this.Controls.Add(this.textHistory);
            this.Controls.Add(this.textTWP);
            this.Controls.Add(this.textBlock);
            this.Controls.Add(this.textOperator);
            this.Controls.Add(this.textDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelStandNum);
            this.Controls.Add(this.butIncrement);
            this.Controls.Add(this.butDecrement);
            this.Location = new System.Drawing.Point(0, 0);
            this.Menu = this.mainMenu1;
            this.Name = "ChoseStand";
            this.Text = "ChoseStand";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ChoseStand_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butDecrement;
        private System.Windows.Forms.Button butIncrement;
        private System.Windows.Forms.Label labelStandNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textDate;
        private System.Windows.Forms.TextBox textOperator;
        private System.Windows.Forms.TextBox textBlock;
        private System.Windows.Forms.TextBox textTWP;
        private System.Windows.Forms.TextBox textHistory;
        private System.Windows.Forms.Button butEcosite;
        private System.Windows.Forms.Button butCreate;
        private System.Windows.Forms.Button butDone;
    }
}