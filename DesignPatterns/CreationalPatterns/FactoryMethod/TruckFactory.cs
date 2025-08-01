using DesignPatterns.Classes.Vehicle;

namespace DesignPatterns.CreationalPatterns.FactoryMethod;

public abstract class TruckFactory
{
    public static IVehicle GenerateRandomVehicle()
    {
        Truck randomTruck = new();
        randomTruck.SelfRandomizedPopulate();
        return randomTruck;
    }
}