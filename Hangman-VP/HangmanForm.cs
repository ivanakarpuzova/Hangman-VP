﻿using Hangman.Models;
using Hangman.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hangman
{
    public partial class HangmanForm : Form
    {
        private Timer Timer = new Timer();
        private static int Time { get; set; }
        private const int Interval = 1000;
        public static int TimeElapsed = 0;
        public Game Game { get; set; }
        public List<Word> Words { get; set; }
        public Word Word { get; set; }
        public int Mistakes { get; set; }

        public HangmanForm(Game game)
        {
            InitializeComponent();

            Game = game;
            SetLanguage();
            InitializeTimer();
            DisplayBase();
            LoadWords(false);
            GenerateDisplayWord();
        }

        private void SetLanguage()
        {
            if (Game.Language == Language.English)
            {
                EnglishKeyboard.Visible = true;
                MacedonianKeyboard.Visible = false;
            }
            else
            {
                EnglishKeyboard.Visible = false;
                MacedonianKeyboard.Visible = true;
            }

            this.Text = LanguageSettings.Hangman;
            gameToolStripMenuItem.Text = LanguageSettings.NewGame;
            newGameToolStripMenuItem.Text = LanguageSettings.NewGame;
            instructionsToolStripMenuItem.Text = LanguageSettings.Instructions;
            quitGameToolStripMenuItem.Text = LanguageSettings.QuitGame;
            highScoresToolStripMenuItem.Text = LanguageSettings.HighScores;
            WrongLettersLabel.Text = LanguageSettings.WrongLetters;
            CategoryLabel.Text = LanguageSettings.CategoryLabel;
            TimerLabel.Text = LanguageSettings.TimeLeft;
            HintButton.Text = LanguageSettings.Hint;
            developersToolStripMenuItem.Text = LanguageSettings.Developers;
        }

        //Го пушта тајмерот во зависност од тешкотијата на зборови избрана од играчот
        private void InitializeTimer()
        {
            if (Game.Difficulty == Difficulty.Easy)
            {
                Time = 180;
            }
            else if (Game.Difficulty == Difficulty.Medium)
            {
                Time = 120;
            }
            else
            {
                Time = 60;
            }

            Timer.Tick += new EventHandler(timer_Tick);
            Timer.Interval = Interval;

        }

        //Ги сетира сликите на апликацијата
        private void DisplayBase()
        {
            BasePictureBox.ImageLocation = @"Images\base.png";
            hangmanHead.ImageLocation = @"Images\hangman-1.png";
            hangmanBody.ImageLocation = @"Images\hangman-2.png";
            hangmanLeftArm.ImageLocation = @"Images\hangman-3.png";
            hangmanRightArm.ImageLocation = @"Images\hangman-4.png";
            hangmanLeftLeg.ImageLocation = @"Images\hangman-5.png";
            hangmanRightLeg.ImageLocation = @"Images\hangman-6.png";
        }

        //Генерира random збор од листата од зборови, пушта тајмер за зборот
        private void GenerateDisplayWord()
        {
            Timer.Stop();
            TimeElapsed = 0;
            Timer.Start();

            if (Words.Count != 0)
            {
                int index = new Random().Next(0, Words.Count);
                Word = Words.ElementAt(index);
            }
            else
            {
                if (Game.Categories.Count >= 5)
                {
                    MessageBox.Show($"{LanguageSettings.YouWonTheGameMessage}{Game.Difficulty}!", LanguageSettings.CongratulationsMessage);
                }
                else
                {
                    string categories = string.Empty;
                    foreach (var category in Game.Categories)
                    {
                        categories += category.ToString() + " ";
                    }

                    DialogResult result = MessageBox.Show(LanguageSettings.CategoriesFinishedMessage, LanguageSettings.WellDoneMessage, MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        LoadWords(true);
                        GenerateDisplayWord();
                    }
                    else
                    {
                        NewGameForm newGameForm = new NewGameForm();
                        newGameForm.Show();
                        this.Close();
                    }
                }
            }

            string ctg = string.Empty;
            if (Word.Category == Category.General)
                ctg = LanguageSettings.CategoriesGeneral;
            else if (Word.Category == Category.Sport)
                ctg = LanguageSettings.CategoriesSport;
            else if (Word.Category == Category.Science)
                ctg = LanguageSettings.CategoriesScience;
            else if (Word.Category == Category.Movies)
                ctg = LanguageSettings.CategoriesMovies;
            else
                ctg = LanguageSettings.CategoriesGeography;

            CategoryLabel.Text = $"{LanguageSettings.CategoryLabel}: {ctg}";

            Mistakes = 0;
            WrongoLettersLabel.Text = string.Empty;

            var word = Word.Name.ToUpper()[0].ToString();
            for (var i = 0; i < Word.Name.Length - 1; i++)
            {
                word += " _";
            }
            WordToGuessLabel.Text = word;

            foreach (Button c in EnglishKeyboard.Controls)
            {
                c.Enabled = true;
            }

            foreach (Button c in MacedonianKeyboard.Controls)
            {
                c.Enabled = true;
            }

            hangmanHead.Visible = false;
            hangmanBody.Visible = false;
            hangmanLeftArm.Visible = false;
            hangmanRightArm.Visible = false;
            hangmanLeftLeg.Visible = false;
            hangmanRightLeg.Visible = false;
        }

        //Го прави зборот од форма: U_I_E_R_I_TY во форма : U _ I _ E _ R _ I _ T  Y  -- со празни места изгледа поубаво во апликацијата
        private void UpdateDisplayWord(string word)
        {
            StringBuilder wordBuilder = new StringBuilder();

            for (int i = 0; i < word.Length; i++)
            {
                if (i == word.Length - 1)
                    wordBuilder.Append(word[i]);
                else
                    wordBuilder.Append(word[i] + " ");
            }
            WordToGuessLabel.Text = wordBuilder.ToString().ToUpper();
        }

        //Ја валидира буквата дали постои во зборот и извришува дополнителни функции во зависност од тоа дали е валидна буквата или не
        private void ValidateLetter(char letter)
        {
            bool letterGuessIsCorrect = false;

            //Ибриши ги празните места од зборот.. за да дојде во форма како: u_i_e_s_ty
            string word = new string(WordToGuessLabel.Text.Where(c => !Char.IsWhiteSpace(c)).ToArray()).ToLower();
            for (int i = 0; i < Word.Name.Length; i++)
            {
                //Ако буквата кликната ја има во зборот, избриши го "_" цртичето и стави ја буквата.
                if (Word.Name[i] == letter)
                {
                    letterGuessIsCorrect = true;
                    word = word.Remove(i, 1);
                    word = word.Insert(i, letter.ToString());
                }
            }

            if (Word.Name == word)
            {
                Game.Player.HighScore += 1;
                Words.Remove(Word);
                Timer.Stop();
                UpdateDisplayWord(word);
                MessageBox.Show(LanguageSettings.WordGuessCorrect, LanguageSettings.WellDoneMessage);
                GenerateDisplayWord();
                return;
            }

            if (letterGuessIsCorrect == false)
            {
                ++Mistakes;
                string letters = letter + ", ";
                WrongoLettersLabel.Text += letters.ToUpper();
                switch (Mistakes)
                {
                    case 1:
                        hangmanHead.Visible = true;
                        break;
                    case 2:
                        hangmanBody.Visible = true;
                        break;
                    case 3:
                        hangmanLeftArm.Visible = true;
                        break;
                    case 4:
                        hangmanRightArm.Visible = true;
                        break;
                    case 5:
                        hangmanLeftLeg.Visible = true;
                        break;
                    case 6:
                        hangmanRightLeg.Visible = true;
                        break;
                    default:
                        break;
                }

                if (Mistakes >= 6)
                {
                    Timer.Stop();
                    MessageBox.Show($"{LanguageSettings.WordGuessIncorrect}{Word.Name.ToUpper()}", LanguageSettings.YouGotHangedMessage);
                    SaveHighscore();
                    GenerateDisplayWord();
                    return;
                }
            }
            else
            {
                UpdateDisplayWord(word);
            }
        }

        //Кога ќе се кликне некоја буква од тастатурата, копчето се прави некликабилно (disabled) и се повикува функција за валидација на буквата
        private void letter_Clicked(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.Enabled = false;

            var letter = button.Text.ToLower()[0];
            ValidateLetter(letter);
        }

        private void HintButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Word.Hint, LanguageSettings.Hint);
        }

        //Го зачувува рекордот на играчот во Settings.Default во соодветна листа за тежината на зборовите
        private void SaveHighscore()
        {
            if (Game.Player.HighScore == 0)
                return;

            if (Game.Difficulty == Difficulty.Easy)
            {
                if (Settings.Default.EasyHighscores != null)
                {
                    Settings.Default.EasyHighscores.Add(Game.Player.ToString());
                }
                else
                {
                    Settings.Default.EasyHighscores = new System.Collections.Specialized.StringCollection();
                    Settings.Default.EasyHighscores.Add(Game.Player.ToString());
                }
            }
            else if (Game.Difficulty == Difficulty.Medium)
            {
                if (Settings.Default.MediumHighscores != null)
                {
                    Settings.Default.MediumHighscores.Add(Game.Player.ToString());
                }
                else
                {
                    Settings.Default.MediumHighscores = new System.Collections.Specialized.StringCollection();
                    Settings.Default.MediumHighscores.Add(Game.Player.ToString());
                }
            }
            else
            {
                if (Settings.Default.HardHighscores != null)
                {
                    Settings.Default.HardHighscores.Add(Game.Player.ToString());
                }
                else
                {
                    Settings.Default.HardHighscores = new System.Collections.Specialized.StringCollection();
                    Settings.Default.HardHighscores.Add(Game.Player.ToString());
                }
            }

            Settings.Default.Save();
            Game.Player.HighScore = 0;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            TimeElapsed++;
            if (TimeElapsed <= Time)
            {
                int newTime = Time - TimeElapsed;
                int min = newTime / 60;
                int sec = newTime % 60;
                TimerLabel.Text = string.Format("{0} {1:00}:{2:00}", LanguageSettings.TimeLeft, min, sec);
            }
            else
            {
                Timer.Dispose();
                TimeElapsed = 0;
                Timer.Stop();
                MessageBox.Show(LanguageSettings.TimeIsUpMessage, LanguageSettings.YouGotHangedMessage);
                GenerateDisplayWord();
            }
        }

        private void quitGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void instructionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InstructionsForm instructionsForm = new InstructionsForm();
            instructionsForm.Show();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGameForm newGameForm = new NewGameForm();
            newGameForm.Show();
            this.Close();
        }

        private void highScoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HighScoresForm highScoresForm = new HighScoresForm();
            highScoresForm.Show();
        }

        private void HangmanForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveHighscore();
        }

        //Event на целата форма, слуша за копче кликнато од тастатура, текстот на копчето се испраќа на ValidateLetter функцијата..
        private void HangmanForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            string buttonText = e.KeyChar.ToString().ToUpper();
            if (buttonText == " ")
                return;

            char letter = e.KeyChar.ToString().Trim().ToLower()[0];

            if (Game.Language == Language.English)
            {
                foreach (Button button in EnglishKeyboard.Controls)
                {
                    if (button.Text == buttonText && button.Enabled == true)
                    {
                        button.Enabled = false;
                        ValidateLetter(letter);
                    }
                }
            }
            else
            {
                foreach (Button button in MacedonianKeyboard.Controls)
                {
                    if (button.Text == buttonText && button.Enabled == true)
                    {
                        button.Enabled = false;
                        ValidateLetter(letter);
                    }
                }
            }
        }

        private void developersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DevelopersForm developersForm = new DevelopersForm();
            developersForm.Show();
        }

        private void LoadWords(bool categoriesCompleted)
        {
            Words = new List<Word>();
            List<Word> words = new List<Word>
            {
                //General, easy, english
                new Word("trees", "We need them for oxygen", Difficulty.Easy, Language.English, Category.General),
                new Word("guitar", "Instrument", Difficulty.Easy, Language.English, Category.General),
                new Word("bear", "Wild fuzzy animal", Difficulty.Easy, Language.English, Category.General),
                new Word("milk", "Product of an animal", Difficulty.Easy, Language.English, Category.General),
                new Word("spider", "Insect", Difficulty.Easy, Language.English, Category.General),
                new Word("triangle", "A geometric shape", Difficulty.Easy, Language.English, Category.General),
                new Word("garbage", "You dispose it", Difficulty.Easy, Language.English, Category.General),
                new Word("alcohol", "Beverage", Difficulty.Easy, Language.English, Category.General),

                //General, medium, english
                new Word("tesseract", "Abstract geometric shape", Difficulty.Medium, Language.English, Category.General),
                new Word("university", "Modern torture method", Difficulty.Medium, Language.English, Category.General),
                new Word("detergent", "Effective cleaning product", Difficulty.Medium, Language.English, Category.General),
                new Word("slippers", "Grandmother weapon", Difficulty.Medium, Language.English, Category.General),
                new Word("console", "Another word for terminal", Difficulty.Medium, Language.English, Category.General),
                new Word("keyboard", "We type on it", Difficulty.Medium, Language.English, Category.General),
                new Word("sunglasses", "We wear them when its hot", Difficulty.Medium, Language.English, Category.General),

                //General, hard, english
                new Word("bandwagon", "Carries a band of musicians", Difficulty.Hard, Language.English, Category.General),
                new Word("galaxy", "Way up above the sky", Difficulty.Hard, Language.English, Category.General),
                new Word("wristwatch", "See your wrists?", Difficulty.Hard, Language.English, Category.General),
                new Word("avocado", "Looks like a pear", Difficulty.Hard, Language.English, Category.General),
                new Word("keyhole", "Where do we put our key in?", Difficulty.Hard, Language.English, Category.General),
                new Word("glowworm", "It moves slowly", Difficulty.Hard, Language.English, Category.General),
                new Word("duplex", "Two story apartment", Difficulty.Hard, Language.English, Category.General),

                //Sport, easy, english
                new Word("basketball", "Five on five game", Difficulty.Easy, Language.English, Category.Sport),
                new Word("soccer", "Game played by two teams", Difficulty.Easy, Language.English, Category.Sport),
                new Word("football", "Game played by two teams",Difficulty.Easy, Language.English, Category.Sport),
                new Word("tennis", "Involves rackets", Difficulty.Easy, Language.English, Category.Sport),
                new Word("teammate", "Player in your team", Difficulty.Easy, Language.English, Category.Sport),
                new Word("waterpolo", "Swimming and goals", Difficulty.Easy, Language.English, Category.Sport),
                new Word("swimming", "Propeling oneself through water", Difficulty.Easy, Language.English, Category.Sport),
                new Word("icehokey", "Involves ice skating", Difficulty.Easy, Language.English, Category.Sport),
                new Word("handball", "Game similar to squash", Difficulty.Easy, Language.English, Category.Sport),

                //Sport, medium, english
                new Word("competitor", "Takes part in a sport activity", Difficulty.Medium, Language.English, Category.Sport),
                new Word("snowboarding", "Sliding downhil", Difficulty.Medium, Language.English, Category.Sport),
                new Word("windsurfing", "Riding water on a sailboard", Difficulty.Medium, Language.English, Category.Sport),
                new Word("sportsmanship", "Ethical behaviour", Difficulty.Medium, Language.English, Category.Sport),
                new Word("fencing", "Sword fighting", Difficulty.Medium, Language.English, Category.Sport),
                new Word("kayaking", "Moving across water", Difficulty.Medium, Language.English, Category.Sport),
                new Word("badminton", "Game with rackets",  Difficulty.Medium, Language.English, Category.Sport),
                new Word("scoreboard", "Results during a match", Difficulty.Medium, Language.English, Category.Sport),
                new Word("wrestling", "Grappling",  Difficulty.Medium, Language.English, Category.Sport),
                new Word("weightlifting", "Involves dumbells and heavy weights", Difficulty.Medium, Language.English, Category.Sport),

                //Sport, hard, english
                new Word("dodgeball", "You need to avoid balls", Difficulty.Hard, Language.English, Category.Sport),
                new Word("bobsleigh", "Racing sledge",Difficulty.Hard, Language.English, Category.Sport),
                new Word("racquetball", "Involves a small hard ball", Difficulty.Hard, Language.English, Category.Sport),
                new Word("parasailing", "Gliding through the air", Difficulty.Hard, Language.English, Category.Sport),
                new Word("ultramarathoner", "Long distance running",  Difficulty.Hard, Language.English, Category.Sport),
                new Word("outfielder", "Running out of the field", Difficulty.Hard, Language.English, Category.Sport),
                new Word("geocaching", "Outdoor recreational activity", Difficulty.Hard, Language.English, Category.Sport),
                new Word("athletics", "It ends with the letter S", Difficulty.Hard, Language.English, Category.Sport),

                //Science, easy, english
                new Word("energy", "The intensity of heat presen", Difficulty.Easy, Language.English, Category.Science),
                new Word("universe", "A vast space", Difficulty.Easy, Language.English, Category.Science),
                new Word("gravity", "A big magnet" ,Difficulty.Easy, Language.English, Category.Science),
                new Word("meteor", "Rock that floats in space", Difficulty.Easy, Language.English, Category.Science),
                new Word("earthquake", "'A great upheaval", Difficulty.Easy, Language.English, Category.Science),
                new Word("atmosphere", "Envelope of gases surounding a planet", Difficulty.Easy, Language.English, Category.Science),
                new Word("computer", "Really powerfull modern calculator", Difficulty.Easy, Language.English, Category.Science),
                new Word("smartphone", "Main purpose is to call somebody", Difficulty.Easy, Language.English, Category.Science),

                //Science, medium, english
                new Word("velocity", "The speed of something", Difficulty.Medium, Language.English, Category.Science),
                new Word("magnetism", "Ability to attract", Difficulty.Medium, Language.English, Category.Science),
                new Word("asteroid", "Small rocky body orbiting the sun",Difficulty.Medium, Language.English, Category.Science),
                new Word("organism","Structure of an individual life form", Difficulty.Medium, Language.English, Category.Science),
                new Word("laboratory", "Room for  experiments", Difficulty.Medium, Language.English, Category.Science),
                new Word("thermometer", "Instrument for measuring",  Difficulty.Medium, Language.English, Category.Science),
                new Word("telescope", "Instrument for seeing",  Difficulty.Medium, Language.English, Category.Science),

                //Science, hard, english
                new Word("observatory", "Gives you an extensive view", Difficulty.Hard, Language.English, Category.Science),
                new Word("metamorphosis", "Process of transformation", Difficulty.Hard, Language.English, Category.Science),
                new Word("astrophysics", "Branch of astronomy", Difficulty.Hard, Language.English, Category.Science),
                new Word("anaesthesiology", "Study of anaesthetics", Difficulty.Hard, Language.English, Category.Science),
                new Word("absorption", "Consuming something", Difficulty.Hard, Language.English, Category.Science),
                new Word("antimatter", "Antiparticles", Difficulty.Hard, Language.English, Category.Science),
                new Word("elelctromagnet", "Type of magnet", Difficulty.Hard, Language.English, Category.Science),
                new Word("illuminate", "Alternative to transform", Difficulty.Hard, Language.English, Category.Science),

                //Movies, easy, english
                new Word("hollywood", "Where the most famous movies come from", Difficulty.Easy, Language.English, Category.Movies),
                new Word("marvel", "Where the most awesome movies come from", Difficulty.Easy, Language.English, Category.Movies),
                new Word("batman", "Dark Knight", Difficulty.Easy, Language.English, Category.Movies),
                new Word("spiderman", "Radioactive teenager", Difficulty.Easy, Language.English, Category.Movies),
                new Word("superman", "Really strong", Difficulty.Easy, Language.English, Category.Movies),
                new Word("avengers", "A group of the most powerfull superheroes", Difficulty.Easy, Language.English, Category.Movies),
                new Word("deadpool", "Area filled with water which is dead", Difficulty.Easy, Language.English, Category.Movies),
                new Word("starwars", "Geeky nerds love it", Difficulty.Easy, Language.English, Category.Movies),

                //Movies, medium, english
                new Word("incredibles", "Animated movie", Difficulty.Medium, Language.English, Category.Movies),
                new Word("thorragnarok", "Norse god", Difficulty.Medium, Language.English, Category.Movies),
                new Word("blackpanther", "A cat that is not white", Difficulty.Medium, Language.English, Category.Movies),
                new Word("jumanji", "Involves a game, a really weird one", Difficulty.Medium, Language.English, Category.Movies),
                new Word("venom", "Involves spiderman", Difficulty.Medium, Language.English, Category.Movies),
                new Word("aquaman", "Marvel superhero", Difficulty.Medium, Language.English, Category.Movies),
                new Word("split", "Multiple personallity disorder", Difficulty.Medium, Language.English, Category.Movies),
                new Word("unbreakable", "Prequel to Split, Bruce Willis is the main actor", Difficulty.Medium, Language.English, Category.Movies),

                //Movies, hard, english
                new Word("wolverine", "Claws", Difficulty.Hard, Language.English, Category.Movies),
                new Word("wonderwoman", "Girl power", Difficulty.Hard, Language.English, Category.Movies),
                new Word("justiceleague", "A hard word to guess because avengers are the kings", Difficulty.Hard, Language.English, Category.Movies),
                new Word("assassinscreed", "Ancient cult", Difficulty.Hard, Language.English, Category.Movies),

                 //Geography, easy, english
                new Word("east", "Compass", Difficulty.Easy, Language.English, Category.Geography),
                new Word("west", "Compass", Difficulty.Easy, Language.English, Category.Geography),
                new Word("south", "Compass", Difficulty.Easy, Language.English, Category.Geography),
                new Word("north", "Compass", Difficulty.Easy, Language.English, Category.Geography),
                new Word("mountain", "We climb it", Difficulty.Easy, Language.English, Category.Geography),
                new Word("border", "You probbably need a passport to cross it", Difficulty.Easy, Language.English, Category.Geography),
                new Word("region", "Area", Difficulty.Easy, Language.English, Category.Geography),
                new Word("atlas", "Really cool book", Difficulty.Easy, Language.English, Category.Geography),

                //Geography, medium, english
                new Word("latitude", "Coordinates", Difficulty.Medium, Language.English, Category.Geography),
                new Word("longitude", "Coordinates", Difficulty.Medium, Language.English, Category.Geography),
                new Word("skopje", "Macedonia", Difficulty.Medium, Language.English, Category.Geography),
                new Word("newyork", "USA", Difficulty.Medium, Language.English, Category.Geography),
                new Word("mounteverest", "Really high", Difficulty.Medium, Language.English, Category.Geography),
                new Word("antartica", "Really cold", Difficulty.Medium, Language.English, Category.Geography),
                new Word("equator", "Sounds like the country", Difficulty.Medium, Language.English, Category.Geography),

                //Geography, hard, english
                new Word("uzbekistan", "Some country that ends with 'stan'", Difficulty.Hard, Language.English, Category.Geography),
                new Word("cartography", "Some crafts about graphs or maps", Difficulty.Hard, Language.English, Category.Geography),
                new Word("veles", "Lots of bitches in this small macedonian town", Difficulty.Hard, Language.English, Category.Geography),
                new Word("geography", "Same word as this category", Difficulty.Hard, Language.English, Category.Geography),
                new Word("topography", "Ends with 'graphy'", Difficulty.Hard, Language.English, Category.Geography),

                //General, easy, macedonian
                new Word("гитара", "Instrument", Difficulty.Easy, Language.Macedonian, Category.General),
                new Word("мечка", "диво животно", Difficulty.Easy, Language.Macedonian, Category.General),
                new Word("млеко", "Продукт од животно", Difficulty.Easy, Language.Macedonian,Category.General),
                new Word("пајак", "Инсект", Difficulty.Easy, Language.Macedonian,Category.General),
                new Word("триаголник", "Геометриска фигура", Difficulty.Easy, Language.Macedonian,Category.General),
                new Word("алкохол", "ме густа", Difficulty.Easy, Language.Macedonian,Category.General),

                //General, medium, macedonian
                new Word("униврезитет", "Модерен метод за тортура", Difficulty.Medium, Language.Macedonian,Category.General),
                new Word("детергент", "ПРОДУКТ за чистење", Difficulty.Medium, Language.Macedonian,Category.General),
                new Word("тастатура", "Каде пишуваме", Difficulty.Medium, Language.Macedonian,Category.General),
                new Word("наочари", "Ги носиме кога има сонце", Difficulty.Medium, Language.Macedonian,Category.General),

                //General, hard, macedonian
                new Word("авокадо", "Овошче", Difficulty.Hard, Language.Macedonian,Category.General),
                new Word("брава", "Кај што ги ставаме клучевите", Difficulty.Hard, Language.Macedonian,Category.General),
                new Word("црв", "Се движи бавно", Difficulty.Hard, Language.Macedonian,Category.General),
                new Word("ѓубре", "Загадување", Difficulty.Hard, Language.Macedonian,Category.General),
                new Word("галаксија", "Над небото", Difficulty.Hard, Language.Macedonian, Category.General),

                //Sport, easy, macedonian
                new Word("фудбал", "Игра за мажи", Difficulty.Easy, Language.Macedonian,Category.Sport),
                new Word("тенис", "Се корситат рекети", Difficulty.Easy, Language.Macedonian,Category.Sport),
                new Word("ватерполо", "Пливање и голови", Difficulty.Easy, Language.Macedonian,Category.Sport),
                new Word("хокеј", "Лизгање на мраз", Difficulty.Easy, Language.Macedonian,Category.Sport),
                new Word("ракомет", "Игра со мала топка", Difficulty.Easy, Language.Macedonian,Category.Sport),

                //Sport, medium, macedonian
                new Word("бадмингтон", "Игра со рекети",  Difficulty.Medium, Language.Macedonian,Category.Sport),
                new Word("кајакарење", "Пловење ",  Difficulty.Medium, Language.Macedonian,Category.Sport),
                new Word("борење", "Физички спорт",  Difficulty.Medium, Language.Macedonian,Category.Sport),
                new Word("натпреварувач", "Игра со страст",  Difficulty.Medium, Language.Macedonian,Category.Sport),

                //Sport, hard, macedonian
                new Word("маратон", "Трчaње",  Difficulty.Hard, Language.Macedonian,Category.Sport),
                new Word("атлетика", "започнува со буквата А", Difficulty.Hard, Language.Macedonian,Category.Sport),
                new Word("ултрамаратонец", "Трча многу долги патеки",  Difficulty.Hard, Language.Macedonian,Category.Sport),

                //Science, easy, macedonian
                new Word("компјутер", "Многу моќен калкулатор ", Difficulty.Easy, Language.Macedonian,Category.Science),
                new Word("смартфон", "За да се јавиш", Difficulty.Easy, Language.Macedonian,Category.Science),
                new Word("енергија", "Концентрирана топлина, завршува на 'A'", Difficulty.Easy, Language.Macedonian,Category.Science),
                new Word("метеор", "Камен кој патува низ вселената", Difficulty.Easy, Language.Macedonian,Category.Science),
                new Word("универзум", "Најширокиот простор", Difficulty.Easy, Language.Macedonian,Category.Science),

                //Science, medium, macedonian
                new Word("телескоп", "Инструмет за гледање ѕвезди",  Difficulty.Medium, Language.Macedonian,Category.Science),
                new Word("астероид", "Мало каменесто тело кое лебди низ вселената",  Difficulty.Medium, Language.Macedonian,Category.Science),
                new Word("лабоораторија", "Друг збор за работилница",  Difficulty.Medium, Language.Macedonian,Category.Science),
                new Word("магнетизам", "Привлекување",  Difficulty.Medium, Language.Macedonian,Category.Science),
                new Word("термометар", "Мерење температура",  Difficulty.Medium, Language.Macedonian,Category.Science),

                //Science, hard, macedonian
                new Word("опсерваторија", "Кокино", Difficulty.Hard, Language.Macedonian,Category.Science),
                new Word("метаморфоза", "Процес на трансофрмација", Difficulty.Hard, Language.Macedonian,Category.Science),
                new Word("апсорпција", "Процес на конзумирање или соединување на нешто", Difficulty.Hard, Language.Macedonian,Category.Science),
                new Word("астрофизика", "Гранка на астрономијата", Difficulty.Hard, Language.Macedonian,Category.Science),
                new Word("анестезиологија", "Наука за анестезија", Difficulty.Hard, Language.Macedonian,Category.Science),

                //Movies, easy, macedonian
                new Word("холивуд", "Каде што се снимаат познати филмови", Difficulty.Easy, Language.Macedonian,Category.Movies),
                new Word("марвел", "Каде ги има најјаките филмови", Difficulty.Easy, Language.Macedonian,Category.Movies),
                new Word("бетмен", " Црниот витез од Готхам", Difficulty.Easy, Language.Macedonian,Category.Movies),
                new Word("одмазници", "Одмаздници", Difficulty.Easy, Language.Macedonian, Category.Movies),
                new Word("дедпул", "Мртов базен", Difficulty.Easy, Language.Macedonian, Category.Movies),
                new Word("старварс", "Војната на звездите", Difficulty.Easy, Language.Macedonian, Category.Movies),

                //Movies, medium, macedonian
                new Word("неверојатни", "Анимиран филм", Difficulty.Medium, Language.Macedonian,Category.Movies),
                new Word("торрагнарок", "Норски бог од митологијата", Difficulty.Medium, Language.Macedonian,Category.Movies),
                new Word("црниотпантер", "Филм од марвел", Difficulty.Medium, Language.Macedonian, Category.Movies),
                new Word("Џуманџи", "Робин Вилијамс глумеше во него", Difficulty.Medium, Language.Macedonian, Category.Movies),

                //Movies, medium, hard
                new Word("последождот", "Филм од Милчо Манчевски", Difficulty.Hard, Language.Macedonian, Category.Movies),
                new Word("балканкан", "Најпознатиот филм на балканот", Difficulty.Hard, Language.Macedonian, Category.Movies),
                new Word("бикинимун", "Каде ли ми е паметот?", Difficulty.Hard, Language.Macedonian, Category.Movies),
                new Word("исцелител", "Иван И....... ?", Difficulty.Hard, Language.Macedonian, Category.Movies),

                 //Geography, easy, macedonian
                new Word("исток", "Компас", Difficulty.Easy, Language.Macedonian,Category.Geography),
                new Word("запад",  "Компас", Difficulty.Easy, Language.Macedonian,Category.Geography),
                new Word("север",  "Компас", Difficulty.Easy, Language.Macedonian,Category.Geography),
                new Word("југ",  "Компас", Difficulty.Easy, Language.Macedonian,Category.Geography),
               
                //Geography, medium, macedonian
                new Word("монтеверест", "Висок врв", Difficulty.Medium, Language.Macedonian,Category.Geography),
                new Word("антартик", "Ладно", Difficulty.Medium, Language.Macedonian,Category.Geography),
                new Word("еквадор", "Топло", Difficulty.Medium, Language.Macedonian,Category.Geography),

                //Geography, hard, macedonian
                new Word("узбекистан", "Исток", Difficulty.Hard, Language.Macedonian,Category.Geography),
                new Word("пакистан", "Војна", Difficulty.Hard, Language.Macedonian,Category.Geography),

            };
            //Земи ги зборовите според избраните категории, јазикот и тежина на зборовите која ја избрал играчот.
            if (!categoriesCompleted)
            {
                Words = words.Where(x => x.Difficulty == Game.Difficulty && x.Language == Game.Language && Game.Categories.Contains(x.Category)).ToList();
            }
            else
            {
                //Ако ги завршил избраните категории..земи ги зборовите од останатите категории;
                Words = words.Where(x => x.Difficulty == Game.Difficulty && x.Language == Game.Language && !Game.Categories.Contains(x.Category)).ToList();
            }
        }
    }
}
