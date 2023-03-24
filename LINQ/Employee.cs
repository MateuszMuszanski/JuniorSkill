using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuniorSkill.LINQ
{
    class Employee
    {
        public static List<Person> GetPeople()
        {
            List<Person> people = new List<Person>()
            {
                new Person(new DateTime(1996, 6, 11), "Mateusz", "Muszanski"),
                new Person(new DateTime(1998, 9, 15), "Dawid", "Banas"),
                new Person(new DateTime(2000, 1, 20), "John", "Walker"),
                new Person(new DateTime(1973, 2, 9), "Makoto", "Shinkai")
            };

            return people;
        }
    }
}
