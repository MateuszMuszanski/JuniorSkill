using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuniorSkill
{
    class SeparateStringBySpace
    {
        /// <summary>
        /// Input string separated by " " or ','
        /// </summary>
        /// <param name="inputSentence"></param>
        /// <returns></returns>
        public static int HowManyWords(string inputSentence)
        {
            string[] howManyWords = inputSentence.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            int result = howManyWords.Length;
            return result;
        }
    }
}
