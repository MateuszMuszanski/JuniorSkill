using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuniorSkill.Strategy
{
    public interface IAction
    {
        void PerformAction(Champion champion);
    }
}
