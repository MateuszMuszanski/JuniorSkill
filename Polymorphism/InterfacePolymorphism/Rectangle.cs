using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuniorSkill.Polymorphism
{
    class Rectangle : IShape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public double CalculateArea()
        {
            return Length * Width;
        }
    }
}
