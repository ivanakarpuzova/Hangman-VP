using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_VP.Models
{
    public class Player
    {
        public string Name { get; set; }
        public int HighScore { get; set; }

        public Player(string name, int highscore)
        {
            Name = name;
            HighScore = highscore;
        }

        public override string ToString()
        {
            return $"{Name} - {HighScore}";
        }
    }
}
