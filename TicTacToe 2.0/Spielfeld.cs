using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace TicTacToe_2._0
{
    class Spielfeld
    {
        Zelle[][] matrix = new Zelle[3][];

        public Spielfeld()
        {

        }

        private Zelle gebeZelleKoordinaten(Zelle zelle, int x, int y, int hoehe ,int breite)
        {
            zelle.x = x;
            zelle.y = y;
            zelle.hoehe = hoehe;
            zelle.breite = breite;

            return zelle;
        }

        private Zelle[][] berechneMatrix(int ClientWidth, int ClientHeight)
        {
            int zellenBreite = ClientWidth / 5;
            int zellenHoehe = ClientHeight / 5;
            for (int i = zellenBreite, x = 0; i <= ClientWidth - zellenBreite * 2; i += zellenBreite, x++)
            {
                for (int j = zellenHoehe, y = 0; j <= ClientHeight - zellenHoehe * 2; j += zellenHoehe, y++)
                {
                    matrix[x][y] = gebeZelleKoordinaten(matrix[x][y], i, j, zellenHoehe, zellenBreite);
                }
            }
            return matrix;
        }
        public void zeichneSpielfeld(Graphics g,  int ClientWidth, int ClientHeight)
        {
           Pen blackPen = new Pen(Color.Black);
            matrix = berechneMatrix(ClientWidth, ClientHeight); 
            for (int x = 0;x < 3; x++)
            {    
                for (int y = 0; y < 3; y++)
                {
                  g.DrawRectangle(blackPen, matrix[x][y].x, matrix[x][y].y, matrix[x][y].hoehe, matrix[x][y].breite);
              
                }
            }

        }
    }
}
