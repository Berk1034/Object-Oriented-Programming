using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MyPaint
{
    class Square : Shape
    {
//        public Pen pen;
//        public Point pos1, pos2;
        public int weight;
        public Square(Pen pn, Point position1, Point position2) : base(pn, position1, position2)
        {
            weight = Math.Abs(pos1.X - pos2.X);
        }
        public override void Draw(Graphics g)
        {
//            base.Draw(g);
            //            weight = Math.Abs(pos1.X - pos2.X);
            g.DrawRectangle(pen, Math.Min(pos1.X, pos2.X), Math.Min(pos1.Y, pos2.Y), weight, weight);
        }
    }
}
