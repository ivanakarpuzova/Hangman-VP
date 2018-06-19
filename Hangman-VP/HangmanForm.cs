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
        public HangmanForm()
        {
            InitializeComponent();

            BasePictureBox.ImageLocation = @"Images\base.png";
            hangmanHead.ImageLocation = @"Images\hangman-1.png";
            hangmanBody.ImageLocation = @"Images\hangman-2.png";
            hangmanLeftArm.ImageLocation = @"Images\hangman-3.png";
            hangmanRightArm.ImageLocation = @"Images\hangman-4.png";
            hangmanLeftLeg.ImageLocation = @"Images\hangman-5.png";
            hangmanRightLeg.ImageLocation = @"Images\hangman-6.png";
        }
    }
}
