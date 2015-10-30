using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        bool turn = true;
        int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";
            turn = !turn;
            count++;
            b.Enabled = false;
            check_for_winner();
        }

        private void check_for_winner()
        {
            bool has_win = false;
            
            //horizontale checks
            if ((button1.Text == button2.Text) && (button2.Text == button3.Text) && (!button1.Enabled))
                has_win = true;
            else if ((button4.Text == button5.Text) && (button5.Text == button6.Text) && (!button4.Enabled))
                has_win = true;
            else if ((button7.Text == button8.Text) && (button8.Text == button9.Text) && (!button7.Enabled))
                has_win = true;
            
            //vertikale checks
            else if ((button1.Text == button4.Text) && (button4.Text == button7.Text) && (!button1.Enabled))
                has_win = true;
            else if ((button2.Text == button8.Text) && (button5.Text == button8.Text) && (!button2.Enabled))
                has_win = true;
            else if ((button3.Text == button6.Text) && (button6.Text == button9.Text) && (!button3.Enabled))
                has_win = true;

            //diagonale checks
            else if ((button1.Text == button5.Text) && (button5.Text == button9.Text) && (!button1.Enabled))
                has_win = true;
            else if ((button7.Text == button5.Text) && (button5.Text == button3.Text) && (!button7.Enabled))
                has_win = true;

            if (has_win)
            {
                resetButtons();
                string winner = "";
                if (turn)
                    winner = "O";
                else
                    winner = "X";
                MessageBox.Show("Winner is " + winner);
            }
            else
            {
                if (count == 9)
                    MessageBox.Show("Draw!");
            }
                
        }

        public void resetButtons()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
            catch
            { }
        }

        private void exitClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void infoClick(object sender, EventArgs e)
        {
            MessageBox.Show("© by Adonis Thaci & Fabio Norbutat", "TicTacToe");
        }

        private void newGame(object sender, EventArgs e)
        {
            turn = false;
            count = 0;

            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
            }
            catch
            { }
        }
    }
}
