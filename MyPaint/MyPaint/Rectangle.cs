using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MyPaint
{
    class Rectangle : Shape
    {
        //        public Pen pen;
        //        public Point pos1, pos2;
        public int height;
        public int weight;
        public Rectangle(Pen pen, Point position1, Point position2) : base(pen, position1, position2)
        {
            height = Math.Abs(pos1.Y - pos2.Y);
            weight = Math.Abs(pos1.X - pos2.X);
        }
        public override void Draw(Graphics g)
        {
//            height = Math.Abs(pos1.Y - pos2.Y);
//            weight = Math.Abs(pos1.X - pos2.X);
            g.DrawRectangle(pen, Math.Min(pos1.X, pos2.X), Math.Min(pos1.Y, pos2.Y), weight, height);
        }
    }
}
