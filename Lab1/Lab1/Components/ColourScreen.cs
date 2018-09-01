using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Components
{
    public abstract class ColourScreen : ScreenBase
    {
        public int Brightness { get; set; }
        public int Colours { get; set; }
        public abstract void Show(IScreenImage image, int brightness);

        public override string ToString()
        {
            return "ColourScreen";
        }
    }
}
