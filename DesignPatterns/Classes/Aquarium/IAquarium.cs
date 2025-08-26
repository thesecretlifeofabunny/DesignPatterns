namespace DesignPatterns.Classes.Aquarium;

/// <summary>
/// Influenced by Youtu.be, 2025. https://youtu.be/j40kRwSm4VE (accessed Aug. 26, 2025).
/// </summary>
public interface IAquarium
{
    public int SizeOfAquariumInGallons { get; }
    public double PriceOfAquarium { get; }

    public abstract void AquariumDescription();
}