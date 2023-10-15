using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqHW.Queries
{
    internal class GroupByLength
    {
        public void GroupByLengthQuery()
        {
            List<string> items = new List<string> { "Abilities", "forfeited", "situation", "extremely", "my", "to", "he", "resembled", "Old", "had", "conviction", "discretion", "understood", "put", "principles", "you" };

            var groupByLength = items.GroupBy(x => x.Length);
            foreach ( var item in groupByLength)
            {
                Console.WriteLine($"\nWords with length {item.Key}:\n");
                foreach(var word in item)
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}
