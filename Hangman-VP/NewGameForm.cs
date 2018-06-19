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

            if (String.IsNullOrEmpty(name))
            {
                MessageBox.Show("Внесете име!", "Невалидно име!");
                return;
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
