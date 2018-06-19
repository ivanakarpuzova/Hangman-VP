namespace Hangman_VP
{
    partial class HighScoresForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.HardLabel = new System.Windows.Forms.Label();
            this.MediumLabel = new System.Windows.Forms.Label();
            this.EasyLabel = new System.Windows.Forms.Label();
            this.PlayersHighScoreListHard = new System.Windows.Forms.ListBox();
            this.PlayersHighScoreListMedium = new System.Windows.Forms.ListBox();
            this.PlayersWithHighestScoresLabel = new System.Windows.Forms.Label();
            this.PlayersHighScoreListEasy = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HardLabel
            // 
            this.HardLabel.AutoSize = true;
            this.HardLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HardLabel.Location = new System.Drawing.Point(643, 97);
            this.HardLabel.Name = "HardLabel";
            this.HardLabel.Size = new System.Drawing.Size(43, 20);
            this.HardLabel.TabIndex = 16;
            this.HardLabel.Text = "Hard";
            // 
            // MediumLabel
            // 
            this.MediumLabel.AutoSize = true;
            this.MediumLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MediumLabel.Location = new System.Drawing.Point(366, 97);
            this.MediumLabel.Name = "MediumLabel";
            this.MediumLabel.Size = new System.Drawing.Size(67, 20);
            this.MediumLabel.TabIndex = 15;
            this.MediumLabel.Text = "Medium";
            // 
            // EasyLabel
            // 
            this.EasyLabel.AutoSize = true;
            this.EasyLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EasyLabel.Location = new System.Drawing.Point(114, 97);
            this.EasyLabel.Name = "EasyLabel";
            this.EasyLabel.Size = new System.Drawing.Size(40, 20);
            this.EasyLabel.TabIndex = 14;
            this.EasyLabel.Text = "Easy";
            // 
            // PlayersHighScoreListHard
            // 
            this.PlayersHighScoreListHard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.PlayersHighScoreListHard.FormattingEnabled = true;
            this.PlayersHighScoreListHard.ItemHeight = 17;
            this.PlayersHighScoreListHard.Location = new System.Drawing.Point(559, 142);
            this.PlayersHighScoreListHard.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PlayersHighScoreListHard.Name = "PlayersHighScoreListHard";
            this.PlayersHighScoreListHard.Size = new System.Drawing.Size(223, 310);
            this.PlayersHighScoreListHard.TabIndex = 13;
            // 
            // PlayersHighScoreListMedium
            // 
            this.PlayersHighScoreListMedium.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.PlayersHighScoreListMedium.FormattingEnabled = true;
            this.PlayersHighScoreListMedium.ItemHeight = 17;
            this.PlayersHighScoreListMedium.Location = new System.Drawing.Point(298, 142);
            this.PlayersHighScoreListMedium.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PlayersHighScoreListMedium.Name = "PlayersHighScoreListMedium";
            this.PlayersHighScoreListMedium.Size = new System.Drawing.Size(223, 310);
            this.PlayersHighScoreListMedium.TabIndex = 12;
            // 
            // PlayersWithHighestScoresLabel
            // 
            this.PlayersWithHighestScoresLabel.AutoSize = true;
            this.PlayersWithHighestScoresLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayersWithHighestScoresLabel.Location = new System.Drawing.Point(294, 28);
            this.PlayersWithHighestScoresLabel.Name = "PlayersWithHighestScoresLabel";
            this.PlayersWithHighestScoresLabel.Size = new System.Drawing.Size(198, 20);
            this.PlayersWithHighestScoresLabel.TabIndex = 11;
            this.PlayersWithHighestScoresLabel.Text = "Players with highest scores";
            // 
            // PlayersHighScoreListEasy
            // 
            this.PlayersHighScoreListEasy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.PlayersHighScoreListEasy.FormattingEnabled = true;
            this.PlayersHighScoreListEasy.ItemHeight = 17;
            this.PlayersHighScoreListEasy.Location = new System.Drawing.Point(37, 142);
            this.PlayersHighScoreListEasy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PlayersHighScoreListEasy.Name = "PlayersHighScoreListEasy";
            this.PlayersHighScoreListEasy.Size = new System.Drawing.Size(223, 310);
            this.PlayersHighScoreListEasy.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(298, 480);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 42);
            this.button1.TabIndex = 9;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HighScoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(812, 542);
            this.Controls.Add(this.HardLabel);
            this.Controls.Add(this.MediumLabel);
            this.Controls.Add(this.EasyLabel);
            this.Controls.Add(this.PlayersHighScoreListHard);
            this.Controls.Add(this.PlayersHighScoreListMedium);
            this.Controls.Add(this.PlayersWithHighestScoresLabel);
            this.Controls.Add(this.PlayersHighScoreListEasy);
            this.Controls.Add(this.button1);
            this.Name = "HighScoresForm";
            this.Text = "HighScoresForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HardLabel;
        private System.Windows.Forms.Label MediumLabel;
        private System.Windows.Forms.Label EasyLabel;
        private System.Windows.Forms.ListBox PlayersHighScoreListHard;
        private System.Windows.Forms.ListBox PlayersHighScoreListMedium;
        private System.Windows.Forms.Label PlayersWithHighestScoresLabel;
        private System.Windows.Forms.ListBox PlayersHighScoreListEasy;
        private System.Windows.Forms.Button button1;
    }
}