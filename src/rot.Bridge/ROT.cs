using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Bridge;
using Bridge.Html5;

namespace ROT
{
    [External]
    [ObjectLiteral]
    public class DisplayOptions
    {
        public int Width;
        public int Height;
    }
    [External]
    public class Display
    {
        public Display(DisplayOptions o) {}
        public int Height { get; set; }
        public int Width { get; set; }
    }
}
