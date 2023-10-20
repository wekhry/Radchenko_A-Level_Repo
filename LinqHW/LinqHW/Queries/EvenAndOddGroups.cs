using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LinqHW.Queries
{
    internal class EvenAndOddGroups
    {
        public void EvenAndOddGroupsQuery()
        {
            int[] numbers = { 1, 2, 3, 100, -10, 22, 36, 893, 13, 104, 33, 1, 3, -10, 22, 22, 36, 13, 1, 2 };

            var evenAndOdd = numbers
                .GroupBy(num => num % 2 == 0 ? "Even" : "Odd")
                .Select(group => new 
                {
                    GroupName = group.Key,
                    MaxNum = group.Max()
                });

            foreach (var group in evenAndOdd)
            {
                Console.WriteLine($"\nGroup: {group.GroupName}, Max Number: {group.MaxNum}\n");
            }
        }
    }
}
