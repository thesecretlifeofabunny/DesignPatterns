using DesignPatterns.Classes.Botanical;

namespace DesignPatterns.StructuralPatterns.Facade;

public static class WaterPlantFacade
{
    public static void WaterThePlant(Plant plantToWater)
    {
        var isPlantAlreadyHydrated =
            plantToWater.HasBeenWateredWithinAWeek || plantToWater.WhereItIsPlanted.HasRainedWithinAWeek;
        if (isPlantAlreadyHydrated)
        {
            Console.WriteLine($"The {plantToWater.NameOfPlant} has already been watered recently");
        }

        WaterPlant(plantToWater);
    }

    private static void WaterPlant(Plant plantToWater)
    {
        plantToWater.HasBeenWateredWithinAWeek = true;
        Console.WriteLine($"{plantToWater.NameOfPlant} is now watered :)");
    }
}