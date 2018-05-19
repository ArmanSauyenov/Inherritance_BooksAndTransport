using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport.Classes
{
    public class Car : Transport
    {
        public override int CarryingCapacity()
        {
            return CarryCap = rand.Next(300, 600);

        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Car's mark {Marks}\n Car's number {Number}\n Car's speed {Speed}\n " +
                $"Car's carry cappacity {CarryingCapacity()} ");
        }
    }
}
