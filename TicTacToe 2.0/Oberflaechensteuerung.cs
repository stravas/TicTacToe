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

        }

        private void FormLoad(object sender, EventArgs e)
        {
            //Optionen
            this.ResizeRedraw = true;
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(550, 550);

            //Hintergrund von dem startPanel auf alle andere Panels und auf die Form übertragen
            this.hintergrundPanel.BackColor = this.startPanel.BackColor;
            this.BackColor = this.startPanel.BackColor;

            //Spielfeld
            this.Spielfeld = new Spielfeld();
            this.Paint += new PaintEventHandler(ZeichneSpielfeldNeu);
            this.MouseClick += new MouseEventHandler(MausFormKlick);
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
            wechselZurSpielfläche();
        }
        private void NeueRundeButtonKlick(object sender, EventArgs e)
        {
            this.Spielfeld.feldReset();
            resultatPanel.Visible = false;
            spielerZugAnzeige.Visible = true;
            this.Refresh();
        }

        private void wechselZurSpielfläche()
        {
            this.setzeErstenSpielerNameImLabelMomentanerSpieler();
            this.spielerZugAnzeige.Visible = true;
            startPanel.Visible = false;
            hintergrundPanel.Visible = false;
        }

        private void neuesSpielMenueLeisteKlick(object sender, EventArgs e)
        {
            this.resultatPanel.Visible = false;
            this.Spielfeld.feldReset();
            startPanel.Visible = true;
            hintergrundPanel.Visible = true;
            this.spielerZugAnzeige.Visible = false;
            //hintergrundPanel.Visible = true;
        }
        private void beenden_MenueLeiste_Klick(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Möchten Sie das Spiel wirklich beenden?", "Beenden", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Environment.Exit(0);
            }
            else
            {
                //e.Cancel = true;
            }

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

                if (SpielDatenArray[1] == "Sieg")
                {

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
            spielerZugAnzeige.Visible = false;
        }

        public void setzeErstenSpielerNameImLabelMomentanerSpieler()
        {
            this.spielerZugAnzeige.Text = Spielsteuerung.SpielerEins.Name;
            this.spielerZugAnzeige.ForeColor = Color.Green;
        }
        public void wechselSpielerZugAnzeige()
        {
            if (this.Spielsteuerung.Runde)
            {
                this.spielerZugAnzeige.Text = Spielsteuerung.SpielerZwei.Name;
                this.spielerZugAnzeige.ForeColor = Spielsteuerung.SpielerZwei.ZellenPinsel.Color;
            }
            else
            {
                this.spielerZugAnzeige.Text = Spielsteuerung.SpielerEins.Name;
                this.spielerZugAnzeige.ForeColor = Spielsteuerung.SpielerEins.ZellenPinsel.Color;
            }
        }



        //Hilfsmethoden
        public void reguliereFontGroesseSpielerZugAnzeige()
        {
            int height = this.ClientSize.Height;
            int width = this.ClientSize.Width;
            int fontGroese = height + width;
            fontGroese = fontGroese / 70;

            this.spielerZugAnzeige.Font = new Font("Impact", fontGroese);

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
    }
}
