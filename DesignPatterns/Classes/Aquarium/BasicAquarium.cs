namespace DesignPatterns.Classes.Aquarium;

/// <summary>
/// Influenced by Youtu.be, 2025. https://youtu.be/j40kRwSm4VE (accessed Aug. 26, 2025).
/// </summary>
public class BasicAquarium : IAquarium
{
    public int SizeOfAquariumInGallons { get; } = 10;
    public double PriceOfAquarium { get; } = 49.99;

    public void AquariumDescription()
    {
        Console.WriteLine($"Empty {SizeOfAquariumInGallons} gallon aquarium for only {PriceOfAquarium} dollars!");
    }
}