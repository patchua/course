using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Components
{
    class IlluminatedKeyboard:Keyboard
    {
        public Double Brightness { get; set; }
        public override string ToString()
        {
            return base.ToString() + " with Illumination";
        }
    }
}
