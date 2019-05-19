using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using System.Reflection;
using System.Windows.Input;
//using MyDrawingPencil;
using MyShape;
using System.Xml.Linq;

namespace MyPaint
{
    public partial class MainForm : Form
    {
        const String SerializationFile = "figures.json";
//        const String PluginFile = "MyDrawingPencil";
        const String PluginFile = "MyClosedCurve";

        public enum Shapes
        {
            Line,
            Rectangle,
            Ellipse,
            Triangle,
            Square,
            Circle
        }
        
//        private Assembly a;
        private Bitmap Bmp;
        private bool press = false;
//        private bool plugin = false;
        private bool user = false;
        private Point one, two;
        private Point MinP, MaxP;
        private Color Current = Color.Black;
        private int penWidth = 1;
        private Shape figure;
        private int x, y, w, h;
        private int location = 40;
        public List<Shape> ListOfShapes = new List<Shape>();
        public List<Shape> ListOfUserShapes = new List<Shape>();
        private object ShapeSender = new Button();
        private Dictionary<string, ShapeFactory> FactoriesList;

        public MainForm()
        {
            InitializeComponent();
//          one = new Point(0, 0);
//          two = new Point(700, 100);
            /*
            ListOfShapes.Add(new Line(Current, penWidth));
            one = new Point(10, 200);
            two = new Point(500, 100);
            ListOfShapes.Add(new Rectangle(Current, penWidth));
            */
            /*
            ListOfShapes.Add(new Ellipse(myPen, new Point(30, 250), new Point(600, 200)));
            ListOfShapes.Add(new Square(myPen, new Point(40, 300), new Point(400, 300)));
            ListOfShapes.Add(new Circle(myPen, new Point(400, 500), new Point(200, 600)));
            ListOfShapes.Add(new Triangle(myPen, new Point(600, 250), new Point(500, 650)));
            */
            Bitmap bmp = new Bitmap(ShapePictureBox.Width, ShapePictureBox.Height);
            Bmp = bmp;
            FactoriesList = GetFactoriesDict(GetAllShapeButtonsNames(pnlShapes), GetAllFactories());
            //Pencil pnc = new Pencil(Current, penWidth);
            //Bmp = pnc.Draw(Bmp, 100, 200, 200, 200, new Point(10, 100), new Point(200, 200));
            //ShapePictureBox.Image = Bmp;
            /*
                        foreach (Shape Shp in ListOfShapes)
                        {
                            CountCanvasPoints();
                            Bmp = Shp.Draw(Bmp, x, y, h, w, one, two);
                            ShapePictureBox.Image = Bmp;
                        }
            */
            MinP = new Point(0, 0);
            MaxP = new Point(ShapePictureBox.Width, ShapePictureBox.Height);
        }

        private void ShapePictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (figure != null || user)
            {
                Cursor.Current = Cursors.Cross;
                press = true;
                one = e.Location;
            }
        }

        private void ShapePictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if ((figure != null && press) || user)
            {
                two = e.Location;
                ShapePictureBox.Refresh();
            }
        }

        private void ShapePictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (figure != null && !user)
            {
                Cursor.Current = Cursors.Default;
                press = false;
                two = e.Location;
                Bmp = figure.Draw(Bmp, x, y, h, w, one, two);
                ShapePictureBox.Image = Bmp;
                figure.pos1 = one;
                figure.pos2 = two;
                figure.x = x;
                figure.y = y;
                figure.h = h;
                figure.w = w;
                figure.pWidth = penWidth;
                figure.clr = Current;
                ListOfShapes.Add(this.figure);
                this.figure = FactoriesList[((Button)ShapeSender).Text].Create(Current, penWidth);
            }
            if (user)
            {
                Cursor.Current = Cursors.Default;
                user = false;
                press = false;
                two = e.Location;
                foreach (Shape figure in ListOfUserShapes)
                {
                    Bmp = figure.Draw(Bmp, x, y, h, w, one, two);
//                    ShapePictureBox.Image = Bmp;
                }
                ShapePictureBox.Image = Bmp;
            }
        }

        private void ShapePictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (figure != null && press && !user)
            {
                CountCanvasPoints();
                figure.DrawE(x, y, h, w, one, two, e);
            }
            if (user && press)
            {
                CountCanvasPoints();
                foreach (Shape figure in ListOfUserShapes)
                {
                    figure.DrawE(x, y, h, w, one, two, e);
                }
            }
        }

        private List<string> GetAllShapeButtonsNames(Panel panel)
        {
            var result = new List<string>();
            var items = panel.Controls;

            foreach (var item in items)
                if (item.GetType().Name == "Button")
                    result.Add((item as Button).Name);

            return result;
        }

        private List<ShapeFactory> GetAllFactories()
        {
            var result = new List<ShapeFactory>();

            result.Add(new LineFactory());
            result.Add(new RectangleFactory());
            result.Add(new EllipseFactory());
            result.Add(new TriangleFactory());
            result.Add(new SquareFactory());
            result.Add(new CircleFactory());

            return result;
        }

        private Dictionary<string, ShapeFactory> GetFactoriesDict(List<string> NamesList, List<ShapeFactory> FactoriesList)
        {
            var result = new Dictionary<string, ShapeFactory>();

            for (var i = 0; i < NamesList.Count; i++)
                result.Add(NamesList[i], FactoriesList[i]);

            return result;
        }

