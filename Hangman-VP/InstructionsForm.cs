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
    public partial class InstructionsForm : Form
    {
        public InstructionsForm()
        {
            InitializeComponent();

            WindowState = FormWindowState.Normal;
            this.Text = "Instrukcii";
            InstructionsLabel.Text = "Instrukcii";
            HangmanInstructionsLabel.Text = "Instrukcii";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
