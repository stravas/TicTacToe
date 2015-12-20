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
        private void ZeichneSpielfeldNeu(object sender, PaintEventArgs e)
        {
            reguliereFontGroesseSpielerZugAnzeige();
            Spielfeld.zeichneSpielfeld(e.Graphics, this.ClientSize.Width, this.ClientSize.Height);
            zentrierResulatatLabelErgebnisflaeche();

        }

        private void MausFormKlick(object sender, MouseEventArgs e)
        {
            string[] auswertungsErgebnis = new string[3];

            Zelle zelle = Spielfeld.welcheZelle(e.Location);
            wechselSpielerZugAnzeige(zelle);

            auswertungsErgebnis = Spielsteuerung.rundenAuswertung(zelle, Spielfeld);

            //Diese Funktion Wertet die Ergebnisse der Funktion rundenChecker aus und gibt dann die View weiter
            this.auswertungRundenChecker(auswertungsErgebnis);
            this.Refresh();


        }

        private void SpielStartButtonClick(object sender, EventArgs e)
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


            wechselZurSpielfläche();
        }
        private void NeueRundeButtonKlick(object sender, EventArgs e)
        {
            this.Spielfeld.feldReset();
            resultatPanel.Visible = false;
            this.Refresh();
        }

        private void wechselZurSpielfläche()
        {
            startPanel.Visible = false;
           // spielStatistikBS1.Visible = true;
            hintergrundPanel.Visible = false;
        }

        private void neuesSpielMenueLeisteKlick(object sender, EventArgs e)
        {
            this.resultatPanel.Visible = false;
            this.Spielfeld.feldReset();
            startPanel.Visible = true;
            hintergrundPanel.Visible = true;
        }
        private void beenden_MenueLeiste_Klick(object sender, EventArgs e)
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
        private void wechselSpielerZugAnzeige(Zelle zelle)
        {
            if (zelle != null && zelle.geklickt == false)
            {
                this.wechselSpielerZugAnzeige();

            }
        }
        private void auswertungRundenChecker(string[] SpielDatenArray)
        {

            if (SpielDatenArray[0] == "true")
            {
                wechselZuErgebnisOberfläche();
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

                int startPunktX = (ClientSize.Width / 2 - resultatLabel.Width / 2);
                int startPunktY = ClientSize.Height / 10;
                this.resultatLabel.Location = new System.Drawing.Point(startPunktX, startPunktY);
            }


        }

        private void wechselZuErgebnisOberfläche()
        {
            this.resultatPanel.Visible = true;
        }

        public void wechselSpielerZugAnzeige()
        {
            if (this.Spielsteuerung.Zug)
            {
                //Spieler1Fokus
            }
            else
            {
                //Spieler2Fokus
            }
        }

        //Hilfsmethoden
        public void reguliereFontGroesseSpielerZugAnzeige()
        {
            int height = this.ClientSize.Height;
            int width = this.ClientSize.Width;
            int fontGroese = height + width;
            fontGroese = fontGroese / 70;
            //SpielerZugAnzeigeText

        }
        public void zentrierResulatatLabelErgebnisflaeche()
        {
            resultatLabel.Width = this.Width / 2 - resultatLabel.Width / 2 - resultatLabel.Text.Length / 2;
        }
        private void verhinderSelbenNamen(object sender, EventArgs e)
        {
            if (Spieler1TextBox == Spieler2TextBox && Spieler1TextBox.Text != "" && Spieler2TextBox.Text != "")
            {
                SpielStartenButton.Enabled = false;
            }
        }
        public void setzeSpielerPunkte(String Spielername)
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

    }
}
