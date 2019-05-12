using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MyShape
{
    public abstract class ShapeFactory
    {
        public string Name { get; set; }
        public abstract Shape Create(Color clr, int pWidth);
    }
}
