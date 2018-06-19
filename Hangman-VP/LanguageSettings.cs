using Hangman.Models;

namespace Hangman
{

    public static class LanguageSettings
    {
        public static string Hangman { get; set; }
        public static string Game { get; set; }
        public static string HighScores { get; set; }
        public static string NewGame { get; set; }
        public static string Instructions { get; set; }
        public static string InstructionsText { get; set; }
        public static string QuitGame { get; set; }

        public static string YourName { get; set; }
        public static string EnterNameMessage { get; set; }
        public static string InvalidName { get; set; }
        public static string Difficulty { get; set; }
        public static string DifficultyEasy { get; set; }
        public static string DifficultyMedium { get; set; }
        public static string DifficultyHard { get; set; }

        public static string LanguageLabel { get; set; }
        public static string LanguageEnglish { get; set; }
        public static string LanguageMacedonian { get; set; }

        public static string CategoriesLabel { get; set; }
        public static string CategoriesGeneral { get; set; }
        public static string CategoriesSport { get; set; }
        public static string CategoriesScience { get; set; }
        public static string CategoriesMovies { get; set; }
        public static string CategoriesGeography { get; set; }

        public static string StartButton { get; set; }
        public static string CategoryLabel { get; set; }
        public static string WrongLetters { get; set; }
        public static string TimeLeft { get; set; }
        public static string Hint { get; set; }

        public static string PlayersWithHighestScoresMessage { get; set; }
        public static string YouWonTheGameMessage { get; set; }
        public static string CongratulationsMessage { get; set; }
        public static string CategoriesFinishedMessage { get; set; }
        public static string WellDoneMessage { get; set; }
        public static string WordGuessCorrect { get; set; }
        public static string WordGuessIncorrect { get; set; }
        public static string YouGotHangedMessage { get; set; }
        public static string TimeIsUpMessage { get; set; }
        public static string HangmanInstructionLabel { get; set; }
        public static string DevelopedByLabel { get; set; }
        public static string Developers { get; set; }

