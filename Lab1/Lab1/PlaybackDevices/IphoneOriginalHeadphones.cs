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
        public void Play(object data)
        {
            Console.WriteLine("{0} is playing sound",nameof(IphoneOriginalHeadphones));
        }
    }
}
