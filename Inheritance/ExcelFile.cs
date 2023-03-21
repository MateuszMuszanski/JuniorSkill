using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuniorSkill
{
    class ExcelFile : File, IFile
    {
        public ExcelFile(string name, int size, DateTime createdOn)
        {
            FileName = name;
            FileSize = size;
            FileCreatetOn = createdOn;
        }
        public void GenerateReport()
        {
            Console.WriteLine($"File: {FileName} Size:{FileSize} Created:{FileCreatetOn}");
        }
        public void CompressFile()
        {
            Console.WriteLine($"Compress {FileName}");
        }
        public void Properties()
        {

        }
    }
}
