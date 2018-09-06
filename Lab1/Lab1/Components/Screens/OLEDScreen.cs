using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Components
{
    class OLEDScreen:ColourScreen
    {
        public OLEDScreen(double hight, double width) : base(hight, width, 200, 20000)
        {
        }

        private void ShowImage(IScreenImage image, double brightness)
        {
            //implementation
        }
        public override void Show(IScreenImage image)
        {
            ShowImage(image, 5);
        }

        public override void Show(IScreenImage image, double brightness)
        {
            ShowImage(image, brightness);
        }
        public override string ToString()
        {
            return "OLED "+base.ToString();
        }
    }
}
