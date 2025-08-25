using System.Runtime.InteropServices;
using DesignPatterns.Classes.Appliances;
using DesignPatterns.StructuralPatterns.Adapter;

namespace xUnitTests.StructuralPatterns.Adapter;

public class AdapterTests
{
    [Fact]
    public void ClothesWasher_PutTheClothesIn_ReturnsPutClothesInString()
    {
        ClothesWasher clothesWasher = new();

        var outputMessage = clothesWasher.PutTheClothesIn();
        const string expectedOutput = "Putting the clothes in...";

        Assert.Equal(expectedOutput, outputMessage);
    }

    [Fact]
    public void ClothesWasher_TurnOnWasher_ReturnsTurnOnWasherString()
    {
        ClothesWasher clothesWasher = new();

        var outputMessage = clothesWasher.TurnTheClothesWasherOn();
        const string expectedOutput = "Turning the clothes washer on...";

        Assert.Equal(expectedOutput, outputMessage);
    }

    [Fact]
    public void ClothesWasher_TakeTheClothesOut_ReturnsTakeClothesOutString()
    {
        ClothesWasher clothesWasher = new();

        var outputMessage = clothesWasher.TakeTheClothesOut();
        const string expectedOutput = "Taking the clothes out...";

        Assert.Equal(expectedOutput, outputMessage);
    }

    [Fact]
    public void Adapter_PutTheDishesIn_ReturnsPutClothesInString()
    {
        ClothesWasher clothesWasher = new();
        DishwasherAdapter dishwasherAdapter = new(clothesWasher);

        var outputMessage = dishwasherAdapter.PutTheDishesIn();
        const string expectedOutput = "Putting the clothes in...";

        Assert.Equal(expectedOutput, outputMessage);
    }

    [Fact]
    public void Adapter_StartTheDishwasher_ReturnsTurnOnWasherString()
    {
        ClothesWasher clothesWasher = new();
        DishwasherAdapter dishwasherAdapter = new(clothesWasher);

        var outputMessage = dishwasherAdapter.StartTheDishwasher();
        const string expectedOutput = "Turning the clothes washer on...";

        Assert.Equal(expectedOutput, outputMessage);
    }

    [Fact]
    public void Adapter_TakeTheDishesOut_ReturnsTakeClothesOutString()
    {
        ClothesWasher clothesWasher = new();
        DishwasherAdapter dishwasherAdapter = new(clothesWasher);

        var outputMessage = dishwasherAdapter.TakeTheDishesOut();
        const string expectedOutput = "Taking the clothes out...";

        Assert.Equal(expectedOutput, outputMessage);
    }
}