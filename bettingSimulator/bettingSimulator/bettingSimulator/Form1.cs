using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bettingSimulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gamePicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(gamePicker.SelectedIndex == 0)//Powerball
            {
                gameElement1.Text = "";
                gameElement2.Text = "";
                gameElement4.Text = "";
                gameElement5.Text = "";
                instructionLabel.Text = "Enter your number.";
                commitButton.Text = "ROLL";
            }
            else if(gamePicker.SelectedIndex == 1)//Poker
            {
                instructionLabel.Text = "Make your bet.";
                commitButton.Text = "Score";
            }
            else if(gamePicker.SelectedIndex == 2)//Horse Racing
            {
                instructionLabel.Text = "Choose your horse and make a bet.";
                commitButton.Text = "RACE";
            }
        }
    }
}
