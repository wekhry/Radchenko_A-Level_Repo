using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewYear_sGift
{
    interface ISweets
    {
        string Name { get; }
        double Weight { get; }
    }

    internal class Sweets : ISweets
    {
        public string Name { get; }
        public double Weight { get; }

        public Sweets(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }
    }
}
