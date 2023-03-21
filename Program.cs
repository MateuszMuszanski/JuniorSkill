using System;

namespace JuniorSkill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine();

            // Word counting
            Console.WriteLine( SeparateStringBySpace.HowManyWords("") ); 

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
            Console.WriteLine(Strings.StaticShow());
            Console.WriteLine();

            Console.WriteLine("Dynamic");
            Strings strings = new Strings();
            Console.WriteLine(strings.Show());
            Console.WriteLine();

            Console.WriteLine("StringBuilder");
            Console.WriteLine(strings.StringBuilder("Mateusz"));
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
            string[] words = {"Hello ","User. ","How ","are ","You?" };
            try
            {
                for (int i = 0; i <= a; i++)
                {
                    Console.Write(words[i]);
                }
                Console.WriteLine(words[a + 1]);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("You went out of range");
            }catch(Exception e)
            {
                Console.WriteLine("Something went wrong");
            }finally
            {
                Console.WriteLine();
            }
        }
        static public void PersonHandler()
        {
            Person person1 = new Person("asd", "fgh");
            person1.SayHi();
            Person person2 = new Person(new DateTime(1996,06,11),"Mateusz", "Muszanski");
            person2.SayHi();
            Console.WriteLine();
            person2.ContactNumber = "736656288";

            Console.WriteLine($"There are {Person.objCount} Objs of type Person"); 
        }
        public static void FileHandler()
        {
            ExcelFile excelFile = new ExcelFile("excel_file", 2, new DateTime(2023,02,11));
            excelFile.GenerateReport();
            WordFile wordFile = new WordFile("word_file", 2, new DateTime(2023, 02, 11));
            wordFile.Print();
        }
    }
}
