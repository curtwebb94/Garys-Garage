namespace Garage
{
    // Define the namespace "Garage" to encapsulate related types and code.

    public interface IElectric
    {
        // Declare an interface named "IElectric" for electric vehicles.

        int CurrentChargePercentage { get; }
        // Define a read-only property "CurrentChargePercentage" of type int.
        // It represents the current charge level of the battery in percentage.

        bool isElectric { get; }
        // Define a read-only property "isElectric" of type bool.
        // It indicates whether the vehicle is electric.

        void ChargeBattery();
        // Declare a method "ChargeBattery()" with no parameters.
        // This method is responsible for charging the battery of the electric vehicle.
    }
}
