using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe_2._0
{
    public partial class SpielStatistikBS : UserControl
    {


        public SpielStatistikBS()
        {
            InitializeComponent();
            DoubleBuffered = true;


        }

        //Spieler Namen
        public void aktualisiereSpielerEinsName(String name)
        {
            this.Spieler1Label.Text = name;
        }
        public void aktualisiereSpielerZweiName(String name)
        {
            this.Spieler2Label.Text = name;
        }

        //Punkte der Spieler
        public void aktualisiereSpielerEinsSiege(int punkte)
        {
            this.PunkteLabelSpieler1.Text = Convert.ToString(punkte);
        }
        public void aktualisiereSpielerZweiSiege(int punkte)
        {
            this.PunkteLabelSpieler2.Text = Convert.ToString(punkte);
        }

        //Runden Anzeige
        public void aktualisiereRundenAnzahl(int runden)
        {
            this.RundenLabel.Text = Convert.ToString(runden);
        }


        //Spieler Namen
        public string holeSpielerEinsName()
        {
            return Spieler1Label.Text;

        }
        public string holeSpielerZweiName()
        {
            return Spieler2Label.Text;

        }

        //Punkte der Spieler
        public int holeSpielerEinsSiege()
        {
            int var = Convert.ToInt32(this.PunkteLabelSpieler1.Text);

            return var;
        }
        public int holeSpielerZweiSiege()
        {
            int var = Convert.ToInt32(this.PunkteLabelSpieler2.Text);

            return var;
        }

        //Runden Anzeige
        public int holeRundenAnzahl()
        {
            int var = Convert.ToInt32(this.RundenLabel.Text);
            return var;
        }

        //Hilfsmethoden

        public void fokusSpielerEins()
        {
            Spieler2Label.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Spieler1Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        }

        public void fokusSpielerZwei()
        {
            Spieler1Label.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Spieler2Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        }

    }
}
