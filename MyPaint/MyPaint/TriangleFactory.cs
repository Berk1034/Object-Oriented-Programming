using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using MyShape;

namespace MyPaint
{
    class TriangleFactory : ShapeFactory
    {
        public TriangleFactory()
        {
            Name = "Triangle";
        }

        public override Shape Create(Color clr, int pWidth)
        {
            return new Triangle(clr, pWidth);
        }
    }
}
