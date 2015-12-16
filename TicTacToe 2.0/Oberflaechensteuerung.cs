using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe_2._0
{
    public partial class Form1 : Form
    {

        private Spielfeld Spielfeld = null;
        private Spielsteuerung Spielsteuerung = new Spielsteuerung();


        public Form1()
        {
            InitializeComponent();

        }

        private void FormLoad(object sender, EventArgs e)
        {
            this.ResizeRedraw = true;
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(300, 300);
            //panel1.AutoSize = true;
            //panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;


            //Spielfeld
            this.Spielfeld = new Spielfeld();
            this.Paint += new PaintEventHandler(ResizeFormPaint);
            this.MouseClick += new MouseEventHandler(MouseOnFormClick);
        }
        private void ResizeFormPaint(object sender, PaintEventArgs e)
        {
            Spielfeld.zeichneSpielfeld(e.Graphics, this.ClientSize.Width, this.ClientSize.Height);
        }
        private void MouseOnFormClick(object sender, MouseEventArgs e)
        {
            Zelle zelle = Spielfeld.welcheZelle(e.Location);

            string[] RückgabeArray = new string[3];

            RückgabeArray = Spielsteuerung.rundenChecker(zelle, Spielfeld);

            //Diese Funktion Wertet die Ergebnisse der Funktion rundenChecker aus und gibt dann die View Weiter
            this.auswertungRundenChecker(RückgabeArray);
            this.Refresh();


        }

        private void spielStart_button1_Click(object sender, EventArgs e)
        {
            this.Spielsteuerung.SpielerEins.Name = textBox1.Text;
            this.Spielsteuerung.SpielerZwei.Name = textBox2.Text;

            if (String.IsNullOrEmpty(this.Spielsteuerung.SpielerEins.Name))
            {
                this.Spielsteuerung.SpielerEins.Name = "Spieler1";
            }

            if (String.IsNullOrEmpty(this.Spielsteuerung.SpielerZwei.Name))
            {
                this.Spielsteuerung.SpielerZwei.Name = "Spieler2";
            }

            panel1.Visible = false;
        }
        private void beenden_ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Möchten Sie das Spiel wirklich beenden?", "Beenden", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Environment.Exit(0);
            }
            else
            {
                //e.Cancel = true;
            }

        }
        private void neuesSpiel_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Spielfeld.feldReset();
            panel1.Visible = true;
        }
        private void auswertungRundenChecker(string [] SpielDatenArray)
        {
            this.Refresh();
            if (SpielDatenArray[0] == "true")
            {
                if(SpielDatenArray[1] == "Sieg")
                {
                    MessageBox.Show(String.Format("Gewonnen hat Spieler {0}", SpielDatenArray[2]));
                } else
                {
                    MessageBox.Show("Unentschieden!");
                }
                this.Spielfeld.feldReset();
            }

        }


    }
}
