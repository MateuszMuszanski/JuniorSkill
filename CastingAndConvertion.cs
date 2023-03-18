using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuniorSkill
{
    class CastingAndConvertion
    {
        private int result;
        public int Result { get { return result; } set { result = DateTime.Now.Year - value; } }
        public CastingAndConvertion()
        {
            Result = InputHandler();
            ShowAge();
            Console.WriteLine($"Total days from birth {DaysFromBirth()}");
        }

        private int InputHandler()
        {
            string userInput = Console.ReadLine();
            int parsedInput;
            if (int.TryParse(userInput, out parsedInput))
            {
                return parsedInput;
            }
            else
                return 0;

        }
        public void ShowAge()
        {
            if (Result == DateTime.Now.Year)
            {
                Console.WriteLine(DateTime.Now);
                Console.WriteLine($"In {Result} I have {(int)((DateTime.Now - (new DateTime(1996, 06, 11))).TotalDays / 365.242199)} years");
            }
            else
                Console.WriteLine($"In year {Result} I had {(int)((DateTime.Now - (new DateTime(1996, 06, 11))).TotalDays / 365.242199) - (DateTime.Now.Year - Result)} years");
            Console.WriteLine();
        }

        public int DaysFromBirth()
        {
            int day, month, year;
            DateTime birthDate;
            TimeSpan timeSpan;

            Console.WriteLine("Press 1 for: 3 input values");
            Console.WriteLine("Press 2 for: 1 input value");

            int userInput = int.Parse(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    Console.WriteLine("Day");
                    day = int.Parse(Console.ReadLine());
                    Console.WriteLine("Day");
                    month = int.Parse(Console.ReadLine());
                    Console.WriteLine("Day");
                    year = int.Parse(Console.ReadLine());
                    birthDate = new DateTime(year, month, day);
                    timeSpan = DateTime.Now - birthDate;
                    return (int)timeSpan.TotalDays;

                case 2:
                    Console.WriteLine("Format date yyyy.mm.dd");
                    string userDate = Console.ReadLine();
                    birthDate = DateTime.Parse(userDate);
                    timeSpan = DateTime.Now - birthDate;
                    return (int)timeSpan.TotalDays;

                default:
                    Console.WriteLine("Incorrect input");
                    break;
            }

            return 0;
        }
        public static void ReturnTwoValuesIfZero()
        {
            Console.WriteLine("Insert number:");
            int userInput = int.Parse(Console.ReadLine());
            int sum = 0;
            int max = userInput;

            while (userInput != 0)
            {
                if (userInput>max)
                {
                    max = userInput;
                }
                sum += userInput;
                userInput = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Sum of numbers {sum}");
            Console.WriteLine($"Max value {max}");
        }
    }
}
