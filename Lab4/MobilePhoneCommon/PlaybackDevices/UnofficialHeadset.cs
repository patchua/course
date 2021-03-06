﻿using MobilePhoneCommon.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneCommon.PlaybackDevices
{
   public  class UnofficialHeadset : IPlayback
    {
        private IOutput Output;
        public UnofficialHeadset(IOutput output)
        {
            Output = output;
        }
        public void Play(object data)
        {
            Output.WriteLine($"{nameof(UnofficialHeadset)} is playing sound");
        }
    }
}
