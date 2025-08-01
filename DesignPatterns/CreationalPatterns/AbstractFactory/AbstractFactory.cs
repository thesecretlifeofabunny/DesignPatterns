using DesignPatterns.Classes.Vehicle;

namespace DesignPatterns.CreationalPatterns.AbstractFactory;

public abstract class AbstractFactory
{
    public static void GenerateRandomVehicle(IVehicle vehicleToGenerate) => vehicleToGenerate.SelfRandomizedPopulate();

    public static void ReRollGenerationOnVehicle(IVehicle vehicleToRegenerate) =>
        vehicleToRegenerate.SelfRandomizedPopulate();
}