using DesignPatterns.Classes.Aquarium;

namespace DesignPatterns.StructuralPatterns.Decorator;

/// <summary>
/// Influenced by [1]Derek Banas, “Decorator Design Pattern,” YouTube, Sep. 21, 2012.
///     https://www.youtube.com/watch?v=j40kRwSm4VE (accessed Aug. 26, 2025).‌
/// </summary>
public class FishAquariumDecorator() : IAquarium
{
    public int SizeOfAquariumInGallons { get; } = 10;
    public double PriceOfAquarium { get; } = 49.99;

    public void AquariumDescription()
    {
        Console.WriteLine($"An aquarium of size {SizeOfAquariumInGallons} gallons for only {PriceOfAquarium}");
    }
}