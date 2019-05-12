using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using MyShape;

namespace MyPaint
{
    class LineFactory : ShapeFactory
    {
        public LineFactory()
        {
            Name = "Line";
        }

        public override Shape Create(Color clr, int pWidth)
        {
            return new Line(clr, pWidth);
        }
    }
}
