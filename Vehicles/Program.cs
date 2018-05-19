using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            Generator gen = new Generator();
            gen.GeneratorCar();
            gen.GeneranorBike();
            gen.GeneranorTruck();
            gen.PrintAll();

            Console.WriteLine("Please enter a cappacity");
            int value = Int32.Parse(Console.ReadLine());

            gen.FindTransByCappacity(value);


        }
    }
}
