using MobilePhoneApp.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneApp.PlaybackDevices
{
    class IphoneOriginalHeadphones : IPlayback
    {
        private IOutput Output;
        public IphoneOriginalHeadphones(IOutput output)
        {
            Output = output;
        }
        public void Play(object data)
        {
            Output.WriteLine($"{nameof(IphoneOriginalHeadphones)} is playing sound");
        }
    }
}
