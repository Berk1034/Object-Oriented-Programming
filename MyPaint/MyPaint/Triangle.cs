using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MyPaint
{
    class Triangle : Shape
    {
        public Point pos3;
        public Triangle (Pen pn, Point position1, Point position2) : base(pn, position1, position2)
        {
            pos3 = new Point(pos1.X, pos2.Y);
        }
        public override void Draw(Graphics g)
        {
//            pos3 = new Point(pos1.X, pos2.Y);
            PointF[] points = { pos1, pos2, pos3 };
            g.DrawPolygon(pen, points);
        }
    }
}
