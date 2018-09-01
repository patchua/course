using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Components
{
    class RetinaScreen : ColourScreen
    {
        private void ShowImageOnRetina(IScreenImage image, int brightness)
        {
            //implementation
        }
        public override void Show(IScreenImage image)
        {
            ShowImageOnRetina(image, 5);
        }

        public override void Show(IScreenImage image, int brightness)
        {
            ShowImageOnRetina(image, brightness);
        }
        public override string ToString()
        {
            return "Retina"+base.ToString();
        }
    }
}
