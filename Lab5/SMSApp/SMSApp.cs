using MobilePhoneCommon;
using MobilePhoneCommon.Chargers;
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
        private IOutput vOutput = new ConsoleOutput();
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
            vPhone = new SimCorpMobile(new Battery(3000, BatteryType.LiPo), new Simcard("Vodafone", FormFactor.Nano, NetworkType.LTE), vOutput);
            vPhone.TurnOn();
            progressBarCharge.Value = vPhone.Battery.Charge;          
            vFormatters.Add("No Formatting", NoFormat);
            vFormatters.Add("Add time", FormatWithTime);
            vFormatters.Add("Lowercase", LowerCaseFormat);
            vFormatters.Add("Uppercase", UpperCaseFormat);
            comboBoxFormating.DataSource = vFormatters.Keys.ToList();
            messageView.DataSource = new BindingSource(vShownMessageViewList, null);
            vPhone.SMSProvider.SMSReceived += SMSProvider_SMSReceived;
            vPhone.Battery.ChargeChanged += Battery_ChargeChanged;
            messageSender.DataSource = vMessageSenders;            
        }

        private void Battery_ChargeChanged(int value)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<int>(Battery_ChargeChanged), value);
            }
            else
            {
                progressBarCharge.Value = value;
                //Insert  or remove charger  
                if (value <= 0)
                {
                    MessageBox.Show("Battery is empty. Phone would be turned off");
                    vPhone.TurnOff();
                }
                else if ((value < 20) && (vPhone.ChargerComponent == null))
                {
                    MessageBox.Show("Battery is low. Charger would be inserted");
                    vPhone.ChargerComponent = new IphoneCharger(vOutput);
                }
                else if ((value > 80) && (vPhone.ChargerComponent != null))
                {
                    MessageBox.Show("Battery is charged. Charger would be removed");
                    vPhone.ChargerComponent = null;
                }
            }
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
                UpdateShownMessageList();
                              
            }
            
        }

       

        private void UpdateShownMessageList()
        {

            if (applyAllFilters.Checked)
                vShownMessageList = vAllMsgList.Where(m => m.Name == messageSender.SelectedItem as string)
                    .Where(m => m.ReceivingTime > fromDatePicker.Value)
                    .Where(m => m.ReceivingTime < toDatePicker.Value)
                    .Where(m => m.Body.Contains(messageFilter.Text))
                    .ToList();
            else
            {
                vShownMessageList = vAllMsgList.Where(m => m.Name == messageSender.SelectedItem as string).ToList();
                if (fromDatePicker.Checked)
                    vShownMessageList = vShownMessageList.Where(m => m.ReceivingTime > fromDatePicker.Value).ToList();
                if (toDatePicker.Checked)
                    vShownMessageList = vShownMessageList.Where(m => m.ReceivingTime < toDatePicker.Value).ToList();
                if (messageFilter.Text != null)
                    vShownMessageList = vShownMessageList.Where(m => m.Body.Contains(messageFilter.Text)).ToList();
            }
            UpdateMessageView(vShownMessageList);
        }

        private void UpdateMessageView(List<MobilePhoneCommon.SMS.Message> messages)
        {
            vShownMessageViewList.Clear();
            if (messages.Count != 0)
            {
                var formatter = vFormatters.First(f => f.Key == comboBoxFormating.SelectedItem as string).Value;                
                foreach (var msg in messages)
                {
                    var fmsg = (formatter == null) ? msg : formatter(msg);
                    vShownMessageViewList.Add(new MessageView(fmsg));
                }
            }
        }

        private void SMSApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            vPhone.SMSProvider.SMSReceived -= SMSProvider_SMSReceived;
            vPhone.TurnOff();
        }

        private void SMSApp_Load(object sender, EventArgs e)
        {
            var width = CalcDropDownWidth(comboBoxFormating);          
            comboBoxFormating.Width = width;
            fromDatePicker.Checked = false;
            toDatePicker.Checked = false;
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
            //To bring some kind of structure to this GUI
            toDatePicker.Checked = applyAllFilters.Checked;
            fromDatePicker.Checked = applyAllFilters.Checked;
            UpdateShownMessageList();
        }

        private void fromDatePicker_ValueChanged(object sender, EventArgs e)
        {
            UpdateShownMessageList();
        }

        private void toDatePicker_ValueChanged(object sender, EventArgs e)
        {
            UpdateShownMessageList();
        }

        private void messageSender_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateShownMessageList();
        }

        private void messageFilter_TextChanged(object sender, EventArgs e)
        {
            UpdateShownMessageList();
        }

        private void btnSMS_Click(object sender, EventArgs e)
        {
            if (btnSMS.Text.Contains("Start"))
            {
                btnSMS.Text = "Stop SMS";
                vPhone.SMSProvider.Start();
            }
            else
            {
                btnSMS.Text = "Start SMS";
                vPhone.SMSProvider.Stop();
            }
        }
    }
}
