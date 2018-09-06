using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneApp.Components
{
    public abstract class ScreenBase:IScreenImage
    {
        public int Resolution { get;private  set; }
        public double Size { get
            {
                return Hight * Width;
            }
        }

        public ScreenBase(double hight, double width, int resolution)
        {
            Hight = hight;
            Width = width;
            Resolution = resolution;
        }
        public double Hight { get; private set; }
        public double Width { get; private set; }

        public abstract void Show(IScreenImage image);
    }
}
