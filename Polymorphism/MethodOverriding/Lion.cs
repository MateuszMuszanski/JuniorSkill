using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuniorSkill.Polymorphism.MethodOverriding
{
    class Lion : Animal
    {
        public override string MakeSound()
        {
            return "Roar";
        }
        public override void AnimalGoes(string animalSound)
        {
            Console.WriteLine("Lion goes " + animalSound);
        }
    }
}
