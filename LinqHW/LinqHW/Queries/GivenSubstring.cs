using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqHW.Queries
{
    internal class GivenSubstring
    {
        public void GivenSubstringQuery()
        {
            List<string> items = new List<string> { "Abilities", "forfeited", "situation", "extremely", "my", "to", "he", "resembled", "Old", "had", "conviction", "discretion", "understood", "put", "principles", "you" };

            string substring = "on";

            var groupedWords = items
                .Where(item => item.Contains(substring))
                .GroupBy(item => item.Length)
                .Select(group => group.Select(item => $"{char.ToUpper(item[0])}{item.Substring(1).ToLower()}"));

            foreach(var group in groupedWords)
            {
                Console.WriteLine($"\nGrouped words with length {group.First().Length}:");
                foreach(var item in group) Console.WriteLine(item);
            }
        }
    }
}
