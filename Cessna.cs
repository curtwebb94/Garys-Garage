using System;

namespace Garage
{
    public class Cessna : Vehicle, IGas // Propeller light aircraft
    {
        public int CurrentFuelGauge { get; set; } = 25;
        // Define a property named "CurrentFuelGauge" of type int.
        // It represents the current fuel level in the Cessna's tank.
        // Initialize it to 25.

        public bool isGas { get; }
        // Define a property named "isGas" of type bool.
        // It indicates whether the aircraft is gas-powered.

        public double FuelCapacity { get; set; }
        // Define a property named "FuelCapacity" of type double.
        // It represents the maximum fuel capacity of the Cessna in gallons.

        public void RefuelTank()
        {
            CurrentFuelGauge = 100;
            // Set the "CurrentFuelGauge" property to 100.
            // This method represents refueling the gas tank of the Cessna.
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna went Zoooooom! It blew my wig off!");
            // Print a message indicating the Cessna aircraft is flying.
            // The message includes the main color of the aircraft.
        }

        public override void Turn()
        {
            Console.WriteLine("It then turned left");
            // Print a message indicating the Cessna aircraft is turning left.
        }

        public override void Stop()
        {
            Console.WriteLine("It stopped immediately.");
            // Print a message indicating the Cessna aircraft has come to a stop.
        }
    }
}
