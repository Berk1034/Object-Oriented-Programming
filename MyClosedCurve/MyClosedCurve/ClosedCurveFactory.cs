using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using MyShape;

namespace MyClosedCurve
{
    class ClosedCurveFactory : ShapeFactory
    {
        public ClosedCurveFactory()
        {
            Name = "ClosedCurve";
        }

        public override Shape Create(Color clr, int pWidth)
        {
            return new ClosedCurve(clr, pWidth);
        }
    }
}
