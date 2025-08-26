namespace DesignPatterns.Classes.Aquarium;

/// <summary>
/// Influenced by [1]Derek Banas, “Decorator Design Pattern,” YouTube, Sep. 21, 2012.
///     https://www.youtube.com/watch?v=j40kRwSm4VE (accessed Aug. 26, 2025).‌
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