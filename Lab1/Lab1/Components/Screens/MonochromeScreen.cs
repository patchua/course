using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Components
{
    class MonochromeScreen : ScreenBase
    {
        public MonochromeScreen(int hight, int width, int resolution) : base(hight, width, resolution)
        {

        }

        public override void Show(IScreenImage image)
        {
            Console.WriteLine("Monochrome Screeen");
        }

        public override string ToString()
        {
            return "Monochrome"+base.ToString();
        }
    }
}
