namespace Hangman_VP
{
    partial class NewGameForm
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
            this.components = new System.ComponentModel.Container();
            this.NewGameStartButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.CategoriesGroupBox = new System.Windows.Forms.GroupBox();
            this.CategoriesGeneralCheckBox = new System.Windows.Forms.CheckBox();
            this.CategoriesMoviesCheckBox = new System.Windows.Forms.CheckBox();
            this.CategoriesGeographyCheckBox = new System.Windows.Forms.CheckBox();
            this.CategoriesScienceCheckBox = new System.Windows.Forms.CheckBox();
            this.CategoriesSportCheckBox = new System.Windows.Forms.CheckBox();
            this.CategoriesLabel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.PlayerNameTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LanguageMacedonianRadioButton = new System.Windows.Forms.RadioButton();
            this.LanguageEnglishRadioButton = new System.Windows.Forms.RadioButton();
            this.LanguageLabel = new System.Windows.Forms.Label();
            this.DifficultyGroupBox = new System.Windows.Forms.GroupBox();
            this.DifficultyLabel = new System.Windows.Forms.Label();
            this.DifficultyEasyRadioButton = new System.Windows.Forms.RadioButton();
            this.DifficultyMediumRadioButton = new System.Windows.Forms.RadioButton();
            this.DifficultyHardRadioButton = new System.Windows.Forms.RadioButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.CategoriesGroupBox.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.DifficultyGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // NewGameStartButton
            // 
            this.NewGameStartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.NewGameStartButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NewGameStartButton.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewGameStartButton.ForeColor = System.Drawing.SystemColors.Window;
            this.NewGameStartButton.Location = new System.Drawing.Point(169, 427);
            this.NewGameStartButton.Margin = new System.Windows.Forms.Padding(2);
            this.NewGameStartButton.Name = "NewGameStartButton";
            this.NewGameStartButton.Size = new System.Drawing.Size(314, 60);
            this.NewGameStartButton.TabIndex = 26;
            this.NewGameStartButton.Text = "Start";
            this.NewGameStartButton.UseVisualStyleBackColor = false;
            this.NewGameStartButton.Click += new System.EventHandler(this.NewGameStartButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Script", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(209, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(251, 46);
            this.label5.TabIndex = 25;
            this.label5.Text = "H A N G M A N";
            // 
            // CategoriesGroupBox
            // 
            this.CategoriesGroupBox.Controls.Add(this.CategoriesGeneralCheckBox);
            this.CategoriesGroupBox.Controls.Add(this.CategoriesMoviesCheckBox);
            this.CategoriesGroupBox.Controls.Add(this.CategoriesGeographyCheckBox);
            this.CategoriesGroupBox.Controls.Add(this.CategoriesScienceCheckBox);
            this.CategoriesGroupBox.Controls.Add(this.CategoriesSportCheckBox);
            this.CategoriesGroupBox.Controls.Add(this.CategoriesLabel);
            this.CategoriesGroupBox.Location = new System.Drawing.Point(169, 320);
            this.CategoriesGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.CategoriesGroupBox.Name = "CategoriesGroupBox";
            this.CategoriesGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.CategoriesGroupBox.Size = new System.Drawing.Size(314, 87);
            this.CategoriesGroupBox.TabIndex = 24;
            this.CategoriesGroupBox.TabStop = false;
            // 
            // CategoriesGeneralCheckBox
            // 
            this.CategoriesGeneralCheckBox.AutoSize = true;
            this.CategoriesGeneralCheckBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoriesGeneralCheckBox.Location = new System.Drawing.Point(154, 17);
            this.CategoriesGeneralCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.CategoriesGeneralCheckBox.Name = "CategoriesGeneralCheckBox";
            this.CategoriesGeneralCheckBox.Size = new System.Drawing.Size(66, 19);
            this.CategoriesGeneralCheckBox.TabIndex = 12;
            this.CategoriesGeneralCheckBox.Text = "General";
            this.CategoriesGeneralCheckBox.UseVisualStyleBackColor = true;
            // 
            // CategoriesMoviesCheckBox
            // 
            this.CategoriesMoviesCheckBox.AutoSize = true;
            this.CategoriesMoviesCheckBox.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoriesMoviesCheckBox.Location = new System.Drawing.Point(237, 39);
            this.CategoriesMoviesCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.CategoriesMoviesCheckBox.Name = "CategoriesMoviesCheckBox";
            this.CategoriesMoviesCheckBox.Size = new System.Drawing.Size(62, 17);
            this.CategoriesMoviesCheckBox.TabIndex = 11;
            this.CategoriesMoviesCheckBox.Text = "Movies";
            this.CategoriesMoviesCheckBox.UseVisualStyleBackColor = true;
            // 
            // CategoriesGeographyCheckBox
            // 
            this.CategoriesGeographyCheckBox.AutoSize = true;
            this.CategoriesGeographyCheckBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoriesGeographyCheckBox.Location = new System.Drawing.Point(154, 63);
            this.CategoriesGeographyCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.CategoriesGeographyCheckBox.Name = "CategoriesGeographyCheckBox";
            this.CategoriesGeographyCheckBox.Size = new System.Drawing.Size(84, 19);
            this.CategoriesGeographyCheckBox.TabIndex = 10;
            this.CategoriesGeographyCheckBox.Text = "Geography";
            this.CategoriesGeographyCheckBox.UseVisualStyleBackColor = true;
            // 
            // CategoriesScienceCheckBox
            // 
            this.CategoriesScienceCheckBox.AutoSize = true;
            this.CategoriesScienceCheckBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoriesScienceCheckBox.Location = new System.Drawing.Point(154, 39);
            this.CategoriesScienceCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.CategoriesScienceCheckBox.Name = "CategoriesScienceCheckBox";
            this.CategoriesScienceCheckBox.Size = new System.Drawing.Size(66, 19);
            this.CategoriesScienceCheckBox.TabIndex = 9;
            this.CategoriesScienceCheckBox.Text = "Science";
            this.CategoriesScienceCheckBox.UseVisualStyleBackColor = true;
            // 
            // CategoriesSportCheckBox
            // 
            this.CategoriesSportCheckBox.AutoSize = true;
            this.CategoriesSportCheckBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoriesSportCheckBox.Location = new System.Drawing.Point(237, 17);
            this.CategoriesSportCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.CategoriesSportCheckBox.Name = "CategoriesSportCheckBox";
            this.CategoriesSportCheckBox.Size = new System.Drawing.Size(54, 19);
            this.CategoriesSportCheckBox.TabIndex = 8;
            this.CategoriesSportCheckBox.Text = "Sport";
            this.CategoriesSportCheckBox.UseVisualStyleBackColor = true;
            // 
            // CategoriesLabel
            // 
            this.CategoriesLabel.AutoSize = true;
            this.CategoriesLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoriesLabel.Location = new System.Drawing.Point(24, 30);
            this.CategoriesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CategoriesLabel.Name = "CategoriesLabel";
            this.CategoriesLabel.Size = new System.Drawing.Size(102, 25);
            this.CategoriesLabel.TabIndex = 6;
            this.CategoriesLabel.Text = "Categories";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.NameLabel);
            this.groupBox3.Controls.Add(this.PlayerNameTextBox);
            this.groupBox3.Location = new System.Drawing.Point(169, 57);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(314, 84);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(13, 29);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(106, 25);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Your name:";
            // 
            // PlayerNameTextBox
            // 
            this.PlayerNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.PlayerNameTextBox.Location = new System.Drawing.Point(139, 29);
            this.PlayerNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.PlayerNameTextBox.Name = "PlayerNameTextBox";
            this.PlayerNameTextBox.Size = new System.Drawing.Size(156, 28);
            this.PlayerNameTextBox.TabIndex = 0;
            this.PlayerNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.PlayerNameTextBox_Validating);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LanguageMacedonianRadioButton);
            this.groupBox2.Controls.Add(this.LanguageEnglishRadioButton);
            this.groupBox2.Controls.Add(this.LanguageLabel);
            this.groupBox2.Location = new System.Drawing.Point(169, 236);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(314, 80);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            // 
            // LanguageMacedonianRadioButton
            // 
            this.LanguageMacedonianRadioButton.AutoSize = true;
            this.LanguageMacedonianRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LanguageMacedonianRadioButton.Location = new System.Drawing.Point(211, 33);
            this.LanguageMacedonianRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.LanguageMacedonianRadioButton.Name = "LanguageMacedonianRadioButton";
            this.LanguageMacedonianRadioButton.Size = new System.Drawing.Size(94, 19);
            this.LanguageMacedonianRadioButton.TabIndex = 8;
            this.LanguageMacedonianRadioButton.TabStop = true;
            this.LanguageMacedonianRadioButton.Text = "Macedonian";
            this.LanguageMacedonianRadioButton.UseVisualStyleBackColor = true;
            // 
            // LanguageEnglishRadioButton
            // 
            this.LanguageEnglishRadioButton.AutoSize = true;
            this.LanguageEnglishRadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LanguageEnglishRadioButton.Location = new System.Drawing.Point(129, 33);
            this.LanguageEnglishRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.LanguageEnglishRadioButton.Name = "LanguageEnglishRadioButton";
            this.LanguageEnglishRadioButton.Size = new System.Drawing.Size(63, 19);
            this.LanguageEnglishRadioButton.TabIndex = 7;
            this.LanguageEnglishRadioButton.TabStop = true;
            this.LanguageEnglishRadioButton.Text = "English";
            this.LanguageEnglishRadioButton.UseVisualStyleBackColor = true;
            // 
            // LanguageLabel
            // 
            this.LanguageLabel.AutoSize = true;
            this.LanguageLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LanguageLabel.Location = new System.Drawing.Point(13, 27);
            this.LanguageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LanguageLabel.Name = "LanguageLabel";
            this.LanguageLabel.Size = new System.Drawing.Size(95, 25);
            this.LanguageLabel.TabIndex = 6;
            this.LanguageLabel.Text = "Language";
            // 
            // DifficultyGroupBox
            // 
            this.DifficultyGroupBox.Controls.Add(this.DifficultyLabel);
            this.DifficultyGroupBox.Controls.Add(this.DifficultyEasyRadioButton);
            this.DifficultyGroupBox.Controls.Add(this.DifficultyMediumRadioButton);
            this.DifficultyGroupBox.Controls.Add(this.DifficultyHardRadioButton);
            this.DifficultyGroupBox.Font = new System.Drawing.Font("Symbol", 8.25F);
            this.DifficultyGroupBox.Location = new System.Drawing.Point(169, 145);
            this.DifficultyGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.DifficultyGroupBox.Name = "DifficultyGroupBox";
            this.DifficultyGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.DifficultyGroupBox.Size = new System.Drawing.Size(314, 85);
            this.DifficultyGroupBox.TabIndex = 21;
            this.DifficultyGroupBox.TabStop = false;
            // 
            // DifficultyLabel
            // 
            this.DifficultyLabel.AutoSize = true;
            this.DifficultyLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DifficultyLabel.Location = new System.Drawing.Point(13, 35);
            this.DifficultyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DifficultyLabel.Name = "DifficultyLabel";
            this.DifficultyLabel.Size = new System.Drawing.Size(87, 25);
            this.DifficultyLabel.TabIndex = 2;
            this.DifficultyLabel.Text = "Difficulty";
            // 
            // DifficultyEasyRadioButton
            // 
            this.DifficultyEasyRadioButton.AutoSize = true;
            this.DifficultyEasyRadioButton.Checked = true;
            this.DifficultyEasyRadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DifficultyEasyRadioButton.Location = new System.Drawing.Point(108, 42);
            this.DifficultyEasyRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.DifficultyEasyRadioButton.Name = "DifficultyEasyRadioButton";
            this.DifficultyEasyRadioButton.Size = new System.Drawing.Size(48, 19);
            this.DifficultyEasyRadioButton.TabIndex = 3;
            this.DifficultyEasyRadioButton.TabStop = true;
            this.DifficultyEasyRadioButton.Text = "Easy";
            this.DifficultyEasyRadioButton.UseVisualStyleBackColor = true;
            // 
            // DifficultyMediumRadioButton
            // 
            this.DifficultyMediumRadioButton.AutoSize = true;
            this.DifficultyMediumRadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DifficultyMediumRadioButton.Location = new System.Drawing.Point(168, 42);
            this.DifficultyMediumRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.DifficultyMediumRadioButton.Name = "DifficultyMediumRadioButton";
            this.DifficultyMediumRadioButton.Size = new System.Drawing.Size(70, 19);
            this.DifficultyMediumRadioButton.TabIndex = 4;
            this.DifficultyMediumRadioButton.Text = "Medium";
            this.DifficultyMediumRadioButton.UseVisualStyleBackColor = true;
            // 
            // DifficultyHardRadioButton
            // 
            this.DifficultyHardRadioButton.AutoSize = true;
            this.DifficultyHardRadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DifficultyHardRadioButton.Location = new System.Drawing.Point(246, 42);
            this.DifficultyHardRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.DifficultyHardRadioButton.Name = "DifficultyHardRadioButton";
            this.DifficultyHardRadioButton.Size = new System.Drawing.Size(51, 19);
            this.DifficultyHardRadioButton.TabIndex = 5;
            this.DifficultyHardRadioButton.Text = "Hard";
            this.DifficultyHardRadioButton.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // NewGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(648, 503);
            this.Controls.Add(this.NewGameStartButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CategoriesGroupBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.DifficultyGroupBox);
            this.Name = "NewGameForm";
            this.Text = "NewGameForm";
            this.CategoriesGroupBox.ResumeLayout(false);
            this.CategoriesGroupBox.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.DifficultyGroupBox.ResumeLayout(false);
            this.DifficultyGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button NewGameStartButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox CategoriesGroupBox;
        private System.Windows.Forms.CheckBox CategoriesGeneralCheckBox;
        private System.Windows.Forms.CheckBox CategoriesMoviesCheckBox;
        private System.Windows.Forms.CheckBox CategoriesGeographyCheckBox;
        private System.Windows.Forms.CheckBox CategoriesScienceCheckBox;
        private System.Windows.Forms.CheckBox CategoriesSportCheckBox;
        private System.Windows.Forms.Label CategoriesLabel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox PlayerNameTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton LanguageMacedonianRadioButton;
        private System.Windows.Forms.RadioButton LanguageEnglishRadioButton;
        private System.Windows.Forms.Label LanguageLabel;
        private System.Windows.Forms.GroupBox DifficultyGroupBox;
        private System.Windows.Forms.Label DifficultyLabel;
        private System.Windows.Forms.RadioButton DifficultyEasyRadioButton;
        private System.Windows.Forms.RadioButton DifficultyMediumRadioButton;
        private System.Windows.Forms.RadioButton DifficultyHardRadioButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}