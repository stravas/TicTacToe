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
        private Spielsteuerung spielsteuerung;


        public Form1()
        {
            InitializeComponent();
        }

        private void FormLoad(object sender, EventArgs e)
        {
            this.ResizeRedraw = true;
            this.DoubleBuffered = true;
            this.spielfeld = new Spielfeld();
            this.Paint += new PaintEventHandler(FormPaint);
            this.MouseClick += new MouseEventHandler(MouseOnFormClick);
        }


        private void FormPaint(object sender, PaintEventArgs e)
        {
            spielfeld.zeichneSpielfeld(e.Graphics, this.ClientSize.Width, this.ClientSize.Height);
        }

        private void MouseOnFormClick(object sender, MouseEventArgs e)
        {
            
        }

    }
}
