using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_DesignPatterns_Part1
{
     abstract class GarageHandler
    {
        protected GarageHandler next;
    
        public void NextTest(GarageHandler next)
        {
            this.next = next;
        }
        public abstract void HandleCar(Car car);
    }
}
