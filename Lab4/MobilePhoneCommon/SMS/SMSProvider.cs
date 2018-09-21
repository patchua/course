using System;

namespace MobilePhoneCommon.SMS
{
    public class SMSProvider
    {
        public delegate void SMSReceivedHandler(Message message);
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
            var msgGenerator = new RandomMessageGenerator();
            while (_createSms)
            {
                RaiseSMSReceived(msgGenerator.Next());
                System.Threading.Thread.Sleep(2000);
            }
        }
        

        ~SMSProvider()
        {
            _createSms = false;

        }
        private void RaiseSMSReceived(Message msg)
        {
            var handler = SMSReceived;
            if (handler != null)
                SMSReceived(msg);
        }

       
    }

   
}