using DesignPatterns.Classes.Aquarium;

namespace DesignPatterns.StructuralPatterns.Decorator;

/// <summary>
/// Influenced by [1]Derek Banas, “Decorator Design Pattern,” YouTube, Sep. 21, 2012.
///     https://www.youtube.com/watch?v=j40kRwSm4VE (accessed Aug. 26, 2025).‌
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