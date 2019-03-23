using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint
{
    class Line : Shape
    {
        public Pen pen;
        public Point pos1, pos2;
        public override void Draw(Graphics g)
        {
            g.DrawLine(pen, pos1.X, pos1.Y, pos2.X, pos2.Y);
        }
    }
}
