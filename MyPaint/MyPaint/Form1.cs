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
        public enum Shapes
        {
            Line,
            Rectangle,
            Ellipse,
            Square,
            Circle
        }
        List<Shape> ListOfShapes;
        public Bitmap Bmp;
        public Pen myPen = new Pen(Color.Aqua, 4);
        public Graphics g = null;
        public bool endofdrawing = false;
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
/*
                clickLine = false;
                clickRectangle = false;
                clickEllipse = false;
                clickSquare = false;
                clickCircle = false;
*/
                Canvas.Cursor = Cursors.Default;
                endofdrawing = true;
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
//            pos1.X = 100;
//            pos1.Y = 200;
//            pos2.X = 200;
//            pos2.Y = 300;
            ListOfShapes = new List<Shape>(6);
            ListOfShapes.Add(new Shape(myPen, new Point(0, 0), new Point(700, 100)));
            ListOfShapes.Add(new Line(myPen, new Point(0, 0), new Point(700, 100)));
            ListOfShapes.Add(new Rectangle(myPen, new Point(10, 200), new Point(500, 100)));
            ListOfShapes.Add(new Ellipse(myPen, new Point(30, 250), new Point(600, 200)));
            ListOfShapes.Add(new Square(myPen, new Point(40, 300), new Point(400, 300)));
            ListOfShapes.Add(new Circle(myPen, new Point(400, 500), new Point(200, 600)));
            ListOfShapes.Add(new Triangle(myPen, new Point(600, 250), new Point(500, 650)));
            //            g = Canvas.CreateGraphics();
            Bitmap bmp = new Bitmap(Canvas.Width, Canvas.Height);
            Bmp = bmp;
            g = Graphics.FromImage(bmp);
            //            g = Canvas.CreateGraphics();
            //            g = Canvas.CreateGraphics();
            foreach (Shape Shp in ListOfShapes)
            {
                Shp.Draw(g);
            }
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
//            foreach(Shape Shp in ListOfShapes)
//            {
//                Shp.Draw(g);
//            }
            Canvas.BackgroundImage = Bmp;
            //            g = Graphics.FromHwnd(Canvas.Handle);
            //            g = Graphics.FromImage(e.Graphics);
            //            g = e.Graphics;
            //            g = Canvas.CreateGraphics();
            //            g = Graphics.FromImage(Bmp);
            if (clickLine)
            {
                Line Line1 = new Line(myPen, pos1, pos2);
                /*
                Line Line1 = new Line();
                Line1.pen = myPen;
                Line1.pos1 = pos1;
                Line1.pos2 = pos2;
                */
                Line1.Draw(g);
                Line1 = null;
            }
            else if (clickRectangle)
            {
                Rectangle Rect1 = new Rectangle(myPen, pos1, pos2);
                /*
                Rect1.pen = myPen;
                Rect1.pos1 = pos1;
                Rect1.pos2 = pos2;
                */
                Rect1.Draw(g);
                Rect1 = null;
            }
            else if (clickEllipse)
            {
                Ellipse Ellip1 = new Ellipse(myPen, pos1, pos2);
                /*
                Ellip1.pen = myPen;
                Ellip1.pos1 = pos1;
                Ellip1.pos2 = pos2;
                */
                Ellip1.Draw(g);
                Ellip1 = null;
            }
            else if (clickSquare)
            {
                Square Sq1 = new Square(myPen, pos1, pos2);
                /*
                Sq1.pen = myPen;
                Sq1.pos1 = pos1;
                Sq1.pos2 = pos2;
                */
                Sq1.Draw(g);
                Sq1 = null;
            }
            else if (clickCircle)
            {
                Circle Circ1 = new Circle(myPen, pos1, pos2);
                /*
                Circ1.pen = myPen;
                Circ1.pos1 = pos1;
                Circ1.pos2 = pos2;
                */
                Circ1.Draw(g);
                Circ1 = null;
            }
            //            e.Graphics.Save();
            //           if(endofdrawing)
            if (endofdrawing)
                Canvas.BackgroundImage = Bmp;
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DoubleBuffered = true;
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
