using DesignPatterns.Classes.Vehicle;

namespace DesignPatterns.CreationalPatterns.FactoryMethod;

public abstract class VanFactory : IVehicleFactory
{
    public static IVehicle GenerateRandomVehicle()
    {
        Van randomVan = new();
        randomVan.SelfRandomizedPopulate();
        return randomVan;
    }
}