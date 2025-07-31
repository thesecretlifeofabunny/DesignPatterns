using DesignPatterns.CreationalPatterns;

namespace xUnitTests;

public class FactoryMethodTests
{
    [Fact]
    public void FactoryMethod_GenerateRandomVehicle_ReturnsNonNullObject()
    {
        var randomlyGeneratedVehicle = FactoryMethod.GenerateRandomVehicle();
        
        Assert.True(randomlyGeneratedVehicle is not null);
    }
    
    [Fact]
    public void FactoryMethod_GenerateRandomVehicle_ReturnsNonNullToString()
    {
        var randomlyGeneratedVehicle = FactoryMethod.GenerateRandomVehicle();

        if (randomlyGeneratedVehicle is null)
        {
            Assert.Fail();
        }
        
        var generatedVehicleToString = randomlyGeneratedVehicle.ToString();
        
        Assert.False(string.IsNullOrWhiteSpace(generatedVehicleToString));
    }
}