using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyShape;
using Newtonsoft.Json;

namespace MyPaint
{
    public class CustomShape : Shape
    {
        public List<Shape> components;
        public int width;
        public int height;
        public string name { get; set; }
        //        public Dictionary<Shape, List<Point>> SerializeList;
        public List<Shape> SerializeList;
        public List<Point[]> newpoints;
        [JsonConstructor]
        public CustomShape(string name, List<Shape> components, int width, int height)
        {
            this.name = name;
            this.components = components;
            this.width = width;
            this.height = height;
        }
        public CustomShape(Point p1, Point p2, Color clr, int pWidth)
        {
            this.pos1 = p1;
            this.pos2 = p2;
            this.clr = clr;
            this.pWidth = pWidth;
        }
        public override Shape Clone(Point pos1, Point pos2, Color clr, int pWidth)
        {
            return new CustomShape(pos1, pos2, clr, pWidth);
        }
        public CustomShape()
        {
            this.name = "Custom";
        }
        public CustomShape(Color clr, int pWidth)
        {
            this.name = "Custom";
        }
        
        public override Bitmap Draw(Bitmap bmp, Point first, Point second)
        {
            Pen pen = new Pen(Color.Black);
            newpoints = new List<Point[]>();
//            SerializeList = new Dictionary<Shape, List<Point>>();
//            SerializeList = components.GetRange(0, components.Count);
//            SerializeList = new List<Shape>(components);
//            int i = 0;
            foreach (Shape component in components)
            {
                Point pos1 = new Point();
                pos1.X = first.X + (second.X - first.X) * component.pos1.X / width;
                pos1.Y = first.Y + (second.Y - first.Y) * component.pos1.Y / height;
                Point pos2 = new Point();
                pos2.X = first.X + (second.X - first.X) * component.pos2.X / width;
                pos2.Y = first.Y + (second.Y - first.Y) * component.pos2.Y / height;
                /*
                List<Point> points = new List<Point>();
                points.Add(pos1);
                points.Add(pos2);
                */
                Point[] points = new Point[]{ pos1, pos2 };
                newpoints.Add(points);
//                SerializeList.Add(component, points);
                /*
                SerializeList[i].pos1 = pos1;
                SerializeList[i].pos2 = pos2;
                */
                component.Draw(bmp, pos1, pos2);
                //i++;
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
