using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles.Classes
{
    public class Truck : Transport
    {
        public int Trailer;

        public override int CarryingCapacity()
        {
            if ((Trailer = rand.Next(0, 1)) == 1)
            {

                return CarryCap *= 2;
            }
            else
            {
                return CarryCap = rand.Next(100, 1000);
            }
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Truck's mark: {Marks}\n Truck's number: {Number}\n Truck's speed: {Speed}\n " +
                 $"Truck's carry cappacity: {CarryingCapacity()} ");
        }





    }
}
