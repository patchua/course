using Lab1.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.PlaybackDevices
{
    class IphoneOriginalHeadphones : IPlayback
    {
        public void Play(object data)
        {
            Console.WriteLine("{0} is playing sound",nameof(IphoneOriginalHeadphones));
        }
    }
}
