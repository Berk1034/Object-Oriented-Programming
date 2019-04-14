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

        private Bitmap Bmp;
        private bool press = false;
        private Point one, two;
        private Color Current = Color.Black;
        private int penWidth = 1;
        private Shape figure;
        private int x, y, w, h;
        public List<Shape> ListOfShapes = new List<Shape>();

        public MainForm()
        {
            InitializeComponent();
//            one = new Point(0, 0);
//            two = new Point(700, 100);
            ListOfShapes.Add(new Line(Current, penWidth));
            one = new Point(10, 200);
            two = new Point(500, 100);
            ListOfShapes.Add(new Rectangle(Current, penWidth));
            /*
            ListOfShapes.Add(new Ellipse(myPen, new Point(30, 250), new Point(600, 200)));
            ListOfShapes.Add(new Square(myPen, new Point(40, 300), new Point(400, 300)));
            ListOfShapes.Add(new Circle(myPen, new Point(400, 500), new Point(200, 600)));
            ListOfShapes.Add(new Triangle(myPen, new Point(600, 250), new Point(500, 650)));
            */
            Bitmap bmp = new Bitmap(ShapePictureBox.Width, ShapePictureBox.Height);
            Bmp = bmp;

            foreach (Shape Shp in ListOfShapes)
            {
                CountCanvasPoints();
                Bmp = Shp.Draw(Bmp, x, y, h, w, one, two);
                ShapePictureBox.Image = Bmp;
            }

        }

        private void ShapePictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (figure != null)
            {
                Cursor.Current = Cursors.Cross;
                press = true;
                one = e.Location;
            }
        }

        private void ShapePictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (figure != null && press)
            {
                two = e.Location;
                ShapePictureBox.Refresh();
            }
        }

        private void ShapePictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (figure != null)
            {
                Cursor.Current = Cursors.Default;
                press = false;
                two = e.Location;
                Bmp = figure.Draw(Bmp, x, y, h, w, one, two);
                ShapePictureBox.Image = Bmp;
            }
        }

        private void ShapePictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (figure != null && press)
            {
                CountCanvasPoints();
                figure.DrawE(x, y, h, w, one, two, e);
            }
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            Line temp = new Line(Current, penWidth);
            this.figure = temp;
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            Rectangle temp = new Rectangle(Current, penWidth);
            this.figure = temp;
        }

        private void btnEllipse_Click(object sender, EventArgs e)
        {
            Ellipse temp = new Ellipse(Current, penWidth);
            this.figure = temp;
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            Square temp = new Square(Current, penWidth);
            this.figure = temp;
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            Circle temp = new Circle(Current, penWidth);
            this.figure = temp;
        }
                          
        private void btnTriangle_Click(object sender, EventArgs e)
        {
            Triangle temp = new Triangle(Current, penWidth);
            this.figure = temp;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ShapePictureBox.Image = null;
            Bmp.Dispose();
            ListOfShapes.Clear();
            Bitmap bmp = new Bitmap(ShapePictureBox.Width, ShapePictureBox.Height);
            Bmp = bmp;
        }

        private void tBarWidth_Scroll(object sender, EventArgs e)
        {
            this.figure = null;
            penWidth = tBarWidth.Value;
        }

        private void btnChangePenColor_Click(object sender, EventArgs e)
        {
            this.figure = null;
            colorDialog.ShowDialog();
            Current = colorDialog.Color;
        }

        public void CountCanvasPoints()
        {
            x = Math.Min(one.X, two.X);
            y = Math.Min(one.Y, two.Y);
            h = Math.Abs(one.X - two.X);
            w = Math.Abs(one.Y - two.Y);
        }
    }
}
