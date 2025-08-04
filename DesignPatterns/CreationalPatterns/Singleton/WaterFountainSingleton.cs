namespace DesignPatterns.CreationalPatterns.Singleton;

// This could all be static, but I like the object version more as it lends to easier testing. 
// In real world in asp.net apps I would use services.AddSingleton<>
// Or prefer the static version, but depends on context on if I want the object passing or not...
public sealed class WaterFountainSingleton
{
    private static readonly Lazy<WaterFountainSingleton> LazyWaterFountain =
        new(() => new WaterFountainSingleton());

    public static WaterFountainSingleton WaterFountain => LazyWaterFountain.Value;

    public bool IsFountainInUse { get; private set; }

    public void StartUsingFountain() => IsFountainInUse = true;

    public void StopUsingFountain() => IsFountainInUse = false;
}