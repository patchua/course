using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            //WHEN
            var output = Formatting.NoFormat(text);
            //THEN
            Assert.AreEqual(text, output);
        }

        [TestMethod()]
        public void UpperCaseFormatTest()
        {
            //GIVEN
            var text = "Simple Text";
            //WHEN
            var output = Formatting.UpperCaseFormat(text);
            //THEN
            Assert.AreEqual("SIMPLE TEXT", output);
        }
    }
}