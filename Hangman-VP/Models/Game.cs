using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_VP.Models
{
    public class Game
    {
        public Player Player { get; set; }
        public int Difficulty { get; set; }
        public string Language { get; set; }
        public List<string> Categories { get; set; }

        public Game(Player player, int difficulty, string language, List<string> categories)
        {
            Player = player;
            Difficulty = difficulty;
            Language = language;
            Categories = categories;
        }
    }
}
