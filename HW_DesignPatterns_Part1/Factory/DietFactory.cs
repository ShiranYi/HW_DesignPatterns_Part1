using HW_DesignPatterns_Part1.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_DesignPatterns_Part1
{
    class DietFactory
    {
        private DietCreator diet;



        public void VegetarianDiet(string menu)
        {
            diet = new VegetarianDietCreator(menu);
        }
        public void AtkinsDiet(string menu)
        {
            diet = new AtkinsDietCreator(menu);
        }
        public void PaleoDiet(string menu)
        {
            diet = new PaleoDietCreator(menu);
        }

        public void ChoosenDiet(int age, double weight, double height)
        {
            if (age <= 25 && weight <= 60 & height <= 1.60)
            {
                Console.WriteLine("You need a Vegetarian Diet.");
            }
            else if (age <= 50 && weight <= 80 & height <= 1.75)
            {
                Console.WriteLine("You need a Atkins Diet.");
            }
            else
            {
                Console.WriteLine("You need a PaleoDiet Diet.");
            }

        }

    }
}
