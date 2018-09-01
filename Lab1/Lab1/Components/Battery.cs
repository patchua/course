using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Components
{
    public class Battery
    {
        public int Capacity { get; set; }
        public string Type { get; set; }

        public override string ToString()
        {
            return "Battery";
        }
    }
}
