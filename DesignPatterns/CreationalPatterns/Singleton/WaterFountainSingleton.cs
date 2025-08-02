namespace DesignPatterns.CreationalPatterns.Singleton;

public sealed class WaterFountainSingleton
{
    private static readonly Lazy<WaterFountainSingleton> LazyWaterFountain =
        new(() => new WaterFountainSingleton());

    public static WaterFountainSingleton WaterFountain => LazyWaterFountain.Value;

    public static bool IsFountainInUse { get; private set; }

    public static void StartUsingFountain() => IsFountainInUse = true;

    public static void StopUsingFountain() => IsFountainInUse = false;

    private WaterFountainSingleton() {}
}