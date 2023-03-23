using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuniorSkill.Strategy
{
    class DefendAction : IAction
    {
        public void PerformAction(Champion champion)
        {
            Console.WriteLine($"{champion.GetType().Name} blocked {champion.Defend()}");
        }
    }
}
