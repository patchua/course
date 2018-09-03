using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Components
{
    public class Battery
    {
        public int Capacity { get; }
        public BatteryType Type { get;  }
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
