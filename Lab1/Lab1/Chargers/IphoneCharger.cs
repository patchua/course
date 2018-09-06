using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilePhoneApp.Components;

namespace MobilePhoneApp.Chargers
{
    class IphoneCharger : ICharge
    {
        public double Voltage
        {
            get
            {
                return 3;
            }

            
        }

        public void Charge(Battery battery)
        {
            throw new NotImplementedException();
        }
    }
}
