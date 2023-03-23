using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuniorSkill.Strategy
{
    public abstract class Champion
    {
        public int Strength { get; set; }
        public int Intelligence { get; set; }
        public int Durability { get; set; }
        public int Agility { get; set; }

        public abstract double Attack();
        public abstract double Defend();

        protected double attackPower;
        protected double damageReduction;
    }
}
