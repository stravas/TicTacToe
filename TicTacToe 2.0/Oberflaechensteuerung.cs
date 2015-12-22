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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe_2._0
{
    public partial class Form1 : Form
    {

        private Spielfeld Spielfeld = null;
        private Spielsteuerung Spielsteuerung = new Spielsteuerung();


        public Form1()
        {
            InitializeComponent();
            Controls.Add(spielStatistikBS1);


        }

        //Initialsiert alle nötigen Events und Einstellungen der Form
        private void FormLoad(object sender, EventArgs e)
        {
            //Optionen
            this.ResizeRedraw = true;
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(700, 550);

            //Hintergrund von dem startPanel auf alle andere Panels und auf die Form übertragen
            this.hintergrundPanel.BackColor = this.startPanel.BackColor;
            this.BackColor = this.startPanel.BackColor;

            //Spielfeld
            this.Spielfeld = new Spielfeld();
            this.Paint += new PaintEventHandler(ZeichneSpielfeldNeu);
            this.MouseClick += new MouseEventHandler(MausFormKlick);
            this.FormClosing += new FormClosingEventHandler(schliesseForm);
        }

        //Ein Resize Event das bei jeder Größen änderung der Form angesprochen wird. Diese Funktion Zeichnet das Feld optimiert zur aktuellen Form größe neu
        private void ZeichneSpielfeldNeu(object sender, PaintEventArgs e)
        {
            reguliereFontGroesseSpielerZugAnzeige();
            Spielfeld.zeichneSpielfeld(e.Graphics, this.ClientSize.Width, this.ClientSize.Height);
            zentrierResulatatLabelErgebnisflaeche();
            ankerZuSpielfeld();

        }

        //Ein Klick event was jedes mal ausgeführt wird wenn auf die Form geklickt wird. Speziell ist hier das nur was Passiert wenn eine Zelle angesprochen wird
        private void MausFormKlick(object sender, MouseEventArgs e)
        {
            string[] auswertungsErgebnis = new string[3];

            Zelle zelle = Spielfeld.welcheZelle(e.Location);
            wechselSpielerZugAnzeige(zelle);
            auswertungsErgebnis = Spielsteuerung.rundenAuswertung(zelle, Spielfeld);
            //Diese Funktion Wertet die Ergebnisse der Funktion rundenChecker aus und gibt dann die View weiter
            this.verarbeiteRundenAuswertungsErgebnis(auswertungsErgebnis);
            this.Refresh();


        }
        //Ein Button Event das dass Spiel zum Starten bringt.
        private void SpielStartButtonKlick(object sender, EventArgs e)
        {
            Spielsteuerung.vergebeSpielername(Spieler1TextBox.Text, Spieler2TextBox.Text);

            //<!--Methode-->
            //SpielerNamen
            spielStatistikBS1.aktualisiereSpielerEinsName(Spielsteuerung.SpielerEins.Name);
            spielStatistikBS1.aktualisiereSpielerZweiName(Spielsteuerung.SpielerZwei.Name);

            //Runden Siege
            Spielsteuerung.SpielerEins.SpielSiege = 0;
            spielStatistikBS1.aktualisiereSpielerEinsSiege(0);
            Spielsteuerung.SpielerZwei.SpielSiege = 0;
            spielStatistikBS1.aktualisiereSpielerZweiSiege(0);

            //Spieler Runden
            Spielsteuerung.RundenZaehler = 0;
            spielStatistikBS1.aktualisiereRundenAnzahl(0);
            spielStatistikBS1.fokusSpielerEins();

            wechselZurSpielfläche();
        }

        //Ein klick event das, dass Feld zurücksetzt und ein neues Spiel anleitet
        private void NeueRundeButtonKlick(object sender, EventArgs e)
        {
            this.Spielfeld.feldReset();
            resultatPanel.Visible = false;
            this.Refresh();
        }

        
        private void neuesSpielMenueLeisteKlick(object sender, EventArgs e)
        {
            this.resultatPanel.Visible = false;
            this.Spielfeld.feldReset();
            Spielsteuerung.Zug = true;
            startPanel.Visible = true;
            hintergrundPanel.Visible = true;
        }
        private void beendenMenueLeisteKlick(object sender, EventArgs e)
        {

            if (MessageBox.Show("Soll das Programm wirklich beendet werden?",
                               "Beenden", MessageBoxButtons.OKCancel,
                                 MessageBoxIcon.Question) == DialogResult.OK)
                Environment.Exit(0);

        }
        private void schliesseForm(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Soll das Programm wirklich beendet werden?",
                              "Beenden", MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Question) == DialogResult.Cancel)
                e.Cancel = true;
        }

        //Verarbeitet die ergebnisse durch die Klicks auf die Felder und gibt ein Runden Beendet Label aus falls es auftritt
        private void verarbeiteRundenAuswertungsErgebnis(string[] SpielDatenArray)
        {

            if (SpielDatenArray[0] == "true")
            {

                Spielsteuerung.RundenZaehler++;
                spielStatistikBS1.aktualisiereRundenAnzahl(Spielsteuerung.RundenZaehler);


                if (SpielDatenArray[1] == "Sieg")
                {
                    setzeSpielerPunkte(SpielDatenArray[2]);
                    string resultat = String.Format("Gewonnen hat Spieler: {0}", SpielDatenArray[2]);
                    this.resultatLabel.Text = resultat;

                }
                else
                {
                    this.resultatLabel.Text = "Unentschieden!";
                }

                wechselZuErgebnisOberfläche();

                int startPunktX = (ClientSize.Width / 2 - resultatLabel.Width / 2);
                int startPunktY = ClientSize.Height / 10;
                this.resultatLabel.Location = new System.Drawing.Point(startPunktX, startPunktY);
            }


        }
        private void setzeSpielerPunkte(String Spielername)
        {
            if (Spielsteuerung.SpielerEins.Name == Spielername)
            {
                spielStatistikBS1.aktualisiereSpielerEinsSiege(Spielsteuerung.SpielerEins.SpielSiege);
            }
            else
            {
                spielStatistikBS1.aktualisiereSpielerZweiSiege(Spielsteuerung.SpielerZwei.SpielSiege);
            }
        }

        private void wechselSpielerZugAnzeige(Zelle zelle)
        {
            if (zelle != null && zelle.geklickt == false)
            {
                if (this.Spielsteuerung.Zug)
                {
                    spielStatistikBS1.fokusSpielerZwei();
                }
                else
                {
                    spielStatistikBS1.fokusSpielerEins();
                }

            }
        }
        private void wechselZurSpielfläche()
        {
            startPanel.Visible = false;
            // spielStatistikBS1.Visible = true;

            hintergrundPanel.Visible = false;
        }
        private void wechselZuErgebnisOberfläche()
        {
            synchSpielStatistik();
            spielStatistikBS1.Visible = true;
            this.resultatPanel.Visible = true;
        }

        //Hilfsmethoden
        private void synchSpielStatistik()
        {
            spielStatistikBS2.aktualisiereSpielerEinsName(spielStatistikBS1.holeSpielerEinsName());
            spielStatistikBS2.aktualisiereSpielerZweiName(spielStatistikBS1.holeSpielerZweiName());

            spielStatistikBS2.aktualisiereSpielerEinsSiege(spielStatistikBS1.holeSpielerEinsSiege());
            spielStatistikBS2.aktualisiereSpielerZweiSiege(spielStatistikBS1.holeSpielerZweiSiege());

            spielStatistikBS2.aktualisiereRundenAnzahl(spielStatistikBS1.holeRundenAnzahl());
        }
        private void ankerZuSpielfeld()
        {
            int x = Spielfeld.Matrix[2, 0].Rectangle.X + Spielfeld.Matrix[2, 0].Rectangle.Width + 50;
            //int x = Convert.ToInt16((double)Spielfeld.Matrix[2, 0].Rectangle.X * 1.5);
            spielStatistikBS1.Location = new Point(x, Spielfeld.Matrix[2, 0].Rectangle.Y);

        }
        private void reguliereFontGroesseSpielerZugAnzeige()
        {
            int height = this.ClientSize.Height;
            int width = this.ClientSize.Width;
            int fontGroese = height + width;
            fontGroese = fontGroese / 70;
            //SpielerZugAnzeigeText

        }

        //Setzt das Statistik Board immer 50px Rechts von dem gezeichnetem Spielfeld
        private void zentrierResulatatLabelErgebnisflaeche()
        {
            resultatLabel.Width = this.Width / 2 - resultatLabel.Width / 2 - resultatLabel.Text.Length / 2;
        }

        private void aboutMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TicTacToe Applikation in C#"  + "\n" + "\n" + "Von Adonis Thaci und Fabio Norbutat" + "\n" + "GSO FIA41 Köln/Cologne" + "\n" + "\n" + "Code auf github.com/stravas/TicTacToe ", "Über");
        }

    }
}
