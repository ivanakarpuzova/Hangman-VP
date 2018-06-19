using System;
using System.Windows.Forms;

namespace Hangman
{
    public partial class HighScoresForm : Form
    {
        public HighScoresForm()
        {
            InitializeComponent();
            WindowState = FormWindowState.Normal;
            this.Text = LanguageSettings.HighScores;
            PlayersWithHighestScoresLabel.Text = LanguageSettings.PlayersWithHighestScoresMessage;
            EasyLabel.Text = LanguageSettings.DifficultyEasy;
            MediumLabel.Text = LanguageSettings.DifficultyMedium;
            HardLabel.Text = LanguageSettings.DifficultyHard;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
