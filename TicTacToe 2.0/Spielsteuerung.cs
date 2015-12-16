using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace TicTacToe_2._0
{
    class Spielsteuerung
    {
        private bool _Turn = true;

        public int count;

        public Spielsteuerung()
        {
            spielerEins = new Spieler();
            spielerEins.Priorität = 1;
            spielerEins.zellBrush = new SolidBrush(Color.Green);
            spielerEins.Name = "s1";

            spielerZwei = new Spieler();
            spielerZwei.Priorität = 2;
            spielerZwei.zellBrush = new SolidBrush(Color.Red);
            spielerZwei.Name = "s2";
        }

        public Spieler spielerEins;
        public Spieler spielerZwei;

        public bool Turn
        {
            //set turn
            set { this._Turn = value; }
            //get turn
            get { return this._Turn; }
        }


        public bool check_for_winner(Zelle[,] matrix)
        {
            bool has_win = false;
           // int count



             //horizontale checks
             if ((matrix[0, 0].Spieler.Priorität == matrix[0, 1].Spieler.Priorität) && (matrix[0, 1].Spieler.Priorität == matrix[0, 2].Spieler.Priorität) && (matrix[0, 0].Spieler.Priorität != 0))
                 has_win = true;
             else if ((matrix[1, 0].Spieler.Priorität == matrix[1, 1].Spieler.Priorität) && (matrix[1, 1].Spieler.Priorität == matrix[1, 2].Spieler.Priorität) && (matrix[1, 0].Spieler.Priorität != 0))
                 has_win = true;
             else if ((matrix[2, 0].Spieler.Priorität == matrix[2, 1].Spieler.Priorität) && (matrix[2, 1].Spieler.Priorität == matrix[2, 2].Spieler.Priorität) && (matrix[2, 0].Spieler.Priorität != 0))
                 has_win = true;

             //vertikale checks
             else if ((matrix[0, 0].Spieler.Priorität == matrix[1, 0].Spieler.Priorität) && (matrix[1, 0].Spieler.Priorität == matrix[2, 0].Spieler.Priorität) && (matrix[0, 0].Spieler.Priorität != 0))
                 has_win = true;
             else if ((matrix[0, 1].Spieler.Priorität == matrix[1, 1].Spieler.Priorität) && (matrix[1, 1].Spieler.Priorität == matrix[2, 1].Spieler.Priorität) && (matrix[0, 1].Spieler.Priorität != 0))
                 has_win = true;
             else if ((matrix[0, 2].Spieler.Priorität == matrix[1, 2].Spieler.Priorität) && (matrix[1, 2].Spieler.Priorität == matrix[2, 2].Spieler.Priorität) && (matrix[0, 2].Spieler.Priorität != 0))
                 has_win = true;

            //diagonale checks
            if ((matrix[0, 0].Spieler == matrix[1, 1].Spieler) && (matrix[1, 1].Spieler == matrix[2, 2].Spieler) && (matrix[0, 0].Spieler.Priorität != 0))
                has_win = true;
            else if ((matrix[0, 2].Spieler == matrix[1, 1].Spieler) && (matrix[1, 1].Spieler == matrix[2, 0].Spieler) && (matrix[0, 2].Spieler.Priorität != 0))
                has_win = true;


            /* for (int x = 0; x <= 2; x++)
           {
               for (int y = 0; y <= 2; y++)
               {
                   if ((matrix[x, y].Spieler == matrix[x, y].Spieler) && (matrix[x, y].Spieler == matrix[x, y].Spieler)
                       || (matrix[y, x].Spieler == matrix[y, x].Spieler) && (matrix[y, x].Spieler == matrix[y, x].Spieler))
                   {
                       return ;
                   }

               }
           }*/

            //check fuer Gleichstand
            /*if (count == 9)
                MessageBox.Show("Draw!");
            return true;*/


            return has_win;
        }

        public int welcherSpieler(Zelle zelle)
        {
            zelle.geklickt = true;

            if (Turn)
            {
                zelle.Spieler = this.spielerEins;
                zelle.zellBrush.Color = this.spielerEins.zellBrush.Color;
                Turn = !Turn;
                return this.spielerEins.Priorität;
            }

            else
            {
                zelle.Spieler = this.spielerZwei;
                zelle.zellBrush.Color = this.spielerZwei.zellBrush.Color;
                Turn = !Turn;
                return this.spielerZwei.Priorität;
            }


            

        }

        public void resetButtons()
        {

        }
    }
}
