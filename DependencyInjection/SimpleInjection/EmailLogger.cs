using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuniorSkill.DependencyInjection
{
    class EmailLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Sent email with message: {message}");
        }
    }
}
