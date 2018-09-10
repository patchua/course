using Microsoft.VisualStudio.TestTools.UnitTesting;
using MobilePhoneCommon.PlaybackDevices;
using MobilePhoneCommonTests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneCommon.PlaybackDevices.Tests
{
    [TestClass()]
    public class IphoneOriginalHeadphonesTests
    {
        [TestMethod()]
        public void PlayTest()
        {
            var fakeOutput = new FakeIOutput();
            var device = new IphoneOriginalHeadphones(fakeOutput);
            device.Play(new object());
            Assert.AreEqual("IphoneOriginalHeadphones is playing sound\n", fakeOutput.result);

        }
    }
}