using System;
using System.Threading;

namespace MobilePhoneCommon.SMS
{
    public class SMSProvider
    {
        public delegate void SMSReceivedHandler(Message message);
        public event SMSReceivedHandler SMSReceived;       
        private bool _createSMS;       
       
        public void Start()
        {
            _createSMS= true;            
            try
            {
                Thread thread = new Thread(CreateSMS);
                thread.Start();
            }
            catch (ThreadStateException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        public void Stop()
        {
            _createSMS = false;
        }

        private void CreateSMS()
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