using Microsoft.VisualStudio.TestTools.UnitTesting;
using MobilePhoneCommon.Chargers;
using MobilePhoneCommonTests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneCommon.Chargers.Tests
{
    [TestClass()]
    public class IphoneChargerTests
    {       

        [TestMethod()]
        public void ChargeTest()
        {
            var fakeOutput = new FakeIOutput();
            var device = new IphoneCharger(fakeOutput);
            device.Charge(new Components.Battery(210, Components.BatteryType.LiFe));
            Assert.AreEqual($"Chraging 210mAh battery. Ready in 100 hours.\n", fakeOutput.result);
        }
    }
}