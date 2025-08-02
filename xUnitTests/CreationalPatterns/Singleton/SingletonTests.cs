using DesignPatterns.CreationalPatterns.Singleton;

namespace xUnitTests.CreationalPatterns.Singleton;

// TODO figure out thread safe / smart way to test a singleton using unit testing...
public class SingletonTests
{
    [Fact]
    public void Singleton_LazyInitializeFountain_ReturnFountainIsNotInUse()
    {
        var isWaterFountainInUse = WaterFountainSingleton.IsFountainInUse;
        
        Assert.False(isWaterFountainInUse);
    }
    
    [Fact]
    public void Singleton_StartUsingFountain_ReturnFountainIsInUse()
    {
        WaterFountainSingleton.StartUsingFountain();
        var isWaterFountainInUse = WaterFountainSingleton.IsFountainInUse;
        
        Assert.True(isWaterFountainInUse);
    } 
    
    [Fact]
    public void Singleton_StartUsingFountainThenStop_ReturnFountainIsNotInUse()
    {
        WaterFountainSingleton.StartUsingFountain();
        WaterFountainSingleton.StopUsingFountain();
        var isWaterFountainInUse = WaterFountainSingleton.IsFountainInUse;
        
        Assert.False(isWaterFountainInUse);
    } 
}