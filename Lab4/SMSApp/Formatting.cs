using MobilePhoneCommon.SMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSApp
{
    public static  class Formatting
    {
        private static Message CopyMessage(Message message)
        {
            Message newMessage = new Message();
            newMessage.Name = message.Name;
            newMessage.Operator = message.Operator;
            newMessage.ReceivingTime = message.ReceivingTime;
            newMessage.Body = message.Body;
            return newMessage;
        }
        public delegate Message FormattingDelegate(Message message);
         public static Message FormatWithTime(Message message)
        {
            var nMessage = CopyMessage(message);
            nMessage.Body=$"[{message.ReceivingTime}] {message.Body}";
            return nMessage;
        }

         public static Message NoFormat(Message message)
        {
            return CopyMessage(message);
        }
         public static Message UpperCaseFormat(Message message)
        {
            var nMessage = CopyMessage(message);
            nMessage.Body=nMessage.Body.ToUpper();
            return nMessage;
        }
         public static Message LowerCaseFormat(Message message)
        {
            var nMessage = CopyMessage(message);
            nMessage.Body=nMessage.Body.ToLower();
            return nMessage;
        }
    }
}
