using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles.Classes
{
    public class Bike : Transport
    {
        public int Carriage;

        public override int CarryingCapacity()
        {
            if ((Carriage = rand.Next(0, 1)) == 0)
            {
                return CarryCap = 0;
            }
            else
            {
                return CarryCap = rand.Next(10, 100);
            }
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Bike's mark {Marks}\n Bike's number {Number}\n Bike's speed {Speed}\n " +
                 $"Bike's carry cappacity {CarryingCapacity()} ");
        }






    }
}
