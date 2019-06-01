using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using MyShape;
using Newtonsoft.Json;

namespace MyClosedCurve
{
    public class ClosedCurve : Shape
    {
        [JsonConstructor]
        public ClosedCurve(Color clr, int pWidth)
        {
            this.clr = clr;
            this.pWidth = pWidth;
        }
        public ClosedCurve(Point p1, Point p2, Color clr, int pWidth)
        {
            this.pos1 = p1;
            this.pos2 = p2;
            this.clr = clr;
            this.pWidth = pWidth;
        }

        public override Shape Clone(Point pos1, Point pos2, Color clr, int pWidth)
        {
            return new ClosedCurve(pos1, pos2, clr, pWidth);
        }

        public override Bitmap Draw(Bitmap bmp,Point first, Point second)
        {
            Pen pen = new Pen(clr);
            pen.Width = pWidth;
            Point[] point = { new Point(first.X, first.Y), new Point(second.X, first.Y), new Point(second.X, second.Y), new Point(first.X, second.Y) };
            Graphics graph = Graphics.FromImage(bmp);
            graph.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            graph.DrawClosedCurve(pen, point);
            graph.Save();
            return bmp;
        }

        public override void DrawE(Point first, Point second, PaintEventArgs e)
        {
            Pen pen = new Pen(clr);
            pen.Width = pWidth;
            PointF[] point = { new Point(first.X, first.Y), new Point(second.X, first.Y), new Point(second.X, second.Y), new Point(first.X, second.Y) };
            e.Graphics.DrawClosedCurve(pen, point);
        }
    }
}
