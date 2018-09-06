using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Components
{
    public abstract class ColourScreen : ScreenBase
    {
        public ColourScreen(double hight, double width, int resolution, int colours) : base(hight, width, resolution)
        {
            Colours = colours;
            Brightness = 0.5;
        }

        public double Brightness { get; set; }
        public int Colours { get; }
        public abstract void Show(IScreenImage image, double brightness);

        public override string ToString()
        {
            return Size.ToString() + "\" "+  Colours.ToString() + " colours with " + Resolution.ToString() + "dpi resolution";
        }
    }
}
