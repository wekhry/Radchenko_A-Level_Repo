using LinqHW.Queries;
using LinqHW.UserFolder;

namespace LinqHW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DivByTwoAndThree div = new DivByTwoAndThree();
            SumOfNums sum = new SumOfNums();
            AverageOfNums average = new AverageOfNums();
            MaxNum max = new MaxNum();
            MinNum min = new MinNum();
            GreaterThanTen greaterThanTen = new GreaterThanTen();
            UniqueCharacters uniqueCharacters = new UniqueCharacters();
            Frequency frequency = new Frequency();
            EvenAndOddGroups evenAndOddGroups = new EvenAndOddGroups();
            GreaterThanAverage greaterThanAverage = new GreaterThanAverage();
            GroupByLength groupByLength = new GroupByLength();
            GivenSubstring givenSubstring = new GivenSubstring();
            Users users = new Users();
            

            div.DivByTwoAndThreeQuery();
            sum.SumOfNumsQuery();
            average.AverageOfNumsOuery();
            max.MaxNumQuery();
            min.MinNumQuery();
            greaterThanTen.GreaterThanTenQuery();
            uniqueCharacters.UniqueCharactersQuery();
            frequency.FrequencyQuery();
            evenAndOddGroups.EvenAndOddGroupsQuery();
            greaterThanAverage.GreaterThanAverageQuery();
            groupByLength.GroupByLengthQuery();
            givenSubstring.GivenSubstringQuery();
            users.GeneratingUsers();
        }
    }
}