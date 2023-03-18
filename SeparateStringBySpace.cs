using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuniorSkill
{
    class SeparateStringBySpace
    {
        public static int HowManyWords(string user)
        {
            int howManyWords = 1;
            user = "how many words";
            for (int i = 0; i < user.Length-1; i++)
            {
                if (user == null)
                {
                    return 0;
                }
                if (user[i] == ' ')
                {
                    howManyWords++;
                }
            }

            return howManyWords;
        }
    }
}
