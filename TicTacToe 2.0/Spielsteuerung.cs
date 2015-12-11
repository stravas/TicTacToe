using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_2._0
{
    class Spielsteuerung
    {
        private bool _Turn;

        public int count;


        public bool Turn
        {
            //set turn
            set { this._Turn = value; }
            //get turn
            get { return this._Turn; }
        }


        private void check_for_winner(Zelle matrix)
        {
            /*        bool has_win = false;

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
                        //check fuer Gleichstand
                        if (count == 9)
                            MessageBox.Show("Draw!");
                    }

                }

                public void resetButtons()*/
        }
    }
}
