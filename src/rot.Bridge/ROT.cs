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
        public bool Transpose;
        public string Layout;
        public int FontSize;
        public int Spacing;
        public int Border;
        public bool ForceSquareRatio;
        public string FontFamily;
        public string FontStyle;
        public string Fg;
        public string Bg;
        public int TileWidth;
        public int TileHeight;
        public Dictionary<string, int[]> tileMap;
        public HTMLElement TileSet;
        public bool TileColorize;
    }
    [External]
    public class Display
    {
        public Display(DisplayOptions o) {}
        public int Height { get; set; }
        public int Width { get; set; }
        public HTMLElement GetContainer() => throw new NotImplementedException();
        public void DEBUG(int x, int y, int what) { }

        public void Draw(int x, int y, string ch) { }

        public void Clear() { }
    }
}
