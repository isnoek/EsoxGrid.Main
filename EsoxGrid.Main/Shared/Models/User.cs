using System;
using System.Collections.Generic;
using System.Text;

namespace EsoxGrid.Main.Shared.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public static IEnumerable<User> Generate(int number)
        {
            Random r=new Random();
            List<User> result=new List<User>();
            for (int i = 0; i < number; i++)
            {
                var user = new User
                {
                    Id = i,
                    Age = r.Next(80),
                    FirstName = $"First{i}",
                    LastName = $"Last{i}"
                };
                result.Add(user);
            }
            return result;
        }
    }
}
