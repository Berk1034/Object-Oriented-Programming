using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using MyShape;

namespace MyPaint
{
    class RectangleFactory : ShapeFactory
    {
        public RectangleFactory()
        {
            Name = "Rectangle";
        }

        public override Shape Create(Color clr, int pWidth)
        {
            return new Rectangle(clr, pWidth);
        }
    }
}
