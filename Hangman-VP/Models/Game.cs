using System.Collections.Generic;

namespace Hangman.Models
{
    public enum Difficulty
    {
        Easy,
        Medium,
        Hard
    }

    public enum Language
    {
        English,
        Macedonian
    }

    public enum Category
    {
        General,
        Sport,
        Science,
        Movies,
        Geography,
    }

    public class Game
    {
        public Player Player { get; set; }
        public Difficulty Difficulty { get; set; }
        public Language Language { get; set; }
        public List<Category> Categories { get; set; }

        public Game(Player player, Difficulty difficulty, Language language, List<Category> categories)
        {
            Player = player;
            Difficulty = difficulty;
            Language = language;
            Categories = categories;
        }
    }
}
