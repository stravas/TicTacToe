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

        private string _Name;
        private Color _Farbe;

        public string Name
        {
            //set the gamers name
            set { this._Name = value; }
            //get the person name 
            get { return this._Name; }
        }

        public Color Farbe
        {
            //set the person name
            set { this._Farbe = value; }
            //get the person name 
            get { return this._Farbe; }
        }
    }
}
