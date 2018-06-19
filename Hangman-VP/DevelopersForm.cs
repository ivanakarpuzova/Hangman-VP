using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class DevelopersForm : Form
    {
        public DevelopersForm()
        {
            InitializeComponent();
            this.Text = "Developers";
            DevelopedByLabel.Text = LanguageSettings.DevelopedByLabel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
