using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_2._0
{
    class Spieler
    {
        public Spieler()
        {
        }

        public string Name;
        public SolidBrush zellBrush = new SolidBrush(Color.White);
        public int Priorität = 0;




        /**
        public Color Farbe
        {
            //set the person name
            set { this._Farbe = value; }
            //get the person name
            get { return this._Farbe; }
        }
        **/
    }
}
