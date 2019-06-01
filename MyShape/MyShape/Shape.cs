using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace MyShape
{
    public abstract class Shape
    {
        public Point pos1, pos2;
        public Color clr;
        public int pWidth;

        public abstract Shape Clone(Point p1,Point p2,Color color,int widthofpen);
        public abstract Bitmap Draw(Bitmap bmp, Point first, Point second);
        public abstract void DrawE(Point first, Point second, PaintEventArgs e);
    }
}
