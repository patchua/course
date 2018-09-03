using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab1.Components;

namespace Lab1
{
    class Nokia3310 : MobilePhone
    {
        public override ScreenBase Screen
        {
            get
            {
                return vMonochromeScreen;
            }
        }

        public override Keyboard Keyboard
        {
            get
            {
                return vKeyboard;
            }
        }
        public Nokia3310(Battery battery, Simcard simcard):base(battery,simcard)
        {
            vMonochromeScreen = new MonochromeScreen();
            vKeyboard = new Keyboard(103, new System.Globalization.CultureInfo("us-US",false));
  
        }
        private readonly MonochromeScreen vMonochromeScreen;
        private readonly Keyboard vKeyboard;
    }
}
