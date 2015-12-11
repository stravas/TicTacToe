using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_2._0
{
    class Zelle
    {
        private Spieler _Spieler;
        private int _X;
        private int _Y;
        private int _Hoehe;
        private int _Breite;

        public Spieler Spieler
        {
            //setze Spieler
            set { this._Spieler = value; }
            //hole Spieler
            get { return this._Spieler; }
        }

        public int x
        {
            //setze Spieler
            set { this._X = value; }
            //hole Spieler
            get { return this._X; }
        }

        public int y
        {
            //setze Spieler
            set { this._Y = value; }
            //hole Spieler
            get { return this._Y; }
        }

        public int hoehe
        {
            //setze Spieler
            set { this._Hoehe = value; }
            //hole Spieler
            get { return this._Hoehe; }
        }

        public int breite
        {
            //setze Spieler
            set { this._Breite = value; }
            //hole Spieler
            get { return this._Breite; }
        }
    }
}
