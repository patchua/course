using Microsoft.VisualStudio.TestTools.UnitTesting;
using MobilePhoneCommon;
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
           string result= null;        
            var smsProvider = new SMSProvider();
            //GIVEN
            smsProvider.SMSReceived += (s) => { result = s; };

            //WHEN
            //Event creation is started right in the constructor

            //THEN
            Assert.IsNull(result);
        }
    }
}