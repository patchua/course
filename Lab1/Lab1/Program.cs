using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilePhoneApp.Components;
using MobilePhoneApp.PlaybackDevices;
using MobilePhoneApp.Chargers;
using MobilePhoneApp.OtherDevices;

namespace MobilePhoneApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<MobilePhone> phones= new List<MobilePhone>();
            phones.Add( new SimCorpMobile(new Battery(3000, BatteryType.LiPo),new Simcard("Vodafone",FormFactor.Nano,NetworkType.LTE)));
            phones.Add( new Nokia3310(new Battery(1500,BatteryType.NiMg),new Simcard("LifeCell")));

            List<IPlayback> playbackDevices = new List<IPlayback>();
            playbackDevices.Add(new IphoneOriginalHeadphones());
            playbackDevices.Add(new UnofficialHeadset());

            List<ICharge> chargingDevices = new List<ICharge>();
            chargingDevices.Add(new IphoneCharger());
            chargingDevices.Add(new SmartCharger());
            chargingDevices.Add(new UniversalChinaCharger());

            CarAudio carAudioDevice = new CarAudio(); //This device has both interfaces
            playbackDevices.Add(carAudioDevice);
            chargingDevices.Add(carAudioDevice);

            Console.WriteLine("Following phones are available :");
            int choice = 0;
            foreach (MobilePhone phone in phones)
            {
                Console.WriteLine("{0} - {1} \n", choice, phone.GetDescription());
                choice++;
            }
            choice = 0;
            do
            {

                Console.WriteLine("Please select phone you want to use :");
                string res = Console.ReadLine();               
                int.TryParse(res, out choice);
            } while (phones.ElementAtOrDefault(choice) == null  );
            var selectedPhone = phones.ElementAt(choice);


            Console.WriteLine("Following charging devices are available :");
            choice = 0;
            foreach (ICharge device in chargingDevices)
            {
                Console.WriteLine("{0} - {1}",choice, device.GetType());
                choice++;
            }
            choice = 0;
            do
            {
                Console.WriteLine("Please select device you want to use :");
                string res = Console.ReadLine();
                int.TryParse(res, out choice);
            } while (chargingDevices.ElementAtOrDefault(choice) == null);
            selectedPhone.ChargerComponent = chargingDevices.ElementAt(choice);            

            Console.WriteLine("Following playback devices are available :");
            choice = 0;
            foreach (IPlayback device in playbackDevices)
            {
                Console.WriteLine("{0} - {1}", choice, device.GetType());
                choice++;
            }
            choice = 0;
            do
            {
                Console.WriteLine("Please select device you want to use :");
                string res = Console.ReadLine();
                int.TryParse(res, out choice);
            } while (playbackDevices.ElementAtOrDefault(choice) == null);
            selectedPhone.PlaybackComponent = playbackDevices.ElementAt(choice);
            selectedPhone.Play(new object());
            Console.ReadLine();

        }
    }
}
