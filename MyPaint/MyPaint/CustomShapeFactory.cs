using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyShape;

namespace MyPaint
{
    public class CustomShapeFactory : ShapeFactory
    {
        public CustomShapeFactory()
        {
            Name = "CustomShape";
        }

        public override Shape Create(Color clr, int pWidth)
        {
            return new CustomShape(clr, pWidth);
        }

        public Shape Create(string name, List<Shape> components, int width, int height)
        {
            return new CustomShape(name, components, width, height);
        }
    }
}
