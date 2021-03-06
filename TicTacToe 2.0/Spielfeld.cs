﻿/**
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
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Text;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace TicTacToe_2._0
{
    class Spielfeld
    {
        //Hier werden alle 9 Zellen Gespeichert in einem 2 Dimensionalem Array.
        //Das System ist es die Felder in dem Array Strukturiert wie auf dem Feld zu lagern
        // 
        //  |0.0|0.1|0.2|
        //  |1.0|1.1|1.2|
        //  |2.0|2.1|2.2|
        //
        // Zum Bildlichen Vorstellen die Abbildung oben
        public Zelle[,] Matrix = new Zelle[3,3];

        //Generiert die 9 Zellen Objekten mit den Rectangle in sich
        public Spielfeld()
        {
            this.Matrix[0, 0] = new Zelle();
            this.Matrix[0, 1] = new Zelle();
            this.Matrix[0, 2] = new Zelle();

            this.Matrix[1, 0] = new Zelle();
            this.Matrix[1, 1] = new Zelle();
            this.Matrix[1, 2] = new Zelle();

            this.Matrix[2, 0] = new Zelle();
            this.Matrix[2, 1] = new Zelle();
            this.Matrix[2, 2] = new Zelle();
        }

        //Hier bekommt die Zelle ihre Punkte zur richtigen Positonierung in der View
        private void gebeZelleKoordinaten(Zelle Zelle, int x, int y, int breite ,int hoehe)
        {
            Zelle.Rectangle.X = x;
            Zelle.Rectangle.Y = y;
            Zelle.Rectangle.Height = hoehe;
            Zelle.Rectangle.Width = breite;
        }

        //Berechnet die Optimalen Punkte aller 9 Zellen aus so, das sie immer Proportional ein Rechteck ergeben.
        private Zelle[,] berechneMatrix(int ClientWidth, int ClientHeight)
        {

            int zellSeite = Math.Min(ClientWidth, ClientHeight) / 5;
            int startPunktX = (ClientWidth - (3 * zellSeite)) / 2 ;
            int startPunktY = (ClientHeight - (3 * zellSeite)) / 2;

            for (int i = startPunktX / 2, x = 0; x <= 2; i += zellSeite, x++)
            {
                for (int j = startPunktY, y = 0; y <= 2; j += zellSeite, y++)
                {
                    gebeZelleKoordinaten(Matrix[x, y], i, j, zellSeite, zellSeite);

                }
            }
            return Matrix;
        }

        //Diese Funktion wird durch ein Resize event angesprochen von der Benutzeroberfläche(View) so das es sich immer dem Fenster anpasst.
        public void zeichneSpielfeld(Graphics g,  int ClientWidth, int ClientHeight)
        {
            Pen blackPen = new Pen(Color.Black, 8.0F);
            //SolidBrush ZellenPinsel = new SolidBrush(Color.DarkRed);
            Matrix = berechneMatrix(ClientWidth, ClientHeight);
            for (int x = 0;x <= 2; x++)
            {
                for (int y = 0; y <= 2; y++)
                {
                    SolidBrush drawBrush = new SolidBrush(Color.White);

                    Zelle zelle = Matrix[x, y];
                    Font drawFont = new Font("Roboto", fontGroesseBerechnen(zelle));

                    //Stringformatierung
                    StringFormat stringFormat = new StringFormat();
                    stringFormat.Alignment = StringAlignment.Center;

                    //Antialias
                    g.SmoothingMode = SmoothingMode.AntiAlias;

                    // Draw string to screen.
                    g.FillRectangle(zelle.DefaultPinsel, zelle.Rectangle);
                    g.DrawRectangle(blackPen, zelle.Rectangle);

                    g.TextRenderingHint = TextRenderingHint.AntiAlias;
                    g.DrawString(zelle.Spieler.Figur, drawFont, drawBrush, zelle.Rectangle, stringFormat);

                }
            }

        }

        //Prüft bei jedem Klick auf das Spielfeld welche Zelle Angeklickt wurde. Wurde die Angklickte Zelle gefunden, so wirde diese übergeben
        public Zelle welcheZelle(Point location)
        {
            foreach (Zelle zelle in this.Matrix)
            {
                if(zelle.Rectangle.Contains(location) == true)
                {
                    return zelle;
                }
            }
            return null;
        }

        //Initialsierit Das Spielfeld neu
        public void feldReset()
        {
            this.Matrix[0, 0] = new Zelle();
            this.Matrix[0, 1] = new Zelle();
            this.Matrix[0, 2] = new Zelle();

            this.Matrix[1, 0] = new Zelle();
            this.Matrix[1, 1] = new Zelle();
            this.Matrix[1, 2] = new Zelle();

            this.Matrix[2, 0] = new Zelle();
            this.Matrix[2, 1] = new Zelle();
            this.Matrix[2, 2] = new Zelle();

        }
        //Skalliert nach der größe des Fensters die Optimale Schriftgröße
        public float fontGroesseBerechnen(Zelle zelle)
        {
            float ClientWidthFloat = (float)zelle.Rectangle.Width;
            float ClientHeightFloat = (float)zelle.Rectangle.Height;

            float fontGroesse = (ClientWidthFloat + ClientHeightFloat) / 3.0F;

            return fontGroesse;
        }
    }
}
