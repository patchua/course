using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneApp.Components
{
    public class Battery
    {
        public int Capacity { get; }
        public BatteryType Type { get;  }
        public double ChargingVoltage { get
            {
                switch (Type)
                {
                    case BatteryType.LiFe :  return 2.1;

                    case BatteryType.LiPo : return 3.05;

                    case BatteryType.NiMg : return 4;
                    default: return 1;
                }
            }
        }
        public Battery(int cap, BatteryType type)
        {
            Capacity = cap;
            Type = type;
        }

        public override string ToString()
        {
            return Type.ToString()+" "+Capacity.ToString() + "mAh";
        }
    }

    public enum BatteryType
    {
        LiPo,
        NiMg,
        LiFe

    }
     
}
