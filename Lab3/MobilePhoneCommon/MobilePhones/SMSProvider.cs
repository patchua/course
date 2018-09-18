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
            _createSms = true;
            while (_createSms)
            {
                RaiseSMSReceived("New message!");
                System.Threading.Thread.Sleep(1000);
            }
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