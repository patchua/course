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

        private readonly MonochromeScreen vMonochromeScreen = new MonochromeScreen();
        private readonly Keyboard vKeyboard = new Keyboard();
    }
}
