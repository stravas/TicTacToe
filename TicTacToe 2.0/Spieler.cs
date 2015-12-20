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
        public SolidBrush ZellenPinsel = new SolidBrush(Color.White);
        public int Id = 0;
        public string Figur = "";
        public int SpielSiege = 0;

    }
}
