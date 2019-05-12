using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShape
{
    public abstract class ShapeFactory
    {
        public string Name { get; set; }
        public abstract Shape Create();
    }
}
