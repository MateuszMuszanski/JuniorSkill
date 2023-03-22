using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuniorSkill.Polymorphism.MethodOverriding
{
    abstract class Animal
    {
        public virtual string MakeSound()
        {
            return "Football hooligan goes ooh ooh ahh ahh";
        }
        public abstract void AnimalGoes(string animalSound);
    }
}
