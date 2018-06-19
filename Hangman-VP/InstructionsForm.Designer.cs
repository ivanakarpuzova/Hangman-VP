namespace Hangman
{
    partial class InstructionsForm
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
            this.HangmanInstructionsLabel = new System.Windows.Forms.Label();
            this.InstructionsLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HangmanInstructionsLabel
            // 
            this.HangmanInstructionsLabel.AutoSize = true;
            this.HangmanInstructionsLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HangmanInstructionsLabel.Location = new System.Drawing.Point(243, 6);
            this.HangmanInstructionsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HangmanInstructionsLabel.Name = "HangmanInstructionsLabel";
            this.HangmanInstructionsLabel.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.HangmanInstructionsLabel.Size = new System.Drawing.Size(286, 32);
            this.HangmanInstructionsLabel.TabIndex = 5;
            this.HangmanInstructionsLabel.Text = "Hangman Instructions";
            // 
            // InstructionsLabel
            // 
            this.InstructionsLabel.AutoSize = true;
            this.InstructionsLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InstructionsLabel.Location = new System.Drawing.Point(15, 61);
            this.InstructionsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InstructionsLabel.Name = "InstructionsLabel";
            this.InstructionsLabel.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.InstructionsLabel.Size = new System.Drawing.Size(136, 20);
            this.InstructionsLabel.TabIndex = 4;
            this.InstructionsLabel.Text = "InstructionsLabel";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(266, 476);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(249, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InstructionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(785, 523);
            this.Controls.Add(this.HangmanInstructionsLabel);
            this.Controls.Add(this.InstructionsLabel);
            this.Controls.Add(this.button1);
            this.Name = "InstructionsForm";
            this.Text = "InstructionsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HangmanInstructionsLabel;
        private System.Windows.Forms.Label InstructionsLabel;
        private System.Windows.Forms.Button button1;
    }
}