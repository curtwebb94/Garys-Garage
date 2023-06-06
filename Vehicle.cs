using System;

namespace Garage
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }

        public virtual void Drive()
        {
            Console.WriteLine("Vrooom!");
        }

        public virtual void Turn()
        {
            Console.WriteLine("Turns right");
        }

        public virtual void Stop()
        {
            Console.WriteLine("It stopped on a Dime");
        }
    }
}