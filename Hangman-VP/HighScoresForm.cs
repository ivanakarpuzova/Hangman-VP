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
