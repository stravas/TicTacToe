﻿using System;
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
        Zelle[,] matrix = new Zelle[3,3];

        public Spielfeld()
        {
            this.matrix[0, 0] = new Zelle();
            this.matrix[0, 1] = new Zelle();
            this.matrix[0, 2] = new Zelle();

            this.matrix[1, 0] = new Zelle();
            this.matrix[1, 1] = new Zelle();
            this.matrix[1, 2] = new Zelle();

            this.matrix[2, 0] = new Zelle();
            this.matrix[2, 1] = new Zelle();
            this.matrix[2, 2] = new Zelle();
        }

        private void gebeZelleKoordinaten(Zelle zelle, int x, int y, int breite ,int hoehe)
        {
            zelle.Rectangle.X = x;
            zelle.Rectangle.Y = y;
            zelle.Rectangle.Height = hoehe;
            zelle.Rectangle.Width = breite;
        }

        private Zelle[,] berechneMatrix(int ClientWidth, int ClientHeight)
        {
            int zellenBreite = ClientWidth / 6;
            int zellenHoehe = ClientHeight / 6;
            for (int i = zellenBreite, x = 0; x <= 2; i += zellenBreite, x++)
            {
                for (int j = zellenHoehe, y = 0; y <= 2; j += zellenHoehe, y++)
                {
                    gebeZelleKoordinaten(matrix[x, y], i, j, zellenBreite, zellenHoehe);

                }
            }
            return matrix;
        }
        public void zeichneSpielfeld(Graphics g,  int ClientWidth, int ClientHeight)
        {
           Pen blackPen = new Pen(Color.Black);
           SolidBrush brush = new SolidBrush(Color.DarkRed);
            matrix = berechneMatrix(ClientWidth, ClientHeight); 
            for (int x = 0;x <= 2; x++)
            {    
                for (int y = 0; y <= 2; y++)
                {
                    Rectangle rect = matrix[x, y].Rectangle;
                    g.FillRectangle(brush, rect);
                    g.DrawRectangle(blackPen, rect);

                }
            }

        }
    }
}
