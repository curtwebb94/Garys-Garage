using System;


namespace Garage
{
    public class Tesla : Vehicle, IElectric
    {
        public double BatteryKWh { get; set; }

        public int CurrentChargePercentage { get; set; } = 25;
        public bool isElectric { get; }

        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla zipped by with no sound!");
        }

        public override void Turn()
        {
            Console.WriteLine("It turned right at the traffic lights.");
        }

        public override void Stop()
        {
            Console.WriteLine("It stopped at a pedastrian walkway.");
        }
    }
}