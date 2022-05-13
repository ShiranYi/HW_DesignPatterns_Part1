using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_DesignPatterns_Part1.Factory
{
     class AtkinsDietCreator: DietCreator
    {
        private string menu;

        public AtkinsDietCreator(string menu)
        {
            this.menu = menu;
        }

        public override DietBase CreateDiet(int age, double weight, double height)
        {
            return new AtkinsDiet(age, weight, height, this.menu);
        }
    }
}

