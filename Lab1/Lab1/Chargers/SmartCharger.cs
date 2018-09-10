using MobilePhoneApp.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneApp.Chargers
{
    class SmartCharger : ICharge

    {
        private IOutput Output;
        public SmartCharger(IOutput output)
        {
            Output = output;
        }
        public double Voltage
        {
            get
            {
                return 0;
            }
        }

        public void Charge(Battery battery)
        {
       
            Output.WriteLine($"Chraging {battery.Capacity}mAh battery. Ready in {battery.Capacity / battery.ChargingVoltage} hours.");
        }
    }
}
