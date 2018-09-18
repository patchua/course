using System;

namespace MobilePhoneCommon
{
    public class SMSProvider
    {
        public event EventHandler<string> SMSReceived;
        public void CreateSMS(string text)
        {
            RaiseSMSReceived(text);
        }
        private void RaiseSMSReceived(string msg)
        {
            SMSReceived?.Invoke(this,msg);
        }
    }
}