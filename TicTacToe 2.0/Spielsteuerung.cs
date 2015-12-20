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
        public int RundenZaehler = 1;
        public int SitzungsZaehler = 1;

        public Spieler SpielerEins;
        public Spieler SpielerZwei;

        public Spielsteuerung()
        {
            SpielerEins = new Spieler();
            SpielerEins.Id = 1;
            SpielerEins.ZellenPinsel = new SolidBrush(Color.Green);
            SpielerEins.Name = "Spieler1";

            SpielerZwei = new Spieler();
            SpielerZwei.Id = 2;
            SpielerZwei.ZellenPinsel = new SolidBrush(Color.Red);
            SpielerZwei.Name = "Spieler2";
        }

        public bool gewinnerPruefung(Zelle[,] matrix)
        {
            bool Gewonnen = false;

            //horizontale checks
            if ((matrix[0, 0].Spieler.Id == matrix[0, 1].Spieler.Id) && (matrix[0, 1].Spieler.Id == matrix[0, 2].Spieler.Id) && (matrix[0, 0].Spieler.Id != 0))
                Gewonnen = true;
            else if ((matrix[1, 0].Spieler.Id == matrix[1, 1].Spieler.Id) && (matrix[1, 1].Spieler.Id == matrix[1, 2].Spieler.Id) && (matrix[1, 0].Spieler.Id != 0))
                Gewonnen = true;
            else if ((matrix[2, 0].Spieler.Id == matrix[2, 1].Spieler.Id) && (matrix[2, 1].Spieler.Id == matrix[2, 2].Spieler.Id) && (matrix[2, 0].Spieler.Id != 0))
                Gewonnen = true;

            //vertikale checks
            else if ((matrix[0, 0].Spieler.Id == matrix[1, 0].Spieler.Id) && (matrix[1, 0].Spieler.Id == matrix[2, 0].Spieler.Id) && (matrix[0, 0].Spieler.Id != 0))
                Gewonnen = true;
            else if ((matrix[0, 1].Spieler.Id == matrix[1, 1].Spieler.Id) && (matrix[1, 1].Spieler.Id == matrix[2, 1].Spieler.Id) && (matrix[0, 1].Spieler.Id != 0))
                Gewonnen = true;
            else if ((matrix[0, 2].Spieler.Id == matrix[1, 2].Spieler.Id) && (matrix[1, 2].Spieler.Id == matrix[2, 2].Spieler.Id) && (matrix[0, 2].Spieler.Id != 0))
                Gewonnen = true;

            //diagonale checks
            if ((matrix[0, 0].Spieler == matrix[1, 1].Spieler) && (matrix[1, 1].Spieler == matrix[2, 2].Spieler) && (matrix[0, 0].Spieler.Id != 0))
                Gewonnen = true;
            else if ((matrix[0, 2].Spieler == matrix[1, 1].Spieler) && (matrix[1, 1].Spieler == matrix[2, 0].Spieler) && (matrix[0, 2].Spieler.Id != 0))
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
                zelle.DefaultPinsel.Color = this.SpielerEins.ZellenPinsel.Color;
                zelle.Spieler.Figur = "X";
            }

            else
            {
                zelle.Spieler = this.SpielerZwei;
                zelle.DefaultPinsel.Color = this.SpielerZwei.ZellenPinsel.Color;
                zelle.Spieler.Figur = "O";
            }


            Runde = !Runde;

        }

        public string[] rundenAuswertung(Zelle geklickteZelle, Spielfeld spielfeld)
        {
            string[] ErgebnisArray = { "Rundenstatus", "Spielstatus", "Spielername"};

            if (geklickteZelle != null && geklickteZelle.geklickt == false)
            {
                this.welcherSpieler(geklickteZelle);

                if (RundenZaehler < 9)
                {
                    if (this.gewinnerPruefung(spielfeld.Matrix))
                    {
                        return hatGewonnen(geklickteZelle, ErgebnisArray);
                    }
                    RundenZaehler++;

                }
                else
                {

                    if (this.gewinnerPruefung(spielfeld.Matrix))
                    {

                        return hatGewonnen(geklickteZelle, ErgebnisArray);
                    }

                    istUntentschieden(ErgebnisArray);

                    return ErgebnisArray;

                }
            }
            return ErgebnisArray;
        }

        private void istUntentschieden(string[] RückgabeArray)
        {
            RundenZaehler = 1;

            RückgabeArray[0] = "true";
            RückgabeArray[1] = "Unentschieden";
        }

        private string[] hatGewonnen(Zelle zelle, string[] RückgabeArray)
        {
            RundenZaehler = 1;

            RückgabeArray[0] = "true";
            RückgabeArray[1] = "Sieg";
            RückgabeArray[2] = zelle.Spieler.Name;

            return RückgabeArray;
        }

        public void vergebeSpielername(string spieler1TextEngabe, string spieler2TextEngabe)
        {
            if (!string.IsNullOrEmpty(spieler1TextEngabe))
            {
                SpielerEins.Name = spieler1TextEngabe;
            }
            if (!string.IsNullOrEmpty(spieler2TextEngabe))
            {
                SpielerZwei.Name = spieler2TextEngabe;
            }

        }
    }
}
