﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneApp.Components
{
    public interface ICharge
    {
        void Charge(Battery battery);
        
        double Voltage { get;  }
    }
}
