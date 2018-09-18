using MobilePhoneCommon;
using MobilePhoneCommon.Chargers;
using MobilePhoneCommon.Components;
using MobilePhoneCommon.OtherDevices;
using MobilePhoneCommon.PlaybackDevices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class MainWindow : Form
    {
        private List<ICharge> vChargers;
        private List<IPlayback> vPlaybackDevices;
        private IOutput vOutput;
        private MobilePhone vMobilePhone;
        public MainWindow()
        {
            InitializeComponent();
            InitializeData();
        }

        private void InitializeData()
        {
            vOutput = new TextBoxOutput(textBoxOutput);

            vMobilePhone= new SimCorpMobile(new Battery(3000, BatteryType.LiPo), new Simcard("Vodafone", FormFactor.Nano, NetworkType.LTE), vOutput);

            vPlaybackDevices = new List<IPlayback>();
            vPlaybackDevices.Add(new IphoneOriginalHeadphones(vOutput));
            vPlaybackDevices.Add(new UnofficialHeadset(vOutput));

            vChargers = new List<ICharge>();
            vChargers.Add(new IphoneCharger(vOutput));
            vChargers.Add(new SmartCharger(vOutput));
            vChargers.Add(new UniversalChinaCharger(vOutput));

            var carAudioDevice = new CarAudio(vOutput); //This device has both interfaces
            vPlaybackDevices.Add(carAudioDevice);
            vChargers.Add(carAudioDevice);

            //Bind data
            populateGroup(vChargers,groupBoxChargers);
            populateGroup(vPlaybackDevices, groupBoxPlaybackDevices);            

        }

        private void populateGroup(IEnumerable list, GroupBox groupBox)
        {
            int i = 0;
            foreach (var item in list)
            {
                var rb = new RadioButton();
                rb.Text = item.ToString();                
                rb.Location = new Point(10, 30+i*20);
                rb.Size = new Size(500, 20);
                groupBox.Controls.Add(rb);
                i++;
            }

        }


        private void btnApplyCharger_Click(object sender, EventArgs e)
        {
            var checkedCharger = groupBoxChargers.Controls.OfType<RadioButton>()
                                       .FirstOrDefault(r => r.Checked);
            if (checkedCharger != null)
            {
                var charger = vChargers.Find(c => String.Equals(c.ToString(), checkedCharger.Text));
                if (vMobilePhone.ChargerComponent!= null)
                    vMobilePhone.ChargerComponent = null;
                vMobilePhone.ChargerComponent = charger;
            }            
        }

        private void btnApplyAudio_Click(object sender, EventArgs e)
        {
            var checkedPlayback = groupBoxPlaybackDevices.Controls.OfType<RadioButton>()
                                       .FirstOrDefault(r => r.Checked);
            if (checkedPlayback != null)
            {
                var playback = vPlaybackDevices.Find(c => String.Equals(c.ToString(), checkedPlayback.Text));
                vMobilePhone.PlaybackComponent = playback;
                vMobilePhone.Play(new object());
            }
        }
    }

    internal class TextBoxOutput:IOutput
    {
        private TextBox vControl;
        public TextBoxOutput(TextBox control)
        {
            vControl = control;
        }

        public void Write(string text)
        {
            vControl.AppendText(text);        }

        public void WriteLine(string text)
        {
            vControl.AppendText(text + "\n");
        }
    }
}
