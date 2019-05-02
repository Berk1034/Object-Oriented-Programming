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
        public int x, y, h, w;
        public Color clr;
        public int pWidth;

        public abstract Bitmap Draw(Bitmap bmp, int x, int y, int h, int w, Point first, Point second);
        public abstract void DrawE(int x, int y, int h, int w, Point first, Point second, PaintEventArgs e);
    }
}
