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
            List<Assembly> result = new List<Assembly>();
            foreach (var file in paths)
                result.Add(Assembly.LoadFrom(file));

            return result;
        }

        public static List<ShapeFactory> GetFactories(List<Assembly> assemblies)
        {
            List<ShapeFactory> factories = new List<ShapeFactory>();

            foreach (Assembly assembly in assemblies)
            {
                try
                {
                    Type[] types = assembly.GetTypes();
                    Plugin.LoadFactories(factories, types);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Getting Factories Error");
                }
            }
            return factories;
        }

        private static void LoadFactories(List<ShapeFactory> factories, Type[] types)
        {
            foreach (Type type in types)
            {
                if (type.IsClass && !type.IsAbstract && type.IsSubclassOf(typeof(ShapeFactory)))
                {
                    try
                    {
                        ShapeFactory factory = Activator.CreateInstance(type) as ShapeFactory;
                        factories.Add(factory);
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
