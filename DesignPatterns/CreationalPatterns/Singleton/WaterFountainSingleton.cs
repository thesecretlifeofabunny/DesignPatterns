namespace DesignPatterns.CreationalPatterns.Singleton;

public sealed class WaterFountainSingleton
{
    private static readonly Lazy<WaterFountainSingleton> LazyWaterFountain =
        new(() => new WaterFountainSingleton());

    public static WaterFountainSingleton WaterFountain => LazyWaterFountain.Value;

    public bool IsFountainInUse { get; private set; }

    public void StartUsingFountain() => IsFountainInUse = true;

    public void StopUsingFountain() => IsFountainInUse = false;

    private WaterFountainSingleton() {}
}