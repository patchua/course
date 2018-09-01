using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Components
{
    class VirtualKeyboard:Keyboard
    {
        public PlatformID SuportedPlatforms { get; }

        public override string ToString()
        {
            return "Virtual " + base.ToString();
        }
    }
}
