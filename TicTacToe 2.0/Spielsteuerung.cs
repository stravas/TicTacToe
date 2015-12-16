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
        public bool Runde = true;
        int RundenZaehler = 1;
        public Spieler SpielerEins;
        public Spieler SpielerZwei;

        public Spielsteuerung()
        {
            SpielerEins = new Spieler();
            SpielerEins.Priorität = 1;
            SpielerEins.ZellenPinsel = new SolidBrush(Color.Green);
            SpielerEins.Name = "s1";

            SpielerZwei = new Spieler();
            SpielerZwei.Priorität = 2;
            SpielerZwei.ZellenPinsel = new SolidBrush(Color.Red);
            SpielerZwei.Name = "s2";
        }

        public bool gewinnerPruefung(Zelle[,] matrix)
        {
            bool Gewonnen = false;
            // int count

            //horizontale checks
            if ((matrix[0, 0].Spieler.Priorität == matrix[0, 1].Spieler.Priorität) && (matrix[0, 1].Spieler.Priorität == matrix[0, 2].Spieler.Priorität) && (matrix[0, 0].Spieler.Priorität != 0))
                Gewonnen = true;
            else if ((matrix[1, 0].Spieler.Priorität == matrix[1, 1].Spieler.Priorität) && (matrix[1, 1].Spieler.Priorität == matrix[1, 2].Spieler.Priorität) && (matrix[1, 0].Spieler.Priorität != 0))
                Gewonnen = true;
            else if ((matrix[2, 0].Spieler.Priorität == matrix[2, 1].Spieler.Priorität) && (matrix[2, 1].Spieler.Priorität == matrix[2, 2].Spieler.Priorität) && (matrix[2, 0].Spieler.Priorität != 0))
                Gewonnen = true;

            //vertikale checks
            else if ((matrix[0, 0].Spieler.Priorität == matrix[1, 0].Spieler.Priorität) && (matrix[1, 0].Spieler.Priorität == matrix[2, 0].Spieler.Priorität) && (matrix[0, 0].Spieler.Priorität != 0))
                Gewonnen = true;
            else if ((matrix[0, 1].Spieler.Priorität == matrix[1, 1].Spieler.Priorität) && (matrix[1, 1].Spieler.Priorität == matrix[2, 1].Spieler.Priorität) && (matrix[0, 1].Spieler.Priorität != 0))
                Gewonnen = true;
            else if ((matrix[0, 2].Spieler.Priorität == matrix[1, 2].Spieler.Priorität) && (matrix[1, 2].Spieler.Priorität == matrix[2, 2].Spieler.Priorität) && (matrix[0, 2].Spieler.Priorität != 0))
                Gewonnen = true;

            //diagonale checks
            if ((matrix[0, 0].Spieler == matrix[1, 1].Spieler) && (matrix[1, 1].Spieler == matrix[2, 2].Spieler) && (matrix[0, 0].Spieler.Priorität != 0))
                Gewonnen = true;
            else if ((matrix[0, 2].Spieler == matrix[1, 1].Spieler) && (matrix[1, 1].Spieler == matrix[2, 0].Spieler) && (matrix[0, 2].Spieler.Priorität != 0))
                Gewonnen = true;


            /* for (int x = 0; x <= 2; x++)
           {
               for (int y = 0; y <= 2; y++)
               {
                   if ((Matrix[x, y].Spieler == Matrix[x, y].Spieler) && (Matrix[x, y].Spieler == Matrix[x, y].Spieler)
                       || (Matrix[y, x].Spieler == Matrix[y, x].Spieler) && (Matrix[y, x].Spieler == Matrix[y, x].Spieler))
                   {
                       return ;
                   }

               }
           }*/

            //check fuer Gleichstand
            /*if (count == 9)
                MessageBox.Show("Draw!");
            return true;*/


            return Gewonnen;
        }

        public void welcherSpieler(Zelle zelle)
        {
            zelle.geklickt = true;

            if (Runde)
            {
                zelle.Spieler = this.SpielerEins;
                zelle.StandardZellenPinsel.Color = this.SpielerEins.ZellenPinsel.Color;
            }

            else
            {
                zelle.Spieler = this.SpielerZwei;
                zelle.StandardZellenPinsel.Color = this.SpielerZwei.ZellenPinsel.Color;
            }


            Runde = !Runde;

        }

        public string[] rundenChecker(Zelle zelle, Spielfeld spielfeld)
        {
            string[] RückgabeArray = { "false", "error", "error"};

            if (zelle != null && zelle.geklickt == false)
            {
                this.welcherSpieler(zelle);

                if (RundenZaehler < 9)
                {
                    if (this.gewinnerPruefung(spielfeld.Matrix) == true)
                    {
                        //Hier wird zu früh resetet LETZTES FELD WIRD NICHT ANGEZEIGT

                        RundenZaehler = 1;

                        RückgabeArray[0] = "true";
                        RückgabeArray[1] = "Sieg";
                        RückgabeArray[2] = zelle.Spieler.Name;

                        return RückgabeArray;
                    }
                    RundenZaehler++;

                }
                else
                {
                    //MessageBox.Show("Unentschieden!!");

                    RundenZaehler = 1;

                    RückgabeArray[0] = "true";
                    RückgabeArray[1] = "Unentschieden";

                    return RückgabeArray;

                }
            }
            return RückgabeArray;
        }




    }
}
