using Hangman.Models;
using Hangman_VP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman_VP
{
    public partial class NewGameForm : Form
    {
        public NewGameForm()
        {
            InitializeComponent();

            LanguageEnglishRadioButton.Checked = true;
            CategoriesGeneralCheckBox.Checked = true;
            CategoriesSportCheckBox.Checked = true;
            CategoriesScienceCheckBox.Checked = true;
            CategoriesMoviesCheckBox.Checked = true;
            CategoriesGeographyCheckBox.Checked = true;

            RopePictureBox.ImageLocation = @"Images\rope.jpg";
            RopePictureBox2.ImageLocation = @"Images\rope.jpg";
            LogoPictureBox.ImageLocation = @"Images\logo.png";

            LanguageSettings.SetLanguage(Language.English);
            RefreshForm();
        }

        private void NewGameStartButton_Click(object sender, EventArgs e)
        {
            string name = PlayerNameTextBox.Text;
            bool hasCheckedCategory = false;

            if (String.IsNullOrEmpty(name))
            {
                MessageBox.Show(LanguageSettings.EnterNameMessage, LanguageSettings.InvalidName);
                return;
            }

            Difficulty difficulty;
            Language language;
            List<Category> categories = new List<Category>();

            if (DifficultyEasyRadioButton.Checked)
            {
                difficulty = Difficulty.Easy;
            }
            else if (DifficultyMediumRadioButton.Checked)
            {
                difficulty = Difficulty.Medium;
            }
            else
            {
                difficulty = Difficulty.Hard;
            }

            if (LanguageEnglishRadioButton.Checked)
            {
                language = Language.English;
            }
            else
            {
                language = Language.Macedonian;
            }

            foreach (Control checkbox in CategoriesGroupBox.Controls)
            {
                if (checkbox is CheckBox)
                {
                    if (((CheckBox)checkbox).Checked)
                    {
                        hasCheckedCategory = true;
                        if (checkbox.Text == "General" || checkbox.Text == "Општо")
                            categories.Add(Category.General);
                        if (checkbox.Text == "Sport" || checkbox.Text == "Спорт")
                            categories.Add(Category.Sport);
                        if (checkbox.Text == "Science" || checkbox.Text == "Наука")
                            categories.Add(Category.Science);
                        if (checkbox.Text == "Movies" || checkbox.Text == "Филмови")
                            categories.Add(Category.Movies);
                        if (checkbox.Text == "Geography" || checkbox.Text == "Географија")
                            categories.Add(Category.Geography);
                    }
                }
            }

            if (!hasCheckedCategory)
            {
                categories.Add(Category.General);
                categories.Add(Category.Sport);
                categories.Add(Category.Science);
                categories.Add(Category.Movies);
                categories.Add(Category.Geography);
            }

            Player player = new Player(name, 0);
            Game game = new Game(player, difficulty, language, categories);

            HangmanForm hangmanForm = new HangmanForm(game);
            this.Hide();
            if (hangmanForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();

            }
        }

        private void PlayerNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (PlayerNameTextBox.Text.Trim().Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(PlayerNameTextBox, LanguageSettings.EnterNameMessage);
            }
            else
            {
                errorProvider1.SetError(PlayerNameTextBox, null);
            }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlayerNameTextBox.Text = string.Empty;
            foreach (Control checkbox in CategoriesGroupBox.Controls)
            {
                if (checkbox is CheckBox)
                {
                    ((CheckBox)checkbox).Checked = false;
                }
            }
        }

        private void instructionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InstructionsForm instructionsForm = new InstructionsForm();
            instructionsForm.Show();
        }

        private void quitGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void highScoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HighScoresForm highScoresForm = new HighScoresForm();
            highScoresForm.Show();
        }

        private void RefreshForm()
        {
            this.Text = LanguageSettings.NewGame;
            gameToolStripMenuItem.Text = LanguageSettings.NewGame;
            newGameToolStripMenuItem.Text = LanguageSettings.NewGame;
            instructionsToolStripMenuItem.Text = LanguageSettings.Instructions;
            quitGameToolStripMenuItem.Text = LanguageSettings.QuitGame;
            highScoresToolStripMenuItem.Text = LanguageSettings.HighScores;
            developersToolStripMenuItem.Text = LanguageSettings.Developers;
            NameLabel.Text = LanguageSettings.YourName;
            DifficultyLabel.Text = LanguageSettings.Difficulty;
            DifficultyEasyRadioButton.Text = LanguageSettings.DifficultyEasy;
            DifficultyMediumRadioButton.Text = LanguageSettings.DifficultyMedium;
            DifficultyHardRadioButton.Text = LanguageSettings.DifficultyHard;
            LanguageLabel.Text = LanguageSettings.LanguageLabel;
            LanguageEnglishRadioButton.Text = LanguageSettings.LanguageEnglish;
            LanguageMacedonianRadioButton.Text = LanguageSettings.LanguageMacedonian;
            CategoriesLabel.Text = LanguageSettings.CategoriesLabel;
            CategoriesGeneralCheckBox.Text = LanguageSettings.CategoriesGeneral;
            CategoriesSportCheckBox.Text = LanguageSettings.CategoriesSport;
            CategoriesScienceCheckBox.Text = LanguageSettings.CategoriesScience;
            CategoriesMoviesCheckBox.Text = LanguageSettings.CategoriesMovies;
            CategoriesGeographyCheckBox.Text = LanguageSettings.CategoriesGeography;
            NewGameStartButton.Text = LanguageSettings.StartButton;

        }

        private void LanguageEnglishRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            LanguageSettings.SetLanguage(Language.English);
            RefreshForm();
        }

        private void LanguageMacedonianRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            LanguageSettings.SetLanguage(Language.Macedonian);
            RefreshForm();
        }
    }
}
