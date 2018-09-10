using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilePhoneApp.Components;

namespace MobilePhoneApp.Chargers
{
    public class IphoneCharger : ICharge
    {
        private IOutput Output;
        public IphoneCharger(IOutput output)
        {
            Output = output;
        }
        public double Voltage
        {
            get
            {
                return 3;
            }

            
        }

        public void Charge(Battery battery)
        {
            Output.WriteLine($"Chraging {battery.Capacity}mAh battery. Ready in {battery.Capacity / Math.Min(battery.ChargingVoltage, Voltage)} hours.");
        }
    }
}
