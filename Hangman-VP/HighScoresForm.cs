using Hangman.Models;
using Hangman.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
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

            List<Player> playersEasy = new List<Player>();
            List<Player> playersMedium = new List<Player>();
            List<Player> playersHard = new List<Player>();

            if (Settings.Default.EasyHighscores != null)
            {
                foreach (var player in Settings.Default.EasyHighscores)
                {
                    string name = player.Trim().Split('-')[0];
                    int points = Int32.Parse(player.Trim().Split('-')[1]);

                    Player p = new Player(name, points);
                    playersEasy.Add(p);
                }
            }

            if (Settings.Default.MediumHighscores != null)
            {
                foreach (var player in Settings.Default.MediumHighscores)
                {
                    string name = player.Trim().Split('-')[0];
                    int points = Int32.Parse(player.Trim().Split('-')[1]);

                    Player p = new Player(name, points);
                    playersMedium.Add(p);
                }

            }

            if (Settings.Default.HardHighscores != null)
            {
                foreach (var player in Settings.Default.HardHighscores)
                {
                    string name = player.Trim().Split('-')[0];
                    int points = Int32.Parse(player.Trim().Split('-')[1]);

                    Player p = new Player(name, points);
                    playersHard.Add(p);
                }
            }

            PlayersHighScoreListEasy.DataSource = playersEasy.OrderByDescending(x => x.HighScore).ToList();
            PlayersHighScoreListMedium.DataSource = playersMedium.OrderByDescending(x => x.HighScore).ToList();
            PlayersHighScoreListHard.DataSource = playersHard.OrderByDescending(x => x.HighScore).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
