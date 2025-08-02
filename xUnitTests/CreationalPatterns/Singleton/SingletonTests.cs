using DesignPatterns.CreationalPatterns.Singleton;

namespace xUnitTests.CreationalPatterns.Singleton;

public class SingletonTests
{
    [Fact]
    public void Singleton_LazyInitializeFountain_ReturnFountainIsNotInUse()
    {
        var waterFountain = WaterFountainSingleton.WaterFountain;
        
        var isWaterFountainInUse = waterFountain.IsFountainInUse;
        
        Assert.False(isWaterFountainInUse);
    }
    
    [Fact]
    public void Singleton_StartUsingFountain_ReturnFountainIsInUse()
    {
        var waterFountain = WaterFountainSingleton.WaterFountain;
        
        waterFountain.StartUsingFountain();
        var isWaterFountainInUse = waterFountain.IsFountainInUse;
        
        Assert.True(isWaterFountainInUse);
    }
    
    [Fact]
    public void Singleton_StartUsingFountainThenStop_ReturnFountainIsNotInUse()
    {
        var waterFountain = WaterFountainSingleton.WaterFountain;
        
        waterFountain.StartUsingFountain();
        waterFountain.StopUsingFountain();
        var isWaterFountainInUse = waterFountain.IsFountainInUse;
        
        Assert.False(isWaterFountainInUse);
    }
    
    [Fact]
    public void Singleton_TwoFountainsOneStartsDrinking_SecondFountainReturnsFountainIsInUse()
    {
        var waterFountain = WaterFountainSingleton.WaterFountain;
        var secondWaterFountain = WaterFountainSingleton.WaterFountain;
        
        waterFountain.StartUsingFountain();
        
        var isWaterFountainInUse = secondWaterFountain.IsFountainInUse;
        
        Assert.True(isWaterFountainInUse);
    }
    
    [Fact]
    public void Singleton_TwoFountainsOneStartsDrinkingAndStopping_SecondFountainReturnsFountainIsInUseThenNotInUse()
    {
        var waterFountain = WaterFountainSingleton.WaterFountain;
        var secondWaterFountain = WaterFountainSingleton.WaterFountain;
        
        waterFountain.StartUsingFountain();
        var wasWaterFountainInUse = secondWaterFountain.IsFountainInUse;
        waterFountain.StopUsingFountain();
        var isWaterFountainInUse = secondWaterFountain.IsFountainInUse;
        
        Assert.True(wasWaterFountainInUse);
        Assert.False(isWaterFountainInUse);
    }
}