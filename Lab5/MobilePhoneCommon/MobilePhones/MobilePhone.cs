using MobilePhoneCommon.Components;
using MobilePhoneCommon.SMS;
using System.Text;
using System.Threading;
using System;
using MobilePhoneCommon.SMS.Provider;

namespace MobilePhoneCommon
{
    public abstract class MobilePhone
    {
        private ICharge vChargerComponent;
        private bool _phoneIsOperating;
        public abstract ScreenBase Screen { get; }
        public abstract Keyboard Keyboard { get; }
        public Battery Battery {get; }
        public Simcard Simcard { get;  }
        public IPlayback PlaybackComponent { get; set; }
        public IPlayback Speaker { get;  }
        public ICharge ChargerComponent { get
            {
                return vChargerComponent;
            }
            set
            {
                if (value != null)
                {
                    if (vChargerComponent != null)
                        Screen.Show($"Cannot insert another charger. We already have {vChargerComponent.GetType()} inserted.");
                    else
                    {
                        vChargerComponent = value;
                        vChargerComponent.Charge(Battery);
                    }

                }
                else
                {
                    Screen.Show($"{vChargerComponent.GetType()} charging device has been removed.");
                    vChargerComponent = value;
                }
            } }

        public SMSProviderBase SMSProvider { get; }
        protected MobilePhone( Battery battery, Simcard simcard, IOutput output)
        {
            Battery = battery;
            Simcard = simcard;
            Speaker = new PlaybackDevices.PhoneSpeaker(output);
            SMSProvider = new SMSProvider();                      
        }

        private void DischangeBattery()
        {
            while (_phoneIsOperating)
            {
                lock (Battery)
                {
                    Battery.Charge -= 1;
                    Thread.Sleep(1000);
                }
            }
        }

        private void Show(IScreenImage image)
        {
            Screen.Show(image);
        }

        public string GetDescription()
        {
            var descriptionBuilder = new StringBuilder();
            descriptionBuilder.AppendLine($"ScreenType:{Screen.ToString()}");
            descriptionBuilder.AppendLine($"Battery: {Battery.ToString()}");
            descriptionBuilder.AppendLine($"Keyboard:{Keyboard.ToString()}");
            descriptionBuilder.AppendLine($"SimCard:{ Simcard.ToString()}");
            return descriptionBuilder.ToString();
        }

        public void Play(object data)
        {
            if (PlaybackComponent != null)
                PlaybackComponent.Play(data);
            else
                Speaker.Play(data);
        }

        public void TurnOn()
        {
            _phoneIsOperating = true;
            new Thread(DischangeBattery).Start();
            SMSProvider.Start();
        }
        public void TurnOff()
        {
            _phoneIsOperating = false;
            SMSProvider.Stop();
        }
    }
}
