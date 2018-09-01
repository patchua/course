using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            SimCorpMobile scmob = new SimCorpMobile();
            Nokia3310 mymob = new Nokia3310();
            Console.WriteLine("My SimCorp Mobile phone desc: {0} ", scmob.GetDescription());
            Console.WriteLine("My personal Mobile phone desc: {0}", mymob.GetDescription());
            Console.ReadLine();


        }
    }
}
