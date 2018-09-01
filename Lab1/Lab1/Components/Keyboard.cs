using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Components
{
    public class Keyboard
    {
        public int NumberOfKeys { get; set; }
        public CultureInfo Culture  { get; set; }
        public override string ToString()
        {
            return "Keyboard";
        }
    }
}
