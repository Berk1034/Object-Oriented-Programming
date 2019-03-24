using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MyPaint
{
    class Circle : Shape
    {
        public Pen pen;
        public Point pos1, pos2;
        public int radius;
        public override void Draw(Graphics g)
        {
            radius = Math.Abs(pos1.X - pos2.X);
            g.DrawEllipse(pen, Math.Min(pos1.X, pos2.X), Math.Min(pos1.Y, pos2.Y), radius, radius);
        }
    }
}
