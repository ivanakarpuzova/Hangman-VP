using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_VP.Models
{
    public class Word
    {
        public string Name { get; set; }
        public string Hint { get; set; }
        public int Difficulty { get; set; }
        public string Language { get; set; }
        public string Category { get; set; }

        public Word(string name, string hint, int difficulty, string language, string category)
        {
            Name = name;
            Hint = hint;
            Difficulty = difficulty;
            Language = language;
            Category = category;
        }
    }
}
