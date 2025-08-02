using DesignPatterns.CreationalPatterns.Singleton;

namespace xUnitTests.CreationalPatterns.Singleton;

// TODO figure out thread safe / smart way to test a singleton using unit testing...
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
}