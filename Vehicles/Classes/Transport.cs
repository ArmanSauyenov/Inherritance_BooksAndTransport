using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles.Classes
{
    public enum Vehicle { MersedesBenz, BMW, Lexus, Toyota, Volvo, Kia, Hyundai }
    public abstract class Transport
    {
        protected static Random rand = new Random();
        public Vehicle Marks { get; set; }
        public string Number { get; set; }
        public int Speed { get; set; }
        public int CarryCap { get; set; }

        public abstract void PrintInfo();

        public abstract int CarryingCapacity();


    }
}
