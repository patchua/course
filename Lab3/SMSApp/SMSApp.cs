using MobilePhoneCommon;
using MobilePhoneCommon.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMSApp
{
    public partial class SMSApp : Form
    {
        private MobilePhone vPhone;
        public SMSApp()
        {
            InitializeComponent();
            InitializeData();
        }

        private void InitializeData()
        {
            var vOutput = new MobilePhoneApp.ConsoleOutput();
            vPhone = new SimCorpMobile(new Battery(3000, BatteryType.LiPo), new Simcard("Vodafone", FormFactor.Nano, NetworkType.LTE), vOutput);

            vPhone.SMSProvider.SMSReceived += SMSProvider_SMSReceived;
        }

        private void SMSProvider_SMSReceived(object sender, string e)
        {
            
            throw new NotImplementedException();
        }
    }
}
