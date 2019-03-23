using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPaint
{
    public partial class MainForm : Form
    {
        public Pen myPen = new Pen(Color.Aqua,2F);
        public Graphics g = null;
        public bool clickLine = false;
        public Point pos1, pos2;

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && clickLine)
            {
                pos2.X = e.X;
                pos2.Y = e.Y;
                Canvas.Refresh();
            }
        }

        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && clickLine)
            {
                pos2.X = e.X;
                pos2.Y = e.Y;
                clickLine = false;
                Canvas.Refresh();
            }
        }

        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left && clickLine)
            {
                pos1.X = e.X;
                pos1.Y = e.Y;
            }
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            myPen.Width = 4;
            g = Canvas.CreateGraphics();
            Line Line1 = new Line();
            Line1.pen = myPen;
            Line1.pos1 = pos1;
            Line1.pos2 = pos2;
            Line1.Draw(g);
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            clickLine = true;
        }
    }
}
