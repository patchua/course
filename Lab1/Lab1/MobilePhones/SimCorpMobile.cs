using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilePhoneApp.Components;
using System.Globalization;

namespace MobilePhoneApp
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

        public SimCorpMobile(Battery battery, Simcard simcard,IOutput output) : base(battery, simcard,output)
        {
            vRetinaScreen = new RetinaScreen(1.2,2.5,300,30000,output);
            vIlluminatedKeyboard = new IlluminatedKeyboard(102, new CultureInfo("ua-UA",false));
        }
    }
}
