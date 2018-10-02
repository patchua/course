using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneCommon.Components
{
    public class Battery
    {
        public event Action<int> ChargeChanged;
        private int _charge;
        public int Charge {
            get
            {
                return _charge;
            }

            set
            {
                OnChargeChanged();
                _charge = value;
            }
        }

        private void OnChargeChanged()
        {
            var handler = ChargeChanged;
            if (handler != null)
                ChargeChanged(_charge);
        }
    
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
            _charge = 30;
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
