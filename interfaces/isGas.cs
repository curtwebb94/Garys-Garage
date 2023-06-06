namespace Garage
{
    // Define the namespace "Garage" to encapsulate related types and code.

    public interface IGas
    {
        // Declare an interface named "IGas" for gas-powered vehicles.

        int CurrentFuelGauge { get; }
        // Define a read-only property "CurrentFuelGauge" of type int.
        // It represents the current fuel level in the gas tank.

        bool isGas { get; }
        // Define a read-only property "isGas" of type bool.
        // It indicates whether the vehicle is gas-powered.

        void RefuelTank();
        // Declare a method "RefuelTank()" with no parameters.
        // This method is responsible for refueling the gas tank of the vehicle.
    }
}
