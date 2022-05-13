using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_DesignPatterns_Part1
{
    abstract class DietBase
    {
        public int Age { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }

        public DietBase(int age, double weight, double height)
        {
            Age = age;
            Weight = weight;
            Height = height;
        }
    }
}
