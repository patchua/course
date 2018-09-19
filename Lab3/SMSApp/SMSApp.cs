using MobilePhoneCommon;
using MobilePhoneCommon.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SMSApp
{
    public partial class SMSApp : Form
    {
        private MobilePhone vPhone;
        private delegate string FormatterDelegate(string text);
        private Dictionary<string, FormatterDelegate> vFormatters= new Dictionary<string, FormatterDelegate>();
       
        public SMSApp()
        {
            InitializeComponent();
            InitializeData();
        }

        private void InitializeData()
        {
            var vOutput = new MobilePhoneApp.ConsoleOutput();
            vPhone = new SimCorpMobile(new Battery(3000, BatteryType.LiPo), new Simcard("Vodafone", FormFactor.Nano, NetworkType.LTE), vOutput);
            vFormatters.Add("No Formatting", new FormatterDelegate(NoFormat));
            vFormatters.Add("Add time", new FormatterDelegate(FormatWithTime));
            vFormatters.Add("Lowercase", new FormatterDelegate(LowerCaseFormat));
            vFormatters.Add("Uppercase", new FormatterDelegate(UpperCaseFormat));
            comboBoxFormating.DataSource = vFormatters.Keys.ToList();

            vPhone.SMSProvider.SMSReceived += SMSProvider_SMSReceived;
            
            
        }
        private static string FormatWithTime(string text)
        {
            return $"[{DateTime.Now}] {text}";
        }

        private static string NoFormat(string text)
        {
            return text;
        }
        private static string UpperCaseFormat(string text)
        {
            return text.ToUpper();
        }
        private static string LowerCaseFormat(string text)
        {
            return text.ToLower();
        }
        private void SMSProvider_SMSReceived( string e)
        {
            if (IsDisposed) return;

            if (InvokeRequired)
            {
                Invoke(new SMSProvider.SMSReceivedHandler(SMSProvider_SMSReceived), e);
            }
            else

            {
                var formatter = vFormatters.First(f => f.Key == comboBoxFormating.SelectedItem as string).Value;
                if (formatter!=null )
                    e = formatter(e);
                txtBox.AppendText(e);
            }
            
        }

        private void SMSApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            vPhone.SMSProvider.SMSReceived -= SMSProvider_SMSReceived;
        }

        private void SMSApp_Load(object sender, EventArgs e)
        {
            var width = CalcDropDownWidth(comboBoxFormating);
           // comboBoxFormating.DropDownWidth = width;
            comboBoxFormating.Width = width;
        }

        private int CalcDropDownWidth(ComboBox comboBox)
        {
            int maxWidth = 0;
            int temp = 0;
            Label label = new Label();

            foreach (var obj in comboBox.Items)
            {
                label.Text = obj.ToString();
                temp = label.PreferredWidth;
                if (temp > maxWidth)
                {
                    maxWidth = temp;
                }
            }
            label.Dispose();
            return maxWidth;
        }
    }
}
