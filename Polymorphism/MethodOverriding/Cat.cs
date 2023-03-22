using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuniorSkill.Polymorphism.MethodOverriding
{
    class Cat : Animal
    {
        public override string MakeSound()
        {
            return "Meow meow";
        }
        public override void AnimalGoes(string animalSound)
        {
            Console.WriteLine("Cat goes " + animalSound);
        }
    }
}
