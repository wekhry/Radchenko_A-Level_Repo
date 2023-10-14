using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewYear_sGift
{
    internal class Gift
    {
        private ISweets[] items;

        public Gift(ISweets[] items)
        {
            this.items = items;
        }

        public double CalculateTotalWeight()
        {
            return items.Sum(item => item.Weight);
        }


        //i know that something is wrong with this method
        public void SortCandiesByParameter(string parameter) 
        {
            if (parameter == "flavor")
            {
                Array.Sort(items, (x, y) => (x as Candy).Flavor.CompareTo((y as Candy).Flavor));
            }
        }

        public ISweets? FindCandy(Func<ISweets, bool> criteria)
        {
            return items.FirstOrDefault(criteria);
        }
    }
}
