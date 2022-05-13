using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_DesignPatterns_Part1
{
    internal class Car
    {
        public string Model { get; set; }
        public int CarNumber { get; set; }

        public bool isFixed;

        public Car(string model, int carNumber, bool isFixed)
        {
            Model = model;
            CarNumber = carNumber;
            this.isFixed = isFixed;
        }
    }


}
