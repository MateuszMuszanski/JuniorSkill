using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuniorSkill.Strategy
{
    class Hunter : Champion
    {
        public override double Attack()
        {
            return attackPower;
        }

        public override double Defend()
        {
            return damageReduction;
        }
    }
}
