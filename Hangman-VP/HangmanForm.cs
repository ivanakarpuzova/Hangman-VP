using Hangman.Models;
using Hangman_VP.Models;
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
    public partial class HangmanForm : Form
    {
        public Game Game { get; set; }

        public List<Word> Words { get; set; }
        public List<Word> Word { get; set; }
        public int Mistakes { get; set; }

        public HangmanForm(Game game)
        {
            InitializeComponent();

            Game = game;
        }

        //Функција која го прикажува човекот и бесилката
        private void DisplayHangmanAndBase()
        {
            BasePictureBox.ImageLocation = @"Images\base.png";
            hangmanHead.ImageLocation = @"Images\hangman-1.png";
            hangmanBody.ImageLocation = @"Images\hangman-2.png";
            hangmanLeftArm.ImageLocation = @"Images\hangman-3.png";
            hangmanRightArm.ImageLocation = @"Images\hangman-4.png";
            hangmanLeftLeg.ImageLocation = @"Images\hangman-5.png";
            hangmanRightLeg.ImageLocation = @"Images\hangman-6.png";
        }

        //Функција која ги генерира зборовите и ги сместува во листа - Words
        private void LoadWords()
        {
            Words = new List<Word>();
            List<Word> words = new List<Word>
            {
                //General, easy, english
                new Word("trees", "We need them for oxygen", Difficulty.Easy, Language.English, Category.General),
                new Word("guitar", "Instrument", Difficulty.Easy, Language.English, Category.General),
                new Word("bear", "Wild fuzzy animal", Difficulty.Easy, Language.English, Category.General),

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
            };

            Words = words;
        }

        //Функција која генерира random збор од листата - Words
        private void GenerateDisplayWord()
        {

        }
    }
}