        public static void SetLanguage(Language language)
        {
            if (Language.English == language)
            {
                Hangman = "Hangman";
                Game = "Game";
                HighScores = "High scores";
                NewGame = "New game";
                Instructions = "Instructions";
                QuitGame = "Quit game";
                YourName = "Your name";
                EnterNameMessage = "Please enter your name";
                InvalidName = "Invalid name!";
                Difficulty = "Difficulty";
                DifficultyEasy = "Easy";
                DifficultyMedium = "Medium";
                DifficultyHard = "Hard";
                LanguageLabel = "Language";
                LanguageEnglish = "English";
                LanguageMacedonian = "Macedonian";
                CategoriesLabel = "Categories";
                CategoriesGeneral = "General";
                CategoriesSport = "Sport";
                CategoriesScience = "Science";
                CategoriesMovies = "Movies";
                CategoriesGeography = "Geography";
                StartButton = "Start";
                CategoryLabel = "Category";
                WrongLetters = "Wrong letters:";
                TimeLeft = "Time left:";
                Hint = "Hint";
                PlayersWithHighestScoresMessage = "Players with the highest scores";
                YouWonTheGameMessage = "You won the game on mode: ";
                CongratulationsMessage = "Congratulations !";
                CategoriesFinishedMessage = "You finished the categories, would you like to continue to the rest?";
                WellDoneMessage = "Well done!";
                WordGuessCorrect = "You guessed the word correctly!";
                WordGuessIncorrect = "Too bad, the correct word was ";
                YouGotHangedMessage = "Woops, you got hanged !";
                TimeIsUpMessage = "Time is up, better luck next time !";
                DevelopedByLabel = "Developed by:";
                Developers = "Developers";

                HangmanInstructionLabel = "Hangman Instructions";
                InstructionsText = "1.Select a letter from the keyboard by pressing a button or clicking it with your mouse.\n" +
                                   "2.If the letter is contained in the word, the letter is displayed accordingly in the word.\n" +
                                   "3.If the letter is not contained in the word, the wrong letter is displayed in the wrong letters field\n" +
                                   "and a body part from the man is being drawn.\n" +
                                   "4.You loose (get hanged) if you fail to guess the word and make 6 mistakes / wrong letters.\n" +
                                   "5.You loose (get hanged) if your time runs out.\n" +
                                   "6.The game has three levels of difficulty: Easy, Medium and Hard\n" +
                                   "7.There is a timer for each difficulty: \n" +
                                   "- To guess a word on Easy mode there is a time limit of 3 minutes\n" +
                                   "- To guess a word on Medium mode there is a time limit of 2 minutes\n" +
                                   "- To guess a word on Hard mode htere is a time limit of 1 minute\n" +
                                   "- The complexity of the word depends on the difficulty level.\n" +
                                   "8.When you guess a word correctly, a new word is generated for you to guess.\n" +
                                   "9.The game has multiple categories to choose from.\n" +
                                   "10.When all words from a category are guessed correctly, you move on to the next category\n" +
                                   "11.You win the whole game if you guess all the words in all the categories\n" +
                                   "regardless of the difficulty mode.\n" +
                                   "12.Your score is always being tracked and you can view it in High scores after you finish / quit the game.\n" +
                                   "13.Have fun and don't get hanged !";
            }
            else
            {
                Hangman = "Бесилка";
                Game = "Игра";
                HighScores = "Рекорди";
                NewGame = "Нова игра";
                Instructions = "Инструкции";
                QuitGame = "Откажи игра";
                YourName = "Вашето име";
                EnterNameMessage = "Внесете го вашето име !";
                InvalidName = "Невалидно име!";
                Difficulty = "Ниво";
                DifficultyEasy = "Лесно";
                DifficultyMedium = "Средно";
                DifficultyHard = "Тешко";
                LanguageLabel = "Јазик";
                LanguageEnglish = "Англиски";
                LanguageMacedonian = "Македонски";
                CategoriesLabel = "Категории";
                CategoriesGeneral = "Општо";
                CategoriesSport = "Спорт";
                CategoriesScience = "Наука";
                CategoriesMovies = "Филмови";
                CategoriesGeography = "Географија";
                StartButton = "Почни";
                CategoryLabel = "Категорија";
                WrongLetters = "Грешни букви:";
                TimeLeft = "Време преостанато:";
                Hint = "Помош";
                PlayersWithHighestScoresMessage = "Играчи со најголеми рекорди";
                YouWonTheGameMessage = "Ја победивте играта на ниво: ";
                CongratulationsMessage = "Честитки !";
                CategoriesFinishedMessage = "Успешно ги завршивте категоратиите, сакате ли да продолжите на следните?";
                WellDoneMessage = "Браво!";
                WordGuessCorrect = "Го погодивте зборот!";
                WordGuessIncorrect = "Штета, точниот збор беше ";
                YouGotHangedMessage = "Упс, се обесивте!";
                TimeIsUpMessage = "Времето истече, повеќе среќа на следен збор";
                DevelopedByLabel = "Изработено од:";
                Developers = "Изработиле";

                HangmanInstructionLabel = "Инструкции за Бесилка";
                InstructionsText = "1.Одберете ја буквата што мислите дела е дел од зборот од тастатура или кликнете со маусот\n" +
                                   "2.Ако буквата ја има во зборот, ќе се појави соодветно во зборот за да продолжите со погодување.\n" +
                                   "3.Ако буквата ја нема во зборот, ќе се појави во полето за Грешни букви\n" +
                                   "и дел од телото на човекот за бесење ќе се прикаже соодветно\n" +
                                   "4.Губите (ќе ве обесат) ако не успеете да го погодите зборот - 6 грешни букви.\n" +
                                   "5.Губите (ќе ве обесат) ако вашето време за зборот истече.\n" +
                                   "6.Играта има три нивоа на тешкотија: Лесно, Средно и Тешко.\n" +
                                   "7.Има соодветно време за погодување на збор за секое ниво на тешкотија: \n" +
                                   "- За да погодите збор на Лесно ниво, имате лимит од 3 минути.\n" +
                                   "- За да погодите збор на Средно ниво, имате лимит од 2 минути.\n" +
                                   "- За да погодите збор на Тешко ниво, имате лимит од 1 минута.\n" +
                                   "- Комплексноста на зборот зависи од нивото на тешкотија.\n" +
                                   "8.Кога ќе погодите збор точно, добивате честитка и нов збор е генериран за да го погодите.\n" +
                                   "9.Играта има повеќе категории за бирање.\n" +
                                   "10.Кога сите зборови од соодветна категорија ќе бидат погодени, се преминува на следна категорија.\n" +
                                   "11.Ја победувате целосно играта ако ги погодите сите зборови од сите категории\n" +
                                   "без разлика на нивото на тешкотија на зборови.\n" +
                                   "12.Вашиот рекорд е зачуван после секој збор соодветно,\n" +
                                   "можете да си ги видите рекордите во Рекорди после завршување на игра. \n" +
                                   "13.Забавувајте се и не се бесете!";
            }
        }
    }
}
