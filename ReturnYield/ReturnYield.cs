using JuniorSkill.LINQ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuniorSkill.YieldReturn
{
    class ReturnYield
    {
        public IEnumerable<int> GetByReturn()
        {
            Console.WriteLine("Start return");

            List<int> result = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Return: {i}");
                result.Add(i);
            }

            Console.WriteLine("End return");
            return result;
        }

        public IEnumerable<int> GetByYield()
        {
            Console.WriteLine("Start yield");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Yield: {i}");
                yield return i;
            }
            Console.WriteLine("End yield");
        }
        public IEnumerable<Person> GetPeople()
        {
            // do dokończenia
            var result = Employee.GetPeople();
            foreach (var item in result)
            {
                yield return item;
            }
        }
    }
}
