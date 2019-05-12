using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using MyShape;

namespace MyDrawingPencil
{
    class PencilFactory : ShapeFactory
    {
        public PencilFactory()
        {
            Name = "Pencil";
        }

        public override Shape Create(Color clr, int pWidth)
        {
            return new Pencil(clr, pWidth);
        }
    }
}
