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

    }
}
