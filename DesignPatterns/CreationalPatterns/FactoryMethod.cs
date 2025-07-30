using DesignPatterns.Classes.Vehicle;

namespace DesignPatterns.CreationalPatterns;

public class FactoryMethod
{
    public static void GenerateRandomVehicle()
    {
        Random randomVehicleGenerator = new();

        // TODO return the corresponding vehicle
        switch (randomVehicleGenerator.Next() % 3)
        {
            case 0:
                break;
            case 1:
                break;
            case 2:
                break;
        }
    }
}