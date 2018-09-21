using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneCommon.SMS
{
    public class Message
    {
        public string  Name { get; set; }
        public string  Body { get; set; }
        public DateTime ReceivingTime { get; set; }
        public string Operator { get; set; }
    }
}
