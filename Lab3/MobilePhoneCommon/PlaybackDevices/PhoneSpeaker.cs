using MobilePhoneCommon.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneCommon.PlaybackDevices
{
    public class PhoneSpeaker : IPlayback
    {
        private IOutput Output;
        public PhoneSpeaker(IOutput output)
        {
            Output = output;
        }
        public void Play(object data)
        {
            Output.WriteLine($"{nameof(PhoneSpeaker)} is playing sound");
        }
    }
}
