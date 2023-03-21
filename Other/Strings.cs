using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuniorSkill
{
    /// <summary>
    /// Method that shows some crucial things about strings
    /// </summary>
    class Strings
    {
        string text = "hello \"world\"";
        string folderLocation = @"c:\windows";

        static string staticName = "Mateusz";
        static string staticInterpolated;
        public static string StaticShow()
        {
            staticInterpolated = $"My name is {staticName}";

            return staticInterpolated;
        }

        public string Show()
        {
            string name = "Mateusz";
            string interpolated = $"My name is {name}";

            return interpolated;
        }
        public StringBuilder StringBuilder(string name)
        {
            StringBuilder stringBuilder = new StringBuilder("My ");
            stringBuilder.Append("name ");
            stringBuilder.Append("is ");
            stringBuilder.Append(name);

            return stringBuilder;
        }
    }
}
