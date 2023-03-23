using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuniorSkill.Strategy
{
    class Mage : Champion
    {
        public Mage(int strength, int inteligance, int durability, int agility)
        {
            Strength = strength;
            Intelligence = inteligance;
            Durability = durability;
            Agility = agility;
        }
        public override double Attack()
        {
            return attackPower = Strength + Intelligence * 2.1;
        }
        public override double Defend()
        {
            return damageReduction = Durability * 1.1 + Agility * 1.2;
        }
    }
}
