using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqHW.Queries
{
    internal class UniqueCharacters
    {
        public void UniqueCharactersQuery()
        {
            string sentence = "Abilities forfeited situation extremely my to he resembled. Old had conviction discretion understood put principles you.";

            var uniqueCharacters = sentence.Where(c => !Char.IsWhiteSpace(c)).Distinct();

            Console.WriteLine("\nUnique characters in the sentence: ");

            foreach (var character in uniqueCharacters)
            {
                Console.WriteLine(character);
            }
        }
    }
}
