/**
 * Programm TicTacToe
 *
 * @author Fabio Norbutat
 * @author Adonis Thaci
 *
 * @date 2015-22-12
 *
 * @version 2.0
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace TicTacToe_2._0
{
    //Zellen Model
    class Zelle
    {

        public Rectangle Rectangle;
        public Spieler Spieler;
        public bool geklickt = false;
        public SolidBrush DefaultPinsel = new SolidBrush(Color.White);

        
        public Zelle()
        {
            this.Rectangle = new Rectangle();
            this.Spieler = new Spieler();

        }

    }
}
