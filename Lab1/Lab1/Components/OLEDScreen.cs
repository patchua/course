using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Components
{
    class OLEDScreen:ColourScreen
    {
        private void ShowImage(IScreenImage image, int brightness)
        {
            //implementation
        }
        public override void Show(IScreenImage image)
        {
            ShowImage(image, 5);
        }

        public override void Show(IScreenImage image, int brightness)
        {
            ShowImage(image, brightness);
        }
        public override string ToString()
        {
            return "OLED"+base.ToString();
        }
    }
}
