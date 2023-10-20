using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqHW.UserFolder
{
    internal class Users
    {
        public void GeneratingUsers()
        {
            List<User> users = GenerateUsers();

            //1
            var query1 = users
                .Where(user => CalculateAge(user.DateOfBirth) > 18)
                .Select(user => new
                {
                    FullName = $"{user.FirstName} {user.LastName}",
                    DateOfBirth = user.DateOfBirth,
                    CurrentAge = CalculateAge(user.DateOfBirth)
                });

            Console.WriteLine("\nQuery 1: Users whose age > 18");
            foreach (var user in query1)
            {
                Console.WriteLine($"\tFull Name: {user.FullName}, " +
                                  $"\tDate of birth: {user.DateOfBirth.ToShortDateString()}, " +
                                  $"\tCurrent Age: {user.CurrentAge}");
            }

            //2
            var query2 = users
                .GroupBy(user => user.Email.Split('@')[1])
                .Select(group => new
                {
                    Domain = group.Key,
                    Count = group.Count()
                })
                .OrderByDescending(group => group.Count)
                .FirstOrDefault();

            Console.WriteLine("\nQuery 2: Most used email domain");
            Console.WriteLine($"\tDomain: {query2.Domain}, Count: {query2.Count}");

            //3
            Dictionary<int, User> optimizedCollection = users.ToDictionary(user => user.UserId);

            //4
            var query4 = users
                .GroupBy(user => user.LastName)
                .Select(group => new
                {
                    LastName = group.Key,
                    PossibleRelatives = group.OrderBy(user => user.DateOfBirth).ToList()
                });
            Console.WriteLine("\nQuery 4: Groups of possible relatives");
            foreach (var group in query4)
            {
                Console.WriteLine($"\tLast Name: {group.LastName}");
                foreach(var user in group.PossibleRelatives)
                {
                    Console.WriteLine($"\tFirst Name: {user.FirstName}, Date of Birth: {user.DateOfBirth.ToShortDateString()}");
                }
            }
        }

        public static int CalculateAge(DateTime dateOfBirth)
        {
            int age = DateTime.Today.Year - dateOfBirth.Year;
            if(DateTime.Now < dateOfBirth.AddYears(age))
            {
                age--;
            }
            return age;
        }

        public static List<User> GenerateUsers()
        {
            List<User> users = new List<User>();
            Random random = new Random();
            for (int i = 1; i < 10;  i++)
            {
                User user = new User
                {
                    FirstName = $"User{i}",
                    LastName = $"LastName{i % 5}",
                    Email = $"user{i}@example.com",
                    DateOfBirth = DateTime.Now.AddYears(-random.Next(18, 50)),
                    UserId = i
                };
                users.Add(user);
            }
            return users;
        }
    }
}
