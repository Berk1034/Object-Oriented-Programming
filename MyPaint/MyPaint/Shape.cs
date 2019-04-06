using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MyPaint
{
    public class Shape
    {
        public Pen pen;
        public Point pos1, pos2;
        public Shape(Pen pn, Point position1, Point position2)
        {
            this.pen = pn;
            this.pos1 = position1;
            this.pos2 = position2;
        }
        public virtual void Draw(Graphics g)
        {

        }
    }
}
