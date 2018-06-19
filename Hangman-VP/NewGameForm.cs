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
        }

        private void NewGameStartButton_Click(object sender, EventArgs e)
        {
            string name = PlayerNameTextBox.Text;
            bool hasCheckedCategory = false;

            if (String.IsNullOrEmpty(name))
            {
                MessageBox.Show("Внесете име!", "Невалидно име!");
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
                        if (checkbox.Text == "General")
                            categories.Add(Category.General);
                        if (checkbox.Text == "Sport")
                            categories.Add(Category.Sport);
                        if (checkbox.Text == "Science")
                            categories.Add(Category.Science);
                        if (checkbox.Text == "Movies")
                            categories.Add(Category.Movies);
                        if (checkbox.Text == "Geography")
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

            HangmanForm hangmanForm = new HangmanForm();
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
                errorProvider1.SetError(PlayerNameTextBox, "Ве молиме внесете го вашето име!");
            }
            else
            {
                errorProvider1.SetError(PlayerNameTextBox, null);
            }
        }
    }
}
