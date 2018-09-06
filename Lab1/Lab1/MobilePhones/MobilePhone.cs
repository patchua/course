﻿using MobilePhoneApp.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneApp
{
    public abstract class MobilePhone:IPlayback,ICharge 
    {
        public abstract ScreenBase Screen { get; }
        public abstract Keyboard Keyboard { get; }
        public Battery Battery {get; }
        public Simcard Simcard { get;  }
        public IPlayback PlaybackComponent { get; set; }
        public ICharge ChargerComponent { get; set; }

        public double Voltage
        {
            get
            {
                return ChargerComponent.Voltage;
            }

           
        }

        protected MobilePhone( Battery battery, Simcard simcard)
        {
            Battery = battery;
            Simcard = simcard;

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
            PlaybackComponent.Play(data);
        }

        public void Charge(Battery b)
        {
            ChargerComponent.Charge(Battery);
        }
    }
}