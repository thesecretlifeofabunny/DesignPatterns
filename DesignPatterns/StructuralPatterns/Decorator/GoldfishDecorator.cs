using DesignPatterns.Classes.Aquarium;

namespace DesignPatterns.StructuralPatterns.Decorator;

/// <summary>
/// Influenced by Youtu.be, 2025. https://youtu.be/j40kRwSm4VE (accessed Aug. 26, 2025).
/// </summary>
public class GoldfishDecorator() : FishAquariumDecorator()
{
    public new double PriceOfAquarium { get; } = 69.99;
    
    public new void AquariumDescription()
    {
        Console.WriteLine($"An aquarium of size {SizeOfAquariumInGallons} gallons for only {PriceOfAquarium} also" +
                          $"including a goldfish!");
    }
}