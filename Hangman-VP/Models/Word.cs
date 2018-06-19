using Hangman.Models;
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
        public Difficulty Difficulty { get; set; }
        public Language Language { get; set; }
        public Category Category { get; set; }

        public Word(string name, string hint, Difficulty difficulty, Language language, Category category)
        {
            Name = name;
            Hint = hint;
            Difficulty = difficulty;
            Language = language;
            Category = category;
        }
    }
}
