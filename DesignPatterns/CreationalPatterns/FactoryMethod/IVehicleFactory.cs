using DesignPatterns.Classes.Vehicle;

namespace DesignPatterns.CreationalPatterns.FactoryMethod;

public interface IVehicleFactory
{
    public static abstract IVehicle GenerateRandomVehicle();
}