
using MobilePhoneCommon.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneCommon.Chargers
{
    public class UniversalChinaCharger : ICharge

    {
        private IOutput Output;
       public  UniversalChinaCharger(IOutput output)
        {
            Output = output;
        }
        public double Voltage
        {
            get
            {
                return 0.5;
            }
        }

        public void Charge(Battery battery)
        {
            Output.WriteLine($"Chraging {battery.Capacity}mAh battery. Ready in {battery.Capacity / Math.Min(battery.ChargingVoltage, Voltage)} hours.");
        }
    }
}
