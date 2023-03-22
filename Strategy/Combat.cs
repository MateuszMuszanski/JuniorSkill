using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuniorSkill.Strategy
{
    public class Combat
    {
        private IAction action;

        public Combat(IAction action)
        {
            this.action = action;
        }

        public void DoAction(Champion champion)
        {
            action.PerformAction(champion);
        }
    }
}
