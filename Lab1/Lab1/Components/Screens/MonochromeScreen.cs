using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneApp.Components
{
    class MonochromeScreen : ScreenBase
    {
        public MonochromeScreen(int hight, int width, int resolution, IOutput output) : base(hight, width, resolution, output)
        {

        }

        public override void Show(IScreenImage image)
        {
           // Show Image
        }
       
        public override string ToString()
        {
            return "Monochrome"+base.ToString();
        }
    }
}
