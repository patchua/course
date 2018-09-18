using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneCommon.Components
{
    public class Keyboard
    {
        public int NumberOfKeys { get; }
        public CultureInfo Culture  { get; set; }

        public Keyboard(int numOfKeys, CultureInfo culture)
        {
            NumberOfKeys = numOfKeys;
            Culture = culture;
        }

        public override string ToString()
        {
            return Culture.EnglishName.ToString() + " "+ NumberOfKeys.ToString() + " keys";

        }
    }
}
