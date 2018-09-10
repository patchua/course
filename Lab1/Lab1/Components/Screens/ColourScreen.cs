using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneApp.Components
{
    public abstract class ColourScreen : ScreenBase
    {
        public ColourScreen(double hight, double width, int resolution, int colours,IOutput output) : base(hight, width, resolution,output)
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
