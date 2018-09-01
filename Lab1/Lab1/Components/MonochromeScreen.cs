using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Components
{
    class MonochromeScreen : ScreenBase
    {
        public override void Show(IScreenImage image)
        {
            Console.WriteLine("Monochrome Screeen");
        }

        public override string ToString()
        {
            return "MonochromeScreen";
        }
    }
}
