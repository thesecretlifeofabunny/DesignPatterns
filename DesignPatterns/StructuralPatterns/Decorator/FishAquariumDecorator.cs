using DesignPatterns.Classes.Aquarium;

namespace DesignPatterns.StructuralPatterns.Decorator;

/// <summary>
/// Influenced by Youtu.be, 2025. https://youtu.be/j40kRwSm4VE (accessed Aug. 26, 2025).
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