using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using MyShape;

namespace MyPaint
{
    public class CircleFactory : ShapeFactory
    {
        public CircleFactory()
        {
            Name = "Circle";
        }

        public override Shape Create(Color clr, int pWidth)
        {
            return new Circle(clr, pWidth);
        }

    }
}
