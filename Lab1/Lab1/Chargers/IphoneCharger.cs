﻿using System;
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
            Console.WriteLine("Chraging {0}mAh battery. Ready in {1} hours.", battery.Capacity, battery.Capacity / Math.Min(battery.ChargingVoltage, Voltage));
        }
    }
}
