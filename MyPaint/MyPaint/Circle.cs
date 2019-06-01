using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using MyShape;
using Newtonsoft.Json;

namespace MyPaint
{
    class Circle : Shape
    {
//        public Point pos1, pos2;
//        public int x, y, h, w;
//        private Color clr;
//        private int pWidth;
        [JsonConstructor]
        public Circle(Color clr, int pWidth)
        {
            this.clr = clr;
            this.pWidth = pWidth;
        }
        public Circle(Point p1,Point p2,Color clr, int pWidth)
        {
            this.pos1 = p1;
            this.pos2 = p2;
            this.clr = clr;
            this.pWidth = pWidth;
        }
        public override Shape Clone(Point pos1, Point pos2, Color clr, int pWidth)
        {
            return new Circle(pos1, pos2, clr, pWidth);
        }
        public override Bitmap Draw(Bitmap bmp, Point first, Point second)
        {
            Graphics graph = Graphics.FromImage(bmp);
            graph.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen pen = new Pen(clr);
            pen.Width = pWidth;
            int x = Math.Min(first.X, second.X);
            int y = Math.Min(first.Y, second.Y);
            int w = Math.Abs(first.X - second.X);
            int h = Math.Abs(first.Y - second.Y);
            System.Drawing.Rectangle rect = new System.Drawing.Rectangle(x, y, w, w);
            graph.DrawEllipse(pen, rect);
            graph.Save();
            return bmp;
        }
        public override void DrawE(Point first, Point second, PaintEventArgs e)
        {
            Pen pen = new Pen(clr);
            pen.Width = pWidth;
            int x = Math.Min(first.X, second.X);
            int y = Math.Min(first.Y, second.Y);
            int w = Math.Abs(first.X - second.X);
            int h = Math.Abs(first.Y - second.Y);
            System.Drawing.Rectangle rect = new System.Drawing.Rectangle(x, y, w, w);
            e.Graphics.DrawEllipse(pen, rect);
        }
    }
}
