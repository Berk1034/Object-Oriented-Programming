using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using MyShape;

namespace MyPentagon
{
    public class Pentagon : Shape
    {
        public Pentagon(Color clr, int pWidth)
        {
            this.clr = clr;
            this.pWidth = pWidth;
        }

        public override Bitmap Draw(Bitmap bmp, int x, int y, int h, int w, Point first, Point second)
        {
            Pen pen = new Pen(clr);
            pen.Width = pWidth;

            if (first.X > second.X)
            {
                int tempPoint = second.X;
                second.X = first.X;
                first.X = tempPoint;
            }

            int temp = (Math.Abs(second.X - first.X)) / 2;

            Point Point1 = first;

            Point Point2 = new Point(first.X + temp, first.Y - temp);

            Point Point3 = new Point(second.X, first.Y);

            double pentagonSide = Math.Sqrt(2 * Math.Pow(temp, 2));
            double pentagonHeight = 1.539 * pentagonSide;
            temp = (int)pentagonSide / 2;

            Point Point4 = new Point(Point2.X + temp, Point2.Y + (int)pentagonHeight);

            Point Point5 = new Point(Point2.X - temp, Point2.Y + (int)pentagonHeight);

            Graphics graph = Graphics.FromImage(bmp);
            Point[] point = { Point1, Point2, Point3, Point4, Point5 };
            graph.DrawPolygon(pen, point);
            graph.Save();

            return bmp;
        }
        public override void DrawE(int x, int y, int h, int w, Point first, Point second, PaintEventArgs e)
        {
            Pen pen = new Pen(clr);
            pen.Width = pWidth;

            if (first.X > second.X)
            {
                int tempPoint = second.X;
                second.X = first.X;
                first.X = tempPoint;
            }

            int temp = (Math.Abs(second.X - first.X)) / 2;

            Point Point1 = first;

            Point Point2 = new Point(first.X + temp, first.Y - temp);

            Point Point3 = new Point(second.X, first.Y);

            double pentagonSide = Math.Sqrt(2 * Math.Pow(temp, 2));
            double pentagonHeight = 1.539 * pentagonSide;
            temp = (int)pentagonSide / 2;

            Point Point4 = new Point(Point2.X + temp, Point2.Y + (int)pentagonHeight);

            Point Point5 = new Point(Point2.X - temp, Point2.Y + (int)pentagonHeight);

            Point[] point = { Point1, Point2, Point3, Point4, Point5 };
            e.Graphics.DrawPolygon(pen, point);
        }      
    }
}
