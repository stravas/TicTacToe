/**
 * Programm TicTacToe
 *
 * @author Fabio Norbutat
 * @author Adonis Thaci
 *
 * @date 2015-22-12
 *
 * @version 2.0
 * */
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
        public bool Zug = true;
        public int ZugZaehler = 1;
        public int RundenZaehler = 1;

        public Spieler SpielerEins;
        public Spieler SpielerZwei;

        //Wird die Spielsteuerung Initialisert so werden mit dem sofort 2 Spieler Objekte erstellt.
        //Dieser Spieler Objekte bekommen unterschiedliche werte zugewiesen wie ein Farb unterschied oder ungleiche namen.
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

        //Prüft das Matrix-Zellen Arrays ob es eine mögliche kombination von Siegen gibt.  
        //Hat wer gewonnen, so wid der boolean "Gewonnen" auf true gesetzt und gibt diesen zurück.
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

            return Gewonnen;
        }

        //Setzt in de Zelle die eigenschaft " geklickt" auf true damit diese object von außen nicht mehr ansprechbar ist und weist
        // der Zelle einen Spieler zu.
        public void welcherSpieler(Zelle zelle)
        {
            zelle.geklickt = true;
            setzeSpielerInZelle(zelle);
            wechselZug();

        }

        //Ändert den Zug
        private void wechselZug()
        {
            Zug = !Zug;
        }

        //Setzt der Zelle die als Parameter reingeladen wird einen Spieler zu, und ersetzt die Weiße default farbe einer Zelle mit der, des Spielers der Geklickt hat.
        //Fügt zu der eigenschaft "Spieler" in der Zelle ein Symbol Hinzu was dann angezeigt wird in der View.
        private void setzeSpielerInZelle(Zelle zelle)
        {
            if (Zug)
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
        }

        public string[] rundenAuswertung(Zelle geklickteZelle, Spielfeld spielfeld)
        {
            string[] ErgebnisArray = { "Rundenstatus", "Spielstatus", "Spielername"};

            if (geklickteZelle != null && geklickteZelle.geklickt == false)
            {
                this.welcherSpieler(geklickteZelle);

                if (ZugZaehler < 9)
                {
                    if (this.gewinnerPruefung(spielfeld.Matrix))
                    {
                        return hatGewonnen(geklickteZelle, ErgebnisArray);
                    }
                    ZugZaehler++;

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

        //gibt bei einem unentschieden ein unentschieden array raus
        private void istUntentschieden(string[] RückgabeArray)
        {
            ZugZaehler = 1;

            RückgabeArray[0] = "true";
            RückgabeArray[1] = "Unentschieden";
        }

        //gibt bei einem Sieg ein Sieg array raus
        private string[] hatGewonnen(Zelle zelle, string[] ErgebnisArray)
        {
            ZugZaehler = 1;

            ErgebnisArray[0] = "true";
            ErgebnisArray[1] = "Sieg";
            ErgebnisArray[2] = zelle.Spieler.Name;
            spielErgebnis(zelle.Spieler);

            return ErgebnisArray;
        }

        //Wenn keine werte in die textboxen im startpannel geschrieben werden so behalten die Spieler ihren default namen. Falls doch was geschrieben wird
        //bekommen sie den inhalt der textboxen
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
        //Erhöht nach einem Sieg die Eigenschafte "Spielsiege" in dem Spieler Objekt um 1
        public void spielErgebnis(Spieler spieler)
        {

                 spieler.SpielSiege++;

        }
    }
}
