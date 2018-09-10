using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneApp.Components
{
    public abstract class ScreenBase:IScreenImage
    {
        private IOutput Output;
       
        public int Resolution { get;private  set; }
        public double Size { get
            {
                return Hight * Width;
            }
        }

        public ScreenBase(double hight, double width, int resolution, IOutput output)
        {
            Hight = hight;
            Width = width;
            Resolution = resolution;
            Output = output;
        }
        public double Hight { get; private set; }
        public double Width { get; private set; }

        public abstract void Show(IScreenImage image);
        public void Show(string text)
        {
            Output.WriteLine(text);
        }
    }
}
