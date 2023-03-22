using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuniorSkill.Strategy
{
    public abstract class ChampionActions
    {
        public int Strength { get; set; }
        public int Intelligence { get; set; }
        public int Durability { get; set; }
        public int Agility { get; set; }
        public abstract void Attack();
        public abstract void Defend();
    }
}
