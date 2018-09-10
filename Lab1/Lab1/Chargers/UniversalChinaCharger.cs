﻿using MobilePhoneApp.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneApp.Chargers
{
    class UniversalChinaCharger : ICharge

    {
        public double Voltage
        {
            get
            {
                return 0.5;
            }
        }

        public void Charge(Battery battery)
        {
            Console.WriteLine("Chraging {0}mAh battery. Ready in {1} hours.", battery.Capacity, battery.Capacity / Math.Min(battery.ChargingVoltage, Voltage));
        }
    }
}