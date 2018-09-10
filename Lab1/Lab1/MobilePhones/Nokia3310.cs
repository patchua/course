using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilePhoneApp.Components;

namespace MobilePhoneApp
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
        public Nokia3310(Battery battery, Simcard simcard, IOutput output):base(battery,simcard,output)
        {
            vMonochromeScreen = new MonochromeScreen(60,70,60,output);
            vKeyboard = new Keyboard(103, new System.Globalization.CultureInfo("us-US",false));
  
        }
        private readonly MonochromeScreen vMonochromeScreen;
        private readonly Keyboard vKeyboard;       
    }
}
