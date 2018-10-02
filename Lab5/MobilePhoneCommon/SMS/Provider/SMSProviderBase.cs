using System;
using System.Threading;

namespace MobilePhoneCommon.SMS
{
    public abstract class SMSProviderBase
    {
        public delegate void SMSReceivedHandler(Message message);
        public event SMSReceivedHandler SMSReceived;       
        protected bool _createSMS;

        public abstract void Start();

        public abstract void Stop();
        
        protected void CreateSMS()
        {
            var msgGenerator = new RandomMessageGenerator();            
            while (_createSMS)
            {
                    RaiseSMSReceived(msgGenerator.Next());
                    Thread.Sleep(2000);
            }
        }
        
        private void RaiseSMSReceived(Message msg)
        {
            var handler = SMSReceived;
            if (handler != null)
                SMSReceived(msg);
        }

       
    }

   
}