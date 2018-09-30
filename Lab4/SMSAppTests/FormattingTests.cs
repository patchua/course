using Microsoft.VisualStudio.TestTools.UnitTesting;
using MobilePhoneCommon.SMS;
using SMSApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSApp.Tests
{
    [TestClass()]
    public class FormattingTests
    {
        [TestMethod()]
        public void NoFormatTest()
        {
            //GIVEN
            var text = "Simple Text";
            Message msg = new Message();
            msg.Body = text;
            //WHEN
            var output = Formatting.NoFormat(msg).Body;
            //THEN
            Assert.AreEqual(text, output);
        }

        [TestMethod()]
        public void UpperCaseFormatTest()
        {
            //GIVEN
            var text = "Simple Text";
            Message msg = new Message();
            msg.Body = text;

            //WHEN
            var output = Formatting.UpperCaseFormat(msg).Body;
            //THEN
            Assert.AreEqual("SIMPLE TEXT", output);
        }
    }
}