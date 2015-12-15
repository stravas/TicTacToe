using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace TicTacToe_2._0
{
    class Zelle
    {

        public SolidBrush zellBrush = new SolidBrush(Color.White);

        public Zelle()
        {

            this.Rectangle = new Rectangle();
            this.Spieler = new Spieler();

        }

        public Rectangle Rectangle;
        private Spieler _Spieler;
        public bool geklickt = false;

        public Spieler Spieler
        {
            //setze Spieler
            set { this._Spieler = value; }
            //hole Spieler
            get { return this._Spieler; }
        }



        //TODO: setDimensionRectangle
    }
}
