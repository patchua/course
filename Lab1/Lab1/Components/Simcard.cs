using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Components
{
    public class Simcard
    {
        public FormFactor FormFactor { get; }
        public string Operator { get; }
        public NetworkType SupportedNetwork { get; }
        public Simcard(string op, FormFactor formfactor, NetworkType network)
        {
            Operator = op;
            FormFactor = formfactor;
            SupportedNetwork = network;
        }
        public Simcard(string op):this (op, FormFactor.FullSize, NetworkType.GSM)
        {
            
        }


        public override string ToString()
        {
            return SupportedNetwork.ToString() + " " +  FormFactor.ToString() + " by " + Operator;
        }
    }

    public enum NetworkType
    {
        GSM,
        ThreeG,
        LTE
    }

    public enum FormFactor
    {
        FullSize,
        Micro,
        Nano
    }
}
