using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyShape;

namespace MyPaint
{
    class CustomShape : Shape
    {
        private List<Shape> components;
        private int width;
        private int height;
        public string name { get; set; }
        public int x1 { get; set; }
        public int x2 { get; set; }
        public int y1 { get; set; }
        public int y2 { get; set; }

        public CustomShape(string name, List<Shape> components, int width, int height)
        {
            this.name = name;
            this.components = components;
            this.width = width;
            this.height = height;
        }
        public CustomShape()
        {
            this.name = "Custom";
        }
        /*
        public CustomShape(Color clr, int pWidth)
        {
            this.clr = clr;
            this.pWidth = pWidth;
        }
        */
        public override Bitmap Draw(Bitmap bmp, Point first, Point second)
        {
            Pen pen = new Pen(Color.Black);
            foreach (Shape component in components)
            {
                Point pos1 = new Point();
                pos1.X = first.X + (second.X - first.X) * component.pos1.X / width;
                pos1.Y = first.Y + (second.Y - first.Y) * component.pos1.Y / height;
                Point pos2 = new Point();
                pos2.X = first.X + (second.X - first.X) * component.pos2.X / width;
                pos2.Y = first.Y + (second.Y - first.Y) * component.pos2.Y / height;

                component.Draw(bmp, pos1, pos2);
            }
            return bmp;
        }

        public override void DrawE(Point first, Point second, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black);
            foreach (Shape component in components)
            {
                Point pos1 = new Point();
                pos1.X = first.X + (second.X - first.X) * component.pos1.X / width;
                pos1.Y = first.Y + (second.Y - first.Y) * component.pos1.Y / height;
                Point pos2 = new Point();
                pos2.X = first.X + (second.X - first.X) * component.pos2.X / width;
                pos2.Y = first.Y + (second.Y - first.Y) * component.pos2.Y / height;

                component.DrawE(pos1, pos2, e);
            }
        }
    }
}
