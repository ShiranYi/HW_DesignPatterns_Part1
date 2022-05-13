using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_DesignPatterns_Part1
{
    internal class SpecialistDiagnosis : GarageHandler
    {
        public override void HandleCar(Car car)
        {
            int test = new Random().Next(1, 11);
            if (test >= 6)
            {
                Console.WriteLine($"Car Number: {car.CarNumber} Model: {car.Model} is fix.\n Drive safe!");
            }
            else
            {
                Console.WriteLine("The car need repair, Continue to the next test");
            }
        }
    }
}
