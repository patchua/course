using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilePhoneApp.Components;
using MobilePhoneApp.PlaybackDevices;

namespace MobilePhoneApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SimCorpMobile scmob = new SimCorpMobile(new Battery(3000, BatteryType.LiPo),new Simcard("Vodafone",FormFactor.Nano,NetworkType.LTE));
            Nokia3310 mymob = new Nokia3310(new Battery(1500,BatteryType.NiMg),new Simcard("LifeCell"));
            Console.WriteLine("My SimCorp Mobile phone desc: \n{0} ", scmob.GetDescription());
            Console.WriteLine("My personal Mobile phone desc: \n{0}", mymob.GetDescription());
            Console.ReadLine();
        }
    }
}
