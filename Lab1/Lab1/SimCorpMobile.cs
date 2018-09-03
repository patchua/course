using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab1.Components;
using System.Globalization;

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
                return vIlluminatedKeyboard ;
            }
        }
        private readonly RetinaScreen vRetinaScreen;
        private readonly IlluminatedKeyboard vIlluminatedKeyboard ;

        public SimCorpMobile(Battery battery, Simcard simcard) : base(battery, simcard)
        {
            vRetinaScreen = new RetinaScreen();
            vIlluminatedKeyboard = new IlluminatedKeyboard(102, new CultureInfo("ua-UA",false));
        }
    }
}
