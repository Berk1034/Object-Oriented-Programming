using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using MyShape;

namespace MyPentagon
{
    class PentagonFactory : ShapeFactory
    {
        public PentagonFactory()
        {
            Name = "Pentagon";
        }

        public override Shape Create(Color clr, int pWidth)
        {
            return new Pentagon(clr, pWidth);
        }
    }
}

