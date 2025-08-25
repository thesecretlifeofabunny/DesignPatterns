using DesignPatterns.Classes.Vehicle;

namespace DesignPatterns.CreationalPatterns.FactoryMethod;

public abstract class RandomFactoryMethod
{
    private const int CountOfImplementedVehicles = 3;

    public static IVehicle? GenerateRandomVehicle()
    {
        Random randomVehicleGenerator = new();
        var randomVehicleGeneratedSeed = randomVehicleGenerator.Next() % CountOfImplementedVehicles;

        switch (randomVehicleGeneratedSeed)
        {
            case 0:
                Van randomVan = new();
                randomVan.SelfRandomizedPopulate();
                return randomVan;
            case 1:
                Truck randomTruck = new();
                randomTruck.SelfRandomizedPopulate();
                return randomTruck;
            case 2:
                Motorcycle randomMotorcycle = new();
                randomMotorcycle.SelfRandomizedPopulate();
                return randomMotorcycle;
            default:
                return null;
        }
    }
}