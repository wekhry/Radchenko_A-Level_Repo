using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqHW.Queries
{
    internal class Frequency
    {
        public void FrequencyQuery()
        {
            int[] numbers = { 1, 2, 3, 100, -10, 22, 36, 893, 13, 104, 33, 1, 3, -10, 22, 22, 36, 13, 1, 2 };

            var frequency = numbers
                .GroupBy(num => num)
                .Select(group => new { Number = group.Key, Frequency = group.Count() });

            foreach(var num in  frequency)
            {
                Console.WriteLine($"\nNumber: {num.Number}, Frequency: {num.Frequency}\n");
            }
        }
    }
}
