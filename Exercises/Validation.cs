using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuniorSkill.Exercises
{
    public class Validation
    {
        public static bool Validate(char[] tablica)
        {
            int counter = 0;

            foreach (var item in tablica)
            {
                if (item == '(')
                {
                    counter++;
                }
                if (item == ')')
                {
                    counter--;
                    if (counter < 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
