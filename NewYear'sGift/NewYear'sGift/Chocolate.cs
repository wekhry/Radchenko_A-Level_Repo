using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewYear_sGift
{
    internal class Chocolate : Candy
    {
        public string Type { get; }

        public Chocolate(string name, double weight, string flavor, string type) : base(name, weight, flavor)
        {
            Type = type;
        }
    }
}
