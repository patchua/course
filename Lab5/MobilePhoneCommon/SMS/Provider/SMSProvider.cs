using System;
using System.Threading;

namespace MobilePhoneCommon.SMS.Provider
{
    public class SMSProvider:SMSProviderBase
    {
        public override void Start()
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

        public override void Stop()
        {
            _createSMS = false;
        }
    }

   
}