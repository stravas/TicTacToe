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
            this.ResizeRedraw = true;
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(550, 550);

            //Hintergrund von dem startPanel auf alle andere Panels und auf die Form übertragen
            this.hintergrundPanel.BackColor = this.startPanel.BackColor;
            this.BackColor = this.startPanel.BackColor;

            //Spielfeld
            this.Spielfeld = new Spielfeld();
            this.Paint += new PaintEventHandler(ResizeFormPaint);
            this.MouseClick += new MouseEventHandler(MouseOnFormClick);
        }
        private void ResizeFormPaint(object sender, PaintEventArgs e)
        {
            reguliereFontGroesse();
            Spielfeld.zeichneSpielfeld(e.Graphics, this.ClientSize.Width, this.ClientSize.Height);
            reguliertZentrierungLabelImPanel();

        }

        private void MouseOnFormClick(object sender, MouseEventArgs e)
        {
            Zelle zelle = Spielfeld.welcheZelle(e.Location);
            if(zelle != null && zelle.geklickt == false)
            {
                this.spielerAnzeigeRotationImLabelMomentanerSpieler();

            }

            string[] RückgabeArray = new string[3];

            RückgabeArray = Spielsteuerung.rundenChecker(zelle, Spielfeld);

            //Diese Funktion Wertet die Ergebnisse der Funktion rundenChecker aus und gibt dann die View Weiter
            this.auswertungRundenChecker(RückgabeArray);
            this.Refresh();


        }

        private void spielStart_button1_Click(object sender, EventArgs e)
        {
            this.Spielsteuerung.SpielerEins.Name = textBox1.Text;
            this.Spielsteuerung.SpielerZwei.Name = textBox2.Text;


            if (String.IsNullOrEmpty(this.Spielsteuerung.SpielerEins.Name))
            {
                this.Spielsteuerung.SpielerEins.Name = "Spieler1";
            }

            if (String.IsNullOrEmpty(this.Spielsteuerung.SpielerZwei.Name))
            {
                this.Spielsteuerung.SpielerZwei.Name = "Spieler2";
            }

            this.setzeErstenSpielerNameImLabelMomentanerSpieler();
            this.momentanerSpieler.Visible = true;
            startPanel.Visible = false;
            hintergrundPanel.Visible = false;
            //hintergrundPanel.Visible = false;
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
        private void neuesSpiel_MenueLeiste_Klick(object sender, EventArgs e)
        {
            this.resultatPanel.Visible = false;
            this.Spielfeld.feldReset();
            startPanel.Visible = true;
            hintergrundPanel.Visible = true;
            this.momentanerSpieler.Visible = false;
            //hintergrundPanel.Visible = true;
        }

        private void auswertungRundenChecker(string [] SpielDatenArray)
        {
            this.Refresh();
            if (SpielDatenArray[0] == "true")
            {
                this.resultatPanel.Visible = true;
                momentanerSpieler.Visible = false;

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

        public void setzeErstenSpielerNameImLabelMomentanerSpieler()
        {
            this.momentanerSpieler.Text = Spielsteuerung.SpielerEins.Name;
            this.momentanerSpieler.ForeColor = Color.Green;
        }
        public void spielerAnzeigeRotationImLabelMomentanerSpieler()
        {
            if(this.Spielsteuerung.Runde == true)
            {
                this.momentanerSpieler.Text = Spielsteuerung.SpielerZwei.Name;
                this.momentanerSpieler.ForeColor = Color.Red;
            } else
            if (this.Spielsteuerung.Runde == false)
            {
                this.momentanerSpieler.Text = Spielsteuerung.SpielerEins.Name;
                this.momentanerSpieler.ForeColor = Color.Green;
            }
        }

        public void reguliereFontGroesse()
        {
           int height = this.ClientSize.Height;
           int width =  this.ClientSize.Width;
           int fontGroese = height + width;
           fontGroese = fontGroese /70;

           this.momentanerSpieler.Font = new Font("Impact", fontGroese);

        }
        public void reguliertZentrierungLabelImPanel()
        {
            resultatLabel.Width = this.Width / 2 - resultatLabel.Width / 2 - resultatLabel.Text.Length / 2;
        }

        private void neueRunde_Click(object sender, EventArgs e)
        {
            this.Spielfeld.feldReset();
            resultatPanel.Visible = false;
            momentanerSpieler.Visible = true;
            this.Refresh();
        }
    }
}
