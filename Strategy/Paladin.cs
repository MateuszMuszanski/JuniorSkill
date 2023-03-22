using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuniorSkill.Strategy
{
    class Paladin : Champion
    {
        public Paladin(int strength, int inteligance, int durability, int agility)
        {
            Strength = strength;
            Intelligence = inteligance;
            Durability = durability;
            Agility = agility;
        }
        public override double Attack()
        {
            return attackPower = Strength * 1.5 + Intelligence * 1.2;
        }
        public override double Defend()
        {
            return damageReduction = Durability * 1.2 + Agility * 1.5;
        }
    }
}
