using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_DesignPatterns_Part1
{
    internal class VegetarianDiet : DietBase
    {
        private string menu;

        public VegetarianDiet(int age, double weight, double height, string menu) : base(age, weight, height)
        {
            this.menu = menu;
        }
   
    }
}
