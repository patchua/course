using Lab1.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public abstract class MobilePhone
    {
        public abstract ScreenBase Screen { get; }
        public abstract Keyboard Keyboard{ get; }
        public Battery Battery = new Battery();
        public Simcard Simcard { get;  }

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
            return descriptionBuilder.ToString();
        }

    }
}
