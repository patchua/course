using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab1.Components;

namespace Lab1
{
    class SimCorpMobile : MobilePhone
    {
        public override ScreenBase Screen
        {
            get
            {
                return vRetinaScreen ;
            }
        }

        public override Keyboard Keyboard
        {
            get
            {
                return vVirtualKeyboard ;
            }
        }
        private readonly RetinaScreen vRetinaScreen = new RetinaScreen();
        private readonly VirtualKeyboard vVirtualKeyboard = new VirtualKeyboard();
    }
}
