using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace MyPaint
{
    class Square : Shape
    {
        private Color clr;
        private int pWidth;
        public Square(Color clr, int pWidth)
        {
            this.clr = clr;
            this.pWidth = pWidth;
        }
        public override Bitmap Draw(Bitmap bmp, int x, int y, int h, int w, Point first, Point second)
        {
            Graphics graph = Graphics.FromImage(bmp);
            Pen pen = new Pen(clr);
            pen.Width = pWidth;
            graph.DrawRectangle(pen, x, y, h, h);
            graph.Save();
            return bmp;
        }
        public override void DrawE(int x, int y, int h, int w, Point first, Point second, PaintEventArgs e)
        {
            Pen pen = new Pen(clr);
            pen.Width = pWidth;
            System.Drawing.Rectangle rect = new System.Drawing.Rectangle(x, y, h, h);
            e.Graphics.DrawRectangle(pen, rect);
        }
    }
}
