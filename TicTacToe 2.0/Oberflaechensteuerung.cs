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
            panel1.AutoSize = true;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;




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

        public void SpielerEintrag()
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            int count = panel1.Controls.Count;
            string test1 = textBox1.Text;
            string test2 = textBox2.Text;
        }

    }
}
