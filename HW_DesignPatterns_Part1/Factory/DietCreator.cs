using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_DesignPatterns_Part1.Factory
{
    abstract class DietCreator
    {
        public abstract DietBase CreateDiet(int age, double weight, double height);
    }
}
