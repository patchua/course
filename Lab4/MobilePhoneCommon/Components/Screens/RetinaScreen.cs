﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneCommon.Components
{
    public class RetinaScreen : ColourScreen
    {
        public RetinaScreen(double hight, double width, int resolution, int colours,IOutput output) : base(hight, width, 300, 300000,output)
        {
        }

        private void ShowImageOnRetina(IScreenImage image, double brightness)
        {
            //implementation
        }
        public override void Show(IScreenImage image)
        {
            ShowImageOnRetina(image, 0.5);
        }

        public override void Show(IScreenImage image, double brightness)
        {
            ShowImageOnRetina(image, brightness);
        }
    
    }
}
