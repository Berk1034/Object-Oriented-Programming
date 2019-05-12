using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using MyShape;

namespace MyPaint
{
    class SquareFactory : ShapeFactory
    {
        public SquareFactory()
        {
            Name = "Square";
        }

        public override Shape Create(Color clr, int pWidth)
        {
            return new Square(clr, pWidth);
        }
    }
}
