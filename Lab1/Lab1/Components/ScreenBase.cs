using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Components
{
    public abstract class ScreenBase:IScreenImage
    {
        public Resolution Resolution { get; set; }
        public Double Size { get; set; }

        public int Hight { get; set; }
        public int Width { get; set; }

        public abstract void Show(IScreenImage image);
    }

    public struct Resolution
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