/*
        private void btnLine_Click(object sender, EventArgs e)
        {
            this.figure = FactoriesList[((Button)sender).Name].Create(Current, penWidth);
//            Line temp = new Line(Current, penWidth);
//            this.figure = temp;
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            this.figure = FactoriesList[((Button)sender).Name].Create(Current, penWidth);
//            Rectangle temp = new Rectangle(Current, penWidth);
//            this.figure = temp;
        }

        private void btnEllipse_Click(object sender, EventArgs e)
        {
            this.figure = FactoriesList[((Button)sender).Name].Create(Current, penWidth);
//            Ellipse temp = new Ellipse(Current, penWidth);
//            this.figure = temp;
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            this.figure = FactoriesList[((Button)sender).Name].Create(Current, penWidth);
//            Square temp = new Square(Current, penWidth);
//            this.figure = temp;
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            this.figure = FactoriesList[((Button)sender).Name].Create(Current, penWidth);
//            Circle temp = new Circle(Current, penWidth);
//            this.figure = temp;
        }
                          
        private void btnTriangle_Click(object sender, EventArgs e)
        {
            this.figure = FactoriesList[((Button)sender).Name].Create(Current, penWidth);
//            Triangle temp = new Triangle(Current, penWidth);
//            this.figure = temp;
        }
*/
        private void btnSerialize_Click(object sender, EventArgs e)
        {
            JsonSerializer jsonSerializer = new JsonSerializer();
            jsonSerializer.TypeNameHandling = TypeNameHandling.Objects;

            using(StreamWriter writer = new StreamWriter(SerializationFile))
            {
                using(JsonWriter jsonWriter = new JsonTextWriter(writer))
                {
                    try
                    {
                        jsonSerializer.Serialize(jsonWriter, ListOfShapes);
                    }
                    catch(Exception exception)
                    {
                        MessageBox.Show(exception.Message, "Serialization Error");
                    }
                }
            }
        }

        private void btnDeserialize_Click(object sender, EventArgs e)
        {
            if (File.Exists(SerializationFile))
            {
                JsonSerializer jsonDeserializer = new JsonSerializer();
                jsonDeserializer.TypeNameHandling = TypeNameHandling.Objects;

                using (StreamReader reader = new StreamReader(SerializationFile))
                {
                    using (JsonReader jsonReader = new JsonTextReader(reader))
                    {
                        try
                        {
                            var DeserializedShapes = jsonDeserializer.Deserialize<List<Shape>>(jsonReader);
                            ListOfShapes.AddRange(DeserializedShapes);
                            foreach (Shape Shp in ListOfShapes)
                            {
                                Bmp = Shp.Draw(Bmp, Shp.x, Shp.y, Shp.h, Shp.w, Shp.pos1, Shp.pos2);
                                ShapePictureBox.Image = Bmp;
                                //ShapePictureBox.Refresh();
                            }
                        }
                        catch (Exception exception)
                        {
                            MessageBox.Show(exception.Message, "Deserialization Error");
                        }
                    }
                }
            }
            
        }

        private void CreateButton(Panel pnlPlugins, ShapeFactory factory)
        {
            Button button = new Button();
            pnlPlugins.Controls.Add(button);
            button.Location = new Point(btnPlugin.Location.X, btnPlugin.Location.Y + location);
            button.Name = "btn" + factory.Name;
            button.Text = factory.Name;
            button.Width = 76;
            button.Height = 34;
            button.BackColor = SystemColors.ControlLight;
            button.ForeColor = SystemColors.ControlText;
            button.Click += btnShape_Click;
            location += 40;
        }

        private void btnPlugin_Click(object sender, EventArgs e)
        {
            try
            {
                this.figure = null;
                OpenFileDialog OpenFileDlg = new OpenFileDialog();
                OpenFileDlg.Title = "Choose Plugin";
                OpenFileDlg.Filter = Plugin.dllFileExtension;
                OpenFileDlg.Multiselect = true;

                if (OpenFileDlg.ShowDialog() == DialogResult.OK)
                {
                    List<Assembly> Assemblies = Plugin.LoadPlugin(OpenFileDlg.FileNames);
                    List<ShapeFactory> Factories = Plugin.GetFactories(Assemblies);

                    foreach (ShapeFactory Factory in Factories)
                    {
                        if (!FactoriesList.ContainsKey("btn" + Factory.Name))
                        {
                            FactoriesList.Add("btn" + Factory.Name, Factory);
                            CreateButton(pnlPlugins, Factory);
                        }
                        else
                        {
                            MessageBox.Show("This Plugin is already Loaded", "Loading Plugin WARNING");
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Loading Plugin Error");
            }

        }
        /*
        private void btnPlugin_Click(object sender, EventArgs e)
        {
            try
            {
                if (!plugin)
                {
                    a = Assembly.Load(PluginFile);
                    /*
                    object[] construct = new object[2];
                    construct[0] = Current;
                    construct[1] = penWidth;
                    //Object o = a.CreateInstance("Pencil",false,0,null, construct,null,null);
                    Type t = a.GetType(PluginFile + ".Pencil");
                    Object o = Activator.CreateInstance(t, construct);
                    */
                    //            this.figure = o as Shape;
                    /*
                    MethodInfo mi = t.GetMethod("Draw");
                    object[] parameters = new object[7];
                    parameters[0] = Bmp;
                    parameters[1] = 100;
                    parameters[2] = 200;
                    parameters[3] = 200;
                    parameters[4] = 200;
                    parameters[5] = new Point(10, 100);
                    parameters[6] = new Point(200, 200);
                    this.figure = (Shape)o;
                    Bmp = (Bitmap)mi.Invoke(o, parameters);
                    //            Type tmp = o.GetType();
                    ShapePictureBox.Image = Bmp;
                    */
                    //ListOfShapes.Add(o as Shape);//Cast Exception Base-class to .dll
                    /*
                    plugin = true;
//                    btnPlugin.Text = "JustLine";
                    btnPlugin.Text = "ClosedCurve";

                }
                else
                {
                    object[] construct = new object[2];
                    construct[0] = Current;
                    construct[1] = penWidth;
                    //Object o = a.CreateInstance("Pencil",false,0,null, construct,null,null);
                    Type t = a.GetType(PluginFile + ".ClosedCurve");
                    Object o = Activator.CreateInstance(t, construct);
                    this.figure = o as Shape;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Loading plugin error with message");
            }

        }
        */

        private void btnShape_Click(object sender, EventArgs e)
        {
            ((Button)ShapeSender).Text = ((Button)sender).Name;
            this.figure = FactoriesList[((Button)ShapeSender).Text].Create(Current, penWidth);
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            try
            {
                this.figure = null;
                XDocument xdoc = new XDocument();
                XElement pencolor = new XElement("PenColor", Current.ToArgb().ToString());
                XElement penwidth = new XElement("PenWidth", penWidth.ToString());
                XElement background = new XElement("BackgroundColor", ShapePictureBox.BackColor.ToArgb().ToString());
                XElement settings = new XElement("settings");
                settings.Add(pencolor);
                settings.Add(penwidth);
                settings.Add(background);
                xdoc.Add(settings);
                xdoc.Save("settings.xml");
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message, "Save Settings Error");
            }
        }

        private void btnLoadSettings_Click(object sender, EventArgs e)
        {
            try
            {
                this.figure = null;
                XDocument xdoc = XDocument.Load("settings.xml");
                Current = Color.FromArgb(Int32.Parse(xdoc.Root.Element("PenColor").Value));
                penWidth = Int32.Parse(xdoc.Root.Element("PenWidth").Value);
                ShapePictureBox.BackColor = Color.FromArgb(Int32.Parse(xdoc.Root.Element("BackgroundColor").Value));
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message, "Load Settings Error");
            }
        }

        private void btnChangeBackgroundColor_Click(object sender, EventArgs e)
        {
            this.figure = null;
            colorDialog.ShowDialog();
            ShapePictureBox.BackColor = colorDialog.Color;
        }

        private void btnCreateShape_Click(object sender, EventArgs e)
        {
            try
            {
//                press = false;
                this.figure = null;
                foreach (Shape shp in ListOfShapes)
                {
                    ListOfUserShapes.Add(shp);
                }
                FindMinAndMaxPoints();
                foreach (Shape usershape in ListOfUserShapes)
                {
                    usershape.pos1.X = usershape.pos1.X - MinP.X;
                    usershape.pos1.Y = usershape.pos1.Y - MinP.Y;
                    usershape.x = usershape.pos1.X;
                    usershape.y = usershape.pos1.Y;
                    usershape.w = usershape.w - MaxP.X;
                    usershape.h = usershape.h - MaxP.Y;
                }

                user = true;
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message, "Creating Shape Error");
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ShapePictureBox.Image = null;
            Bmp.Dispose();
            ListOfShapes.Clear();
            Bitmap bmp = new Bitmap(ShapePictureBox.Width, ShapePictureBox.Height);
            Bmp = bmp;
        }

        private void tBarWidth_Scroll(object sender, EventArgs e)
        {
            this.figure = null;
            penWidth = tBarWidth.Value;
        }

        private void btnChangePenColor_Click(object sender, EventArgs e)
        {
            this.figure = null;
            colorDialog.ShowDialog();
            Current = colorDialog.Color;
        }

        public void CountCanvasPoints()
        {
            if (!user)
            {
                x = Math.Min(one.X, two.X);
                y = Math.Min(one.Y, two.Y);
                h = Math.Abs(one.X - two.X);
                w = Math.Abs(one.Y - two.Y);
            }
            else
            {
                x = Math.Min(one.X - MinP.X, two.X - MinP.X);
                y = Math.Min(one.X - MinP.X, two.X - MinP.X);
                h = Math.Abs(one.X - two.Y);
                w = Math.Abs(one.X - two.Y);
            }
        }

        public void FindMinAndMaxPoints()
        {
            MinP.X = ListOfUserShapes.Min(shape => shape.pos1.X);
            MinP.Y = ListOfUserShapes.Min(shape => shape.pos1.Y);
            MaxP.X = ListOfUserShapes.Max(shape => shape.pos1.X);
            MaxP.Y = ListOfUserShapes.Max(shape => shape.pos1.Y);

            Point tempPointMin = new Point(MinP.X, MinP.Y);
            Point tempPointMax = new Point(MaxP.X, MaxP.Y);

            MinP.X = ListOfUserShapes.Min(shape => shape.pos2.X);
            MinP.Y = ListOfUserShapes.Min(shape => shape.pos2.Y);
            MaxP.X = ListOfUserShapes.Max(shape => shape.pos2.X);
            MaxP.Y = ListOfUserShapes.Max(shape => shape.pos2.Y);

            if(MinP.X > tempPointMin.X)
            {
                MinP.X = tempPointMin.X;
            }
            if (MinP.Y > tempPointMin.Y)
            {
                MinP.Y = tempPointMin.Y;
            }
            if (MaxP.X < tempPointMax.X)
            {
                MaxP.X = tempPointMax.X;
            }
            if (MaxP.Y < tempPointMax.Y)
            {
                MaxP.Y = tempPointMax.Y;
            }
        }
    }
}
