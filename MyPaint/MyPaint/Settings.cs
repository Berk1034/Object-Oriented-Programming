using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint
{
    class Settings
    {
        public string PenColor { get; private set; }
        public string PenWidth { get; private set; }
        public string Background { get; private set; }
        public Settings(string pencolor, string penwidth, string background)
        {
            PenColor = pencolor;
            PenWidth = penwidth;
            Background = background;
        }
    }
}
