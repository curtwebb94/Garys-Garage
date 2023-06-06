using System;
using System.Collections.Generic;

namespace Garage
{
    class Program
    {
        private static readonly Random random = new Random();
        private static readonly string[] colors = { "Red", "Blue", "Green", "Yellow", "Orange" };

        static void Main(string[] args)
        {
            // Create instances of electric vehicles
            Zero fxs = new Zero();
            Zero fx = new Zero();
            Tesla modelS = new Tesla();

            // Create a list to store electric vehicles
            List<IElectric> electricVehicles = new List<IElectric>()
            {
                fx, fxs, modelS
            };

            Console.WriteLine("Electric Vehicles");
            foreach (IElectric ev in electricVehicles)
            {
                // Print the current charge percentage of each electric vehicle
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }

            foreach (IElectric ev in electricVehicles)
            {
                // Charge the battery of each electric vehicle to 100%
                ev.ChargeBattery();
            }

            foreach (IElectric ev in electricVehicles)
            {
                // Print the current charge percentage after charging
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }

            Console.WriteLine("***********************************************");

            // Create instances of gas vehicles
            Ram ram = new Ram();
            Cessna cessna150 = new Cessna();

            // Create a list to store gas vehicles
            List<IGas> gasVehicles = new List<IGas>()
            {
                ram, cessna150
            };

            Console.WriteLine("Gas Vehicles");
            foreach (IGas gv in gasVehicles)
            {
                // Print the current fuel gauge reading of each gas vehicle
                Console.WriteLine($"{gv.CurrentFuelGauge}");
            }

            foreach (IGas gv in gasVehicles)
            {
                // Refuel the gas tank of each gas vehicle completely
                gv.RefuelTank();
            }

            foreach (IGas gv in gasVehicles)
            {
                // Print the current fuel gauge reading after refueling
                Console.WriteLine($"{gv.CurrentFuelGauge}");
            }
        }
    }
}
