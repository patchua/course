using MobilePhoneCommon;
using MobilePhoneCommon.Components;
using MobilePhoneCommon.SMS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using static SMSApp.Formatting;


namespace SMSApp
{
    public partial class SMSApp : Form
    {
        private MobilePhone vPhone;
        
        private Dictionary<string, FormatterDelegate> vFormatters= new Dictionary<string, FormatterDelegate>();
        private List<MobilePhoneCommon.SMS.Message> vAllMsgList;
        private List<MobilePhoneCommon.SMS.Message> vShownMessageList;
        private BindingList<string> vMessageSenders;
       
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

            vAllMsgList = new List<MobilePhoneCommon.SMS.Message>();
            vShownMessageList = new List<MobilePhoneCommon.SMS.Message>();
            vMessageSenders = new BindingList<string>();
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
                PrepareShownList();
                             
            }
            
        }

        private void PrepareShownList()
        {                        
            var msgList = new List<MobilePhoneCommon.SMS.Message>();
            if (applyAllFilters.CheckState == CheckState.Checked)
            {
                msgList = vAllMsgList
                    .Where(m => 
                    (m.Name == messageSender.SelectedItem as string) 
                    && (m.ReceivingTime > fromDatePicker.Value) 
                    && (m.ReceivingTime < toDatePicker.Value) 
                    && (m.Body.Contains(messageFilter.Text)))
                    .ToList();                
            }

            if (!EqualLists(msgList, vShownMessageList))
            {
                vShownMessageList = new List<MobilePhoneCommon.SMS.Message>(msgList);
                UpdateShownMessages();
            }
        }

        private void UpdateShownMessages()
        {
            messageListView.Clear();
            var formatter = vFormatters.First(f => f.Key == comboBoxFormating.SelectedItem as string).Value;
            string  body;
            foreach (MobilePhoneCommon.SMS.Message msg in vShownMessageList)
            {
                body = msg.Body;
                if (formatter != null)
                    body = formatter(body);
                messageListView.Items.Add(new ListViewItem(new[] { msg.Name, body }));
            }

        }

        public static bool EqualLists<T>(List<T> aListA, List<T> aListB)
        {
            if (aListA == null || aListB == null || aListA.Count != aListB.Count)
                return false;
            if (aListA.Count == 0)
                return true;
            Dictionary<T, int> lookUp = new Dictionary<T, int>();
            // create index for the first list
            for (int i = 0; i < aListA.Count; i++)
            {
                int count = 0;
                if (!lookUp.TryGetValue(aListA[i], out count))
                {
                    lookUp.Add(aListA[i], 1);
                    continue;
                }
                lookUp[aListA[i]] = count + 1;
            }
            for (int i = 0; i < aListB.Count; i++)
            {
                int count = 0;
                if (!lookUp.TryGetValue(aListB[i], out count))
                {
                    // early exit as the current value in B doesn't exist in the lookUp (and not in ListA)
                    return false;
                }
                count--;
                if (count <= 0)
                    lookUp.Remove(aListB[i]);
                else
                    lookUp[aListB[i]] = count;
            }
            // if there are remaining elements in the lookUp, that means ListA contains elements that do not exist in ListB
            return lookUp.Count == 0;
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
