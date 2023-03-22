using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuniorSkill.Polymorphism.MethodOverriding
{
    class Monkey : Animal
    {
        public override void AnimalGoes(string animalSound)
        {
            Console.WriteLine(animalSound);
        }
    }
}
