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

        private Spielfeld spielfeld = null;
        private Spielsteuerung spielsteuerung = new Spielsteuerung();
        int rundenZaehler = 1;

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
            this.spielfeld = new Spielfeld();
            this.Paint += new PaintEventHandler(ResizeFormPaint);
            this.MouseClick += new MouseEventHandler(MouseOnFormClick);
        }


        private void ResizeFormPaint(object sender, PaintEventArgs e)
        {
            spielfeld.zeichneSpielfeld(e.Graphics, this.ClientSize.Width, this.ClientSize.Height);
        }
        private void MouseOnFormClick(object sender, MouseEventArgs e)
        {
            Zelle zelle = spielfeld.welcheZelle(e.Location);

            if (zelle != null && zelle.geklickt == false)
            {
                spielsteuerung.welcherSpieler(zelle);
                this.Refresh();

                if (rundenZaehler < 9)
                {
                    if (spielsteuerung.check_for_winner(spielfeld.matrix) == true)
                    {
                        MessageBox.Show(String.Format("Gewonnen hat Spieler {0}", zelle.Spieler.Name));
                        this.spielfeld.feldReset();
                        rundenZaehler = 0;
                        this.Refresh();

                    }
                    rundenZaehler++;

                }
                else
                {
                    MessageBox.Show("Unentschieden!!");
                    this.spielfeld.feldReset();
                    rundenZaehler = 1;
                    this.Refresh();
                }

            }


        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.spielsteuerung.spielerEins.Name = textBox1.Text;
            this.spielsteuerung.spielerZwei.Name = textBox2.Text;

            if (String.IsNullOrEmpty(this.spielsteuerung.spielerEins.Name))
            {
                this.spielsteuerung.spielerEins.Name = "Spieler1";
            }

            if (String.IsNullOrEmpty(this.spielsteuerung.spielerZwei.Name))
            {
                this.spielsteuerung.spielerZwei.Name = "Spieler2";
            }

            panel1.Visible = false;
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void neuesSpielToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.spielfeld.feldReset();
            panel1.Visible = true;
        }
    }
}
