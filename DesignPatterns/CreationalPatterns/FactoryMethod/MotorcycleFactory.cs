using DesignPatterns.Classes.Vehicle;

namespace DesignPatterns.CreationalPatterns.FactoryMethod;

public abstract class MotorcycleFactory : IVehicleFactory
{
    public static IVehicle GenerateRandomVehicle()
    {
        Motorcycle randomMotorcycle = new();
        randomMotorcycle.SelfRandomizedPopulate();
        return randomMotorcycle;
    }
}