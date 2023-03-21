using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuniorSkill
{
    abstract class File
    {
        public static int instances = 0;
        public File()
        {
            instances++;
        }
        protected string FileName { get; set; }
        protected int FileSize { get; set; }
        protected DateTime FileCreatetOn { get; set; }
    }
}
