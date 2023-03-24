using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuniorSkill
{
    class Person
    {
        public static int objCount = 0;
        public string FirstName;
        public string LastName;

        public DateTime dateOfBirth;

        private string contactNumber;

        public string ContactNumber { 
            get { return contactNumber; } 
            set 
            {
                if (value.Length < 9)
                {
                    Console.WriteLine("Invalid contact number");
                }else
                    contactNumber = value;
            } 
        }

        public Person(string firstName, string lastName)
        {
            Console.WriteLine("Created Person");
            FirstName = firstName;
            LastName = lastName;
            objCount++;
        }

        public Person(DateTime dateOfBirth, string firstName, string lastName) : this(firstName, lastName)
        {
            //Console.WriteLine("Second ctor");
            SetDateOfBirth(dateOfBirth);
        }
        protected void SetDateOfBirth(DateTime dateTime)
        {
            if (dateTime > DateTime.Now)
            {
                Console.WriteLine("Invalid date");
            }
            else
            {
                dateOfBirth = dateTime;
            }
        }
        public void SayHi()
        {
            Console.WriteLine($"Hi {FirstName} {LastName}, You were born {dateOfBirth}");
        }
    }
}
