using MobilePhoneCommon;
using MobilePhoneCommon.Components;
using MobilePhoneCommon.SMS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using static SMSApp.Formatting;
using static System.Windows.Forms.ListViewItem;

namespace SMSApp
{
    public partial class MainForm : Form
    {
        private MobilePhone vPhone;
        
        private Dictionary<string, FormattingDelegate> vFormatters= new Dictionary<string, FormattingDelegate>();
        private List<MobilePhoneCommon.SMS.Message> vAllMsgList = new List<MobilePhoneCommon.SMS.Message>();
        private BindingList<string> vMessageSenders = new BindingList<string>();
        private List<MobilePhoneCommon.SMS.Message> vShownMessageList = new List<MobilePhoneCommon.SMS.Message>();
        private BindingList<MessageView> vShownMessageViewList= new BindingList<MessageView>();
        
        public MainForm()
        {
            InitializeComponent();
            InitializeData();
        }

        private void InitializeData()
        {
            var vOutput = new ConsoleOutput();
            vPhone = new SimCorpMobile(new Battery(3000, BatteryType.LiPo), new Simcard("Vodafone", FormFactor.Nano, NetworkType.LTE), vOutput);
            vFormatters.Add("No Formatting", NoFormat);
            vFormatters.Add("Add time", FormatWithTime);
            vFormatters.Add("Lowercase", LowerCaseFormat);
            vFormatters.Add("Uppercase", UpperCaseFormat);
            comboBoxFormating.DataSource = vFormatters.Keys.ToList();
            messageView.DataSource = new BindingSource(vShownMessageViewList, null);
            vPhone.SMSProvider.SMSReceived += SMSProvider_SMSReceived;

            messageSender.DataSource = vMessageSenders;
        }
        
        private void SMSProvider_SMSReceived(MobilePhoneCommon.SMS.Message msg)
        {
            if (IsDisposed) return;

            if (InvokeRequired)
            {
                Invoke(new SMSProvider.SMSReceivedHandler(SMSProvider_SMSReceived), msg);
            }
            else

            {
                vAllMsgList.Add(msg);
                if (!vMessageSenders.Contains(msg.Name))
                    vMessageSenders.Add(msg.Name);
                UpdateShownMessageView();
                              
            }
            
        }

       

        private void UpdateShownMessageView()
        {
       
            if (applyAllFilters.Checked)
                vShownMessageList = vAllMsgList.Where(m => m.Name == messageSender.SelectedItem as string)
                    .Where(m => m.ReceivingTime > fromDatePicker.Value)
                    .Where(m => m.ReceivingTime < toDatePicker.Value)
                    .Where(m => m.Body.Contains(messageFilter.Text))
                    .ToList();
            else
                vShownMessageList = vAllMsgList.Where(m => (m.Name == messageSender.SelectedItem as string) ||
                     (m.ReceivingTime > fromDatePicker.Value) ||
                     (m.ReceivingTime < toDatePicker.Value) ||
                     (m.Body.Contains(messageFilter.Text)))
                     .ToList();

            var formatter = vFormatters.First(f => f.Key == comboBoxFormating.SelectedItem as string).Value;
            vShownMessageViewList.Clear();
            foreach (var msg in vShownMessageList)
            {
                var fmsg = (formatter == null) ? msg : formatter(msg);
                vShownMessageViewList.Add(new MessageView(fmsg));
            }
        }

        private bool EqualList<T>(List<T> listA, List<T> listB)
        {
            if (listA == null || listB == null)
                return false;

            if (listA.Count != listB.Count)
                return false;

            foreach (var elm in listA)
                if (!listB.Contains(elm))
                    return false;

            foreach (var elm in listB)
                if (!listA.Contains(elm))
                    return false;
            return true;
        }


        private void SMSApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            vPhone.SMSProvider.SMSReceived -= SMSProvider_SMSReceived;
        }

        private void SMSApp_Load(object sender, EventArgs e)
        {
            var width = CalcDropDownWidth(comboBoxFormating);          
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
        private class MessageView
        {

            public MessageView(MobilePhoneCommon.SMS.Message msg)
            {
                Name = msg.Name;
                Text = msg.Body;
            }

            public string  Name { get; set; }
            public string Text { get; set; }
        }

        private void applyAllFilters_CheckedChanged(object sender, EventArgs e)
        {
            UpdateShownMessageView();
        }

        private void fromDatePicker_ValueChanged(object sender, EventArgs e)
        {
            UpdateShownMessageView();
        }

        private void toDatePicker_ValueChanged(object sender, EventArgs e)
        {
            UpdateShownMessageView();
        }

        private void messageSender_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateShownMessageView();
        }

        private void messageFilter_TextChanged(object sender, EventArgs e)
        {
            UpdateShownMessageView();
        }
    }
}
