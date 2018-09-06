using MobilePhoneApp.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.OtherDevices
{
    class CarAudio : IPlayback, ICharge
    {
        public double Voltage
        {
            get
            {
                return 5;
            }
        }

        public void Charge(Battery battery)
        {
            Console.WriteLine("Chraging {0}mAh battery. Ready in {1} hours.", battery.Capacity, battery.Capacity / Math.Min(battery.ChargingVoltage, Voltage));
        }

        public void Play(object data)
        {
            Console.WriteLine("{0} is playing sound", nameof(CarAudio)); ;
        }
    }
}
