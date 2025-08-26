namespace DesignPatterns.Classes.Aquarium;

/// <summary>
/// Influenced by [1]Derek Banas, “Decorator Design Pattern,” YouTube, Sep. 21, 2012.
///     https://www.youtube.com/watch?v=j40kRwSm4VE (accessed Aug. 26, 2025).‌
/// </summary>
public interface IAquarium
{
    public int SizeOfAquariumInGallons { get; }
    public double PriceOfAquarium { get; }

    public abstract void AquariumDescription();
}