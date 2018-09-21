using MobilePhoneCommon.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneCommonTests
{
    public class FakeIOutput : IOutput
    {
        public string result;
        public FakeIOutput()
        {
            result = "";
        }
        public void Write(string text)
        {
            result = result + text;
        }

        public void WriteLine(string text)
        {
            result = result + text +"\n";
        }
    }
}
