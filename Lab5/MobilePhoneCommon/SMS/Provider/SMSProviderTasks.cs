using System;
using System.Threading;

namespace MobilePhoneCommon.SMS.Provider
{
    public class SMSProviderTasks:SMSProviderBase
    {
         
        public override void Start()
        {
            _createSMS= true;            
            //TASK should be used here
            
        }
        public override void Stop()
        {
            _createSMS = true;
        }
       
    }

   
}