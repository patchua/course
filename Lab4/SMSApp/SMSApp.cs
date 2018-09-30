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
    public partial class SMSApp : Form
    {
        private MobilePhone vPhone;
        
        private Dictionary<string, FormatterDelegate> vFormatters= new Dictionary<string, FormatterDelegate>();
        private List<MobilePhoneCommon.SMS.Message> vAllMsgList = new List<MobilePhoneCommon.SMS.Message>();
        private BindingList<string> vMessageSenders = new BindingList<string>();
        private List<MobilePhoneCommon.SMS.Message> vShownMessageList= new List<MobilePhoneCommon.SMS.Message>();
        
        public SMSApp()
        {
            InitializeComponent();
            InitializeData();
        }

        private void InitializeData()
        {
            var vOutput = new ConsoleOutput();
            vPhone = new SimCorpMobile(new Battery(3000, BatteryType.LiPo), new Simcard("Vodafone", FormFactor.Nano, NetworkType.LTE), vOutput);
            vFormatters.Add("No Formatting", new FormatterDelegate(NoFormat));
            vFormatters.Add("Add time", new FormatterDelegate(FormatWithTime));
            vFormatters.Add("Lowercase", new FormatterDelegate(LowerCaseFormat));
            vFormatters.Add("Uppercase", new FormatterDelegate(UpperCaseFormat));
            comboBoxFormating.DataSource = vFormatters.Keys.ToList();

  
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
                UpdateShownMessagesList();
                              
            }
            
        }

        private void UpdateShownMessagesList()
        {
            var messages = vAllMsgList.Where(m => m.Name == messageSender.SelectedItem as string);
            if (!EqualList(messages.ToList(), vAllMsgList))
            {
                vShownMessageList = new List<MobilePhoneCommon.SMS.Message>(messages);
                UpdateShownMessageListView();
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

        private void UpdateShownMessageListView()
        {
            messageListView.Clear();
            var formatter = vFormatters.First(f => f.Key == comboBoxFormating.SelectedItem as string).Value;
            foreach (var msg in vShownMessageList)
            {
                var body = msg.Body;
                if (formatter != null)
                    body = formatter(body);
                ListViewSubItem itm = new ListViewSubItem();
                itm.SubItems.Add(msg.Name);
                itm.SubItems.Add(body);
                //messageListView.Items.Add(new ListViewItem( new[] { msg.Name, body }));
                messageListView.Items.Add(itm);
            }

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
    }
}
