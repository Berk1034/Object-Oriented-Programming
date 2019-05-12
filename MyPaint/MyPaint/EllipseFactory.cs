using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using MyShape;

namespace MyPaint
{
    class EllipseFactory : ShapeFactory
    {
        public EllipseFactory()
        {
            Name = "Ellipse";
        }

        public override Shape Create(Color clr, int pWidth)
        {
            return new Ellipse(clr, pWidth);
        }
    }
}
