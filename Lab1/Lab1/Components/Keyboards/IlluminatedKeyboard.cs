using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneApp.Components
{
    class IlluminatedKeyboard:Keyboard
    {
        public IlluminatedKeyboard(int numOfKeys, CultureInfo culture) : base(numOfKeys, culture)
        {
            _brightness = 0.5;
        }

        public Double Brightness {
            get
            {
                return _brightness;
            }
            set
            {

                if (value < 0)
                {
                    _brightness = 0;
                }
                else if (value > 1)
                {
                    _brightness = 1;
                }
                else
                {
                    _brightness = value;
                }
            }
        }

        public override string ToString()
        {
            return base.ToString() + " with Illumination";
        }
        private Double _brightness;
    }
}
