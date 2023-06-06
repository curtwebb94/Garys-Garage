using System;

namespace Garage
{
    public class Zero : Vehicle, IElectric // Electric motorcycle
    {
        public double BatteryKWh { get; set; }
        // Define a property named "BatteryKWh" of type double.
        // It represents the capacity of the battery in kilowatt-hours.

        public int CurrentChargePercentage { get; set; } = 25;
        // Define a property named "CurrentChargePercentage" of type int.
        // It represents the current charge level of the battery in percentage.
        // Initialize it to 25.

        public bool isElectric { get; }
        // Define a property named "isElectric" of type bool.
        // It indicates whether the vehicle is electric.

        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
            // Set the "CurrentChargePercentage" property to 100.
            // This method represents charging the battery of the electric motorcycle.
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero went Zoooooom!");
            // Print a message indicating the Zero electric motorcycle is driving.
            // The message includes the main color of the motorcycle.
        }

        public override void Turn()
        {
            Console.WriteLine("It turned Left.");
            // Print a message indicating the Zero electric motorcycle is turning left.
        }

        public override void Stop()
        {
            Console.WriteLine("It slowly creeped up to a halt.");
            // Print a message indicating the Zero electric motorcycle is stopping.
            // The motorcycle comes to a halt slowly.
        }
    }
}
