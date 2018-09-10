using MobilePhoneApp.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneApp.OtherDevices
{
    class CarAudio : IPlayback, ICharge
    {
        private IOutput Output;
        public CarAudio(IOutput output)
        {
            Output = output;
        }
        public double Voltage
        {
            get
            {
                return 5;
            }
        }

        public void Charge(Battery battery)
        {
           Output.WriteLine($"Chraging {battery.Capacity}mAh battery. Ready in {battery.Capacity / Math.Min(battery.ChargingVoltage, Voltage)} hours.");
        }

        public void Play(object data)
        {
            Output.WriteLine($"{nameof(CarAudio)} is playing sound") ;
        }
    }
}
