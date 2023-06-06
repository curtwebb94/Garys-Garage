using System;


namespace Garage
{
    public class Ram: Vehicle, IGas  // Gas powered truck
    {

        public int CurrentFuelGauge { get;set; } = 25;
        public bool isGas { get; }
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
         CurrentFuelGauge = 100;
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram went Rumbleeeeeee! It's Loud.");
        }

        public override void Turn()
        {
            Console.WriteLine("It did a U-Turn.");
        }

        public override void Stop()
        {
            Console.WriteLine("They are blasting music at the Stop sign.");
        }
    }
}