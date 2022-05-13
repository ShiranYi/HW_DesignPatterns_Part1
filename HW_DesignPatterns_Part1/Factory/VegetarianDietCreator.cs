using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_DesignPatterns_Part1.Factory
{
    class VegetarianDietCreator : DietCreator
    {
        private string menu;

        public VegetarianDietCreator(string menu)
        {
            this.menu = menu;
        }

        public override DietBase CreateDiet(int age, double weight, double height)
        {
            return new VegetarianDiet(age, weight, height, this.menu);
        }
    }
}
