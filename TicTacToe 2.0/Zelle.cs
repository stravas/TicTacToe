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

        public Zelle()
        {

            this.Rectangle = new Rectangle();

        }

        public Rectangle Rectangle;
        private Spieler _Spieler;

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
