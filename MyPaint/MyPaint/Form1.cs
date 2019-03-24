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
        public Pen myPen = new Pen(Color.Aqua, 4);
        public Graphics g = null;
        public bool clickLine = false, clickRectangle = false, clickEllipse = false, clickSquare = false, clickCircle = false;
        public Point pos1, pos2;

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && (clickLine || clickRectangle || clickEllipse || clickSquare || clickCircle))
            {
                pos2.X = e.X;
                pos2.Y = e.Y;
                Canvas.Refresh();
            }
        }

        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && (clickLine || clickRectangle || clickEllipse || clickSquare || clickCircle))
            {
                pos2.X = e.X;
                pos2.Y = e.Y;
                Canvas.Refresh();
                Canvas.Cursor = Cursors.Default;
            }
        }

        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left && (clickLine || clickRectangle || clickEllipse || clickSquare || clickCircle))
            {
                Canvas.Cursor = Cursors.Hand;
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
 //           myPen.Width = 4;
            g = Canvas.CreateGraphics();
            if (clickLine)
            {
                Line Line1 = new Line();
                Line1.pen = myPen;
                Line1.pos1 = pos1;
                Line1.pos2 = pos2;
                Line1.Draw(g);
                Line1 = null;
            }else if (clickRectangle)
            {
                Rectangle Rect1 = new Rectangle();
                Rect1.pen = myPen;
                Rect1.pos1 = pos1;
                Rect1.pos2 = pos2;
                Rect1.Draw(g);
                Rect1 = null;
            }
            else if (clickEllipse)
            {
                Ellipse Ellip1 = new Ellipse();
                Ellip1.pen = myPen;
                Ellip1.pos1 = pos1;
                Ellip1.pos2 = pos2;
                Ellip1.Draw(g);
                Ellip1 = null;
            }
            else if (clickSquare)
            {
                Square Sq1 = new Square();
                Sq1.pen = myPen;
                Sq1.pos1 = pos1;
                Sq1.pos2 = pos2;
                Sq1.Draw(g);
                Sq1 = null;
            }
            else if (clickCircle)
            {
                Circle Circ1 = new Circle();
                Circ1.pen = myPen;
                Circ1.pos1 = pos1;
                Circ1.pos2 = pos2;
                Circ1.Draw(g);
                Circ1 = null;
            }
            g.Dispose();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void btnChangePenColor_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            myPen.Color = colorDialog.Color;
        }

        private void tBarWidth_Scroll(object sender, EventArgs e)
        {
            myPen.Width = tBarWidth.Value;
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            clickCircle = true;
            clickSquare = false;
            clickEllipse = false;
            clickLine = false;
            clickRectangle = false;
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            clickSquare = true;
            clickEllipse = false;
            clickLine = false;
            clickRectangle = false;
            clickCircle = false;
        }

        private void btnEllipse_Click(object sender, EventArgs e)
        {
            clickEllipse = true;
            clickLine = false;
            clickRectangle = false;
            clickSquare = false;
            clickCircle = false;
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            clickRectangle = true;
            clickLine = false;
            clickEllipse = false;
            clickSquare = false;
            clickCircle = false;
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            clickLine = true;
            clickRectangle = false;
            clickEllipse = false;
            clickSquare = false;
            clickCircle = false;
        }
    }
}
