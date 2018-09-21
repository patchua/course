using System;

namespace MobilePhoneCommon
{
    public class SMSProvider
    {
        public delegate void SMSReceivedHandler(string message);
        public event SMSReceivedHandler SMSReceived;
        private delegate void StartSMSGate();
        private bool _createSms;
        public SMSProvider()
        {
            StartSMSGate del = new StartSMSGate(CreateSMS);
            del.BeginInvoke(null, null);
            
        }
        public void CreateSMS()
        {
            RaiseSMSReceived("Starting to generate messages \n");
            _createSms = true;
            var count = 0;
            while (_createSms)
            {
                RaiseSMSReceived($"New message #{++count}! \n");
                System.Threading.Thread.Sleep(2000);
            }
            RaiseSMSReceived("Message genearion has been stopped \n");
        }
        ~SMSProvider()
        {
            _createSms = false;

        }
        private void RaiseSMSReceived(string msg)
        {
            var handler = SMSReceived;
            if (handler != null)
                SMSReceived(msg);
        }
    }

   
}