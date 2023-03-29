using JuniorSkill.DependencyInjection;
using JuniorSkill.LINQ;
using JuniorSkill.Polymorphism;
using JuniorSkill.Polymorphism.MethodOverriding;
using JuniorSkill.Strategy;
using JuniorSkill.YieldReturn;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace JuniorSkill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine();

            //Recursion
            int index = 40;
            var watch = Stopwatch.StartNew();
            Console.WriteLine(Recursion(index));
            watch.Stop();
            Console.WriteLine("Time: " + watch.ElapsedMilliseconds);
            watch.Reset();
            //Ref Recursion
            watch.Start();
            long result = 0;
            Console.WriteLine(RefRecursion(index, ref result));
            watch.Stop();
            Console.WriteLine("Time: " + watch.ElapsedMilliseconds);
            //Your recursion
            result = 0;
            watch.Reset();
            watch.Start();
            for (int i = 0; i < index; i++)
            {
                CalculateFibonacci(i, ref result);
                
            }
            Console.WriteLine(result);
            watch.Stop();
            Console.WriteLine("Time: " + watch.ElapsedMilliseconds);
            //
            KeyWordYield();

            //Lambda
            LambdaExpresionAndLINQ();

            //Dependency injection
            Injection();

            //Strategy
            Strategy();
            Console.WriteLine();

            //Polymorphism
            Polymporph();
            Console.WriteLine();

            // Word counting
            Console.WriteLine(SeparateStringBySpace.HowManyWords(""));

            // Inheritance
            FileHandler();
            Console.WriteLine($"There are {File.instances} objects that inherites from class File");
            Console.WriteLine();
            // 
            PersonHandler();

            //Try Catch
            TryCatch(3); // >4 to catch exeption

            //Nullable
            NullAble();

            //String and StrinBuilder
            StaticClassStrings();

            //Casting and Parsing
            CastingAndConvertion.ReturnTwoValuesIfZero(); // static
            CastingAndConvertion castingAndConvertion = new CastingAndConvertion(); // dynamic
            //Enum
            ShowEnum();

            //
        }
        static public void StaticClassStrings()
        {
            Console.WriteLine("Static");
            Console.WriteLine(StringAndStringBuilder.StaticShow());
            Console.WriteLine();

            Console.WriteLine("Dynamic");
            StringAndStringBuilder strings = new StringAndStringBuilder();
            Console.WriteLine(strings.Show());
            Console.WriteLine();

            Console.WriteLine("StringBuilder");
            Console.WriteLine(strings.StringBuilder("Mateusz"));
            Console.WriteLine();

            strings.WritePath();
            Console.WriteLine();
        }
        static public void ShowEnum()
        {
            Console.WriteLine("Type 1 - Male, 2 - Female");
            char userInput = Console.ReadKey().KeyChar;
            Console.WriteLine();
            GenderEnum userGender = (GenderEnum)Enum.Parse(typeof(GenderEnum), userInput.ToString());
            Console.WriteLine($"You are a {userGender}");
            if (GenderEnum.Female == userGender)
            {
                Console.WriteLine($"Would you like to be {GenderEnum.Male}?");
            }
            else
                Console.WriteLine($"Would you like to be {GenderEnum.Female}?");
        }
        static public void NullAble()
        {
            int? number = null;
            Console.WriteLine(number != null ? $"Value: {number}" : "Doesn't have value");
            number = 1;
            Console.WriteLine(number != null ? $"Value: {number}" : "Doesn't have value");
            Console.WriteLine();
        }
        static public void TryCatch(int a)
        {
            string[] words = { "Hello ", "User. ", "How ", "are ", "You?" };
            try
            {
                for (int i = 0; i <= a; i++)
                {
                    Console.Write(words[i]);
                }
                Console.WriteLine(words[a + 1]);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("You went out of range");
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong");
            }
            finally
            {
                Console.WriteLine();
            }
        }
        static public void PersonHandler()
        {
            Person person1 = new Person("asd", "fgh");
            person1.SayHi();
            Person person2 = new Person(new DateTime(1996, 06, 11), "Mateusz", "Muszanski");
            person2.SayHi();
            Console.WriteLine();
            person2.ContactNumber = "736656288";

            Console.WriteLine($"There are {Person.objCount} Objs of type Person");
        }
        public static void FileHandler()
        {
            ExcelFile excelFile = new ExcelFile("excel_file", 2, new DateTime(2023, 02, 11));
            excelFile.GenerateReport();
            WordFile wordFile = new WordFile("word_file", 2, new DateTime(2023, 02, 11));
            wordFile.Print();
        }
        public static void Polymporph()
        {
            List<IShape> shapes = new List<IShape>();

            Rectangle rectangle = new Rectangle { Length = 5, Width = 5 };
            Circle circle = new Circle { Radius = 5 };

            shapes.Add(rectangle);
            shapes.Add(circle);

            foreach (var item in shapes)
            {
                double result = item.CalculateArea();

                Console.WriteLine(result);
            }
            Console.WriteLine();

            Animal animal;
            animal = new Cat();
            animal.AnimalGoes(animal.MakeSound());

            animal = new Lion();
            animal.AnimalGoes(animal.MakeSound());

            animal = new Monkey();
            animal.AnimalGoes(animal.MakeSound());
            Console.WriteLine();
        }
        public static void Strategy()
        {
            Paladin paladin = new Paladin(6, 5, 5, 3);
            Mage mage = new Mage(3, 8, 4, 3);

            AttackAction attackAction = new AttackAction();
            DefendAction defendAction = new DefendAction();

            Combat combat = new Combat(attackAction);
            combat.DoAction(paladin);

            combat = new Combat(defendAction);
            combat.DoAction(mage);
        }
        public static void Injection()
        {
            ConsoleLogger consoleLogger = new ConsoleLogger();
            EmailLogger emailLogger = new EmailLogger();

            FoodService foodService = new FoodService(consoleLogger);
            foodService.WriteMenu();

            foodService = new FoodService(emailLogger);
            foodService.WriteMenu();
            Console.WriteLine();

        }
        public static void LambdaExpresionAndLINQ()
        {
            Dictionary<string, string> symbolNation = new Dictionary<string, string>();
            symbolNation.Add("PL", "Poland");
            symbolNation.Add("JP", "Japan");
            symbolNation.Add("US", "United States");

            string country = symbolNation.FirstOrDefault(x => x.Key == "PL").Value;
            Console.WriteLine(country);

            List<Person> people = Employee.GetPeople();


            bool IsBornAfter1999(Person person)
            {
                return person.dateOfBirth.Year > 1999;
            }
            //using delegate
            people.RemoveAll(IsBornAfter1999);
            //using lambda
            people.RemoveAll(p => p.FirstName == "Mateusz");

            foreach (var item in people.Where(p => p.dateOfBirth < new DateTime(1996, 6, 12)))
            {
                Console.WriteLine($"{item.FirstName} {item.LastName} was born before May 10th, 1996.");
            }
        }
        public static void KeyWordYield()
        {
            ReturnYield returnYield = new ReturnYield();

            foreach (var item in returnYield.GetByReturn())
            {
                Console.WriteLine($"Return element {item}");

                if (item > 1)
                {
                    break;
                }
            }
            Console.WriteLine();

            foreach (var item in returnYield.GetByYield())
            {
                Console.WriteLine($"Return yield {item}");

                if (item > 1)
                {
                    break;
                }
            }
            Console.WriteLine();
        }
        public static void RefOut()
        {
            void Square(ref int x)
            {
                x *= x;
            }
            int num = 5;
            Square(ref num);

            bool TryParse(string s, out int result)
            {
                bool parsed = int.TryParse(s, out result);
                return parsed;
            }

            string snumber = "123";
            int outnumb;
            TryParse(snumber, out outnumb);
            Console.WriteLine("TryParse: " + outnumb);
        }
        public static void OrAnd()
        {
            bool Number(int number)
            {
                if (number % 2 == 1)
                {
                    Console.Write(number);
                    return true;
                }
                return false;
            }

            if (Number(1) || Number(2) & Number(3) && Number(3) | Number(4))
            {
                Number(3);
            }
            Console.WriteLine();
            if (Number(1) | Number(2) & Number(3) && Number(3) || Number(4))
            {
                Number(3);
            }
            Console.WriteLine();
            if (Number(1) || Number(2) && Number(3) & Number(3) | Number(4))
            {
                Number(3);
            }
            Console.WriteLine();
        }
        public static long Recursion(int a)
        {
            long num = 0;
            if (a == 0)
            {
                return 0;
            }
            if (a == 1)
            {
                return 1;
            }
            if (a > 1)
            {
                num = Recursion(a - 1) + Recursion(a - 2);
            }
            return num;
        }
        public static long RefRecursion(int index, ref long result)
        {
            if (index < 2)
            {
                return index;
            }
            return RefRecursion(index - 1, ref result) + RefRecursion(index - 2, ref result);
        }
        static void CalculateFibonacci(int index, ref long result)
        {
            if (index < 2)
            {
                result = index;
            }
            else
            {
                long previousFib = 0;
                RefRecursion(index - 1, ref previousFib);
                long previousPreviousFib = 0;
                RefRecursion(index - 2, ref previousPreviousFib);
                result = previousFib + previousPreviousFib;
            }
        }
    }
}
