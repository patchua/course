using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneCommon.SMS
{
    public class RandomMessageGenerator
    {
        private Random vRandom = new Random();
        private string[] vNames = { "Ivan", "Peter Pen", "Mommy","ExGF" };
        private string[] vOperators = { "LifeCell", "Vodaphone", "KyivStar" };
        private string[] vTexts = { "Call u later", "new message", "I`ll be late", "CALL ME!!! FAST!!!" };

        public Message Next()
        {
            Message message = new Message();
            message.Body = RandomBody();
            message.ReceivingTime = RandomTime();
            message.Name = RandomName();
            message.Operator = RandomOperator();
            return message;
        }

        private string RandomItem(IList<string> list)
        {
            return list.ElementAt(vRandom.Next(0, list.Count));
        }
        private string RandomOperator()
        {
            return RandomItem(vOperators);
        }        

        private string RandomName()
        {
            return RandomItem(vNames);
        }

        private string RandomBody()
        {
            return RandomItem(vTexts) + "\n";
        }
        private DateTime RandomTime()
        {
            DateTime startDate = new DateTime(2018, 01, 01, 0, 0, 0);
            DateTime endDate = DateTime.Now;
            var timespan = endDate - startDate;
            var dt= startDate + new TimeSpan(0, vRandom.Next(0, (int)timespan.TotalMinutes), 0);
            return dt;
        }

        
    }
}
