using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows.Forms;
using MyShape;

namespace MyPaint
{
    class Plugin
    {
        public static readonly string dllFileExtension = "(*.dll)|*.dll";

        public static List<Assembly> LoadPlugin(params string[] paths)
        {
            List<Assembly> Assemblies = new List<Assembly>();
            foreach (var file in paths)
                Assemblies.Add(Assembly.LoadFrom(file));
            return Assemblies;
        }

        public static List<ShapeFactory> GetFactories(List<Assembly> Assemblies)
        {
            List<ShapeFactory> Factories = new List<ShapeFactory>();
            foreach (Assembly Assembly in Assemblies)
            {
                try
                {
                    Type[] Types = Assembly.GetTypes();
                    Plugin.LoadFactories(Factories, Types);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Getting Factories Error");
                }
            }
            return Factories;
        }

        private static void LoadFactories(List<ShapeFactory> Factories, Type[] Types)
        {
            foreach (Type type in Types)
            {
                if (type.IsClass && !type.IsAbstract && type.IsSubclassOf(typeof(ShapeFactory)))
                {
                    try
                    {
                        ShapeFactory factory = Activator.CreateInstance(type) as ShapeFactory;
                        Factories.Add(factory);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, "Loading Factories Error");
                    }

                }
            }
        }
    }
}
