using DesignPatterns.Classes.Aquarium;
using DesignPatterns.StructuralPatterns.Decorator;

namespace xUnitTests.StructuralPatterns.Decorator;

/// <summary>
/// Influenced by [1]Derek Banas, “Decorator Design Pattern,” YouTube, Sep. 21, 2012.
///     https://www.youtube.com/watch?v=j40kRwSm4VE (accessed Aug. 26, 2025).‌
/// </summary>
public class DecoratorTests
{
    [Fact]
    public void BasicAquarium_PriceOfAquarium_PriceOfAquariumIsFourtyNineNintyNine()
    {
        // Arrange
        BasicAquarium basicAquarium = new();

        // ACT
        var priceOfAquarium = basicAquarium.PriceOfAquarium;

        // Assert
        Assert.Equal(49.99, priceOfAquarium);
    }

    [Fact]
    public void GoldfishDecorator_PriceOfGoldfishWithAquarium_AquariumIsTwentyDollarsMore()
    {
        GoldfishDecorator goldfishAquarium = new();

        var priceOfAquarium = goldfishAquarium.PriceOfAquarium;

        Assert.Equal(69.99, priceOfAquarium);
    }
}