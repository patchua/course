using Microsoft.VisualStudio.TestTools.UnitTesting;
using MobilePhoneCommon;
using MobilePhoneCommon.SMS;
using MobilePhoneCommon.SMS.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneCommon.Tests
{
    [TestClass()]
    public class SMSProviderTests
    {
        [TestMethod()]
        public void SMSProviderEventTest()
        {
           Message result= null;        
            var smsProvider = new SMSProvider();
            //GIVEN
            smsProvider.SMSReceived += (s) => { result = s; };

            //WHEN
            smsProvider.Start();
            //THEN
            Assert.IsNull(result);
        }
    }
}