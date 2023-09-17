using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewYear_sGift
{
    internal class Candy : ISweets
    {
        public string Name { get; }
        public double Weight { get; }
        public string Flavor { get; } 
        
        public Candy(string name, double weight, string flavor)
        {
            Name = name;
            Weight = weight;
            Flavor = flavor;
        }
    }
}
