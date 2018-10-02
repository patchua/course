using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilePhoneCommon.Components;
using System.Threading;

namespace MobilePhoneCommon.Chargers
{
    public class IphoneCharger : ICharge
    {
        private bool _doCharge;
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
            _doCharge = true;
            new Thread(() =>
            {
                while (_doCharge)                
                    lock (battery)
                    {
                        battery.Charge += (int)Voltage;
                        Thread.Sleep(1000);
                    }                
            }).Start();
        }
        ~IphoneCharger()
        {
            _doCharge = false;
        }
    }
}
