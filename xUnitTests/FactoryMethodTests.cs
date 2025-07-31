using DesignPatterns.CreationalPatterns;
using Xunit.Abstractions;

namespace xUnitTests;

public class FactoryMethodTests(ITestOutputHelper testOutputHelper)
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
        
        testOutputHelper.WriteLine(generatedVehicleToString);
        
        Assert.False(string.IsNullOrWhiteSpace(generatedVehicleToString));
    }
    
    [Fact]
    public void FactoryMethod_GenerateRandomVehicle_HasNonNullOrWhitespaceManufacturer()
    {
        var randomlyGeneratedVehicle = FactoryMethod.GenerateRandomVehicle();

        if (randomlyGeneratedVehicle is null)
        {
            Assert.Fail();
        }
        
        var generatedVehicleManufacturer = randomlyGeneratedVehicle.Manufacturer;
        
        Assert.False(string.IsNullOrWhiteSpace(generatedVehicleManufacturer));
    }
    
    [Fact]
    public void FactoryMethod_GenerateRandomVehicle_HasNonNullOrWhitespaceName()
    {
        var randomlyGeneratedVehicle = FactoryMethod.GenerateRandomVehicle();

        if (randomlyGeneratedVehicle is null)
        {
            Assert.Fail();
        }
        
        var generatedVehicleNameOfVehicle = randomlyGeneratedVehicle.NameOfVehicle;
        
        Assert.False(string.IsNullOrWhiteSpace(generatedVehicleNameOfVehicle));
    }
    
    [Fact]
    public void FactoryMethod_GenerateRandomVehicle_HasNonZeroAmountOfWheels()
    {
        var randomlyGeneratedVehicle = FactoryMethod.GenerateRandomVehicle();

        if (randomlyGeneratedVehicle is null)
        {
            Assert.Fail();
        }
        
        var generatedVehicleNumberOfWheels = randomlyGeneratedVehicle.NumberOfWheels;
        
        Assert.True(generatedVehicleNumberOfWheels > 0);
    }
    
    [Fact]
    public void FactoryMethod_GenerateRandomVehicle_HasNonNullTypeOfDrive()
    {
        var randomlyGeneratedVehicle = FactoryMethod.GenerateRandomVehicle();

        if (randomlyGeneratedVehicle is null)
        {
            Assert.Fail();
        }
        
        var generatedVehicleTypeOfDrive = randomlyGeneratedVehicle.TypeOfDrive;
        
        Assert.False(string.IsNullOrWhiteSpace(generatedVehicleTypeOfDrive.ToString()));
    }
    
    [Fact]
    public void FactoryMethod_GenerateRandomVehicle_HasNonNegativeMileage()
    {
        var randomlyGeneratedVehicle = FactoryMethod.GenerateRandomVehicle();

        if (randomlyGeneratedVehicle is null)
        {
            Assert.Fail();
        }
        
        var generatedVehicleMileage = randomlyGeneratedVehicle.Mileage;
        
        Assert.True(generatedVehicleMileage >= 0);
    }
    
    [Fact]
    public void FactoryMethod_GenerateRandomVehicle_HasNonZeroValue()
    {
        var randomlyGeneratedVehicle = FactoryMethod.GenerateRandomVehicle();

        if (randomlyGeneratedVehicle is null)
        {
            Assert.Fail();
        }
        
        var generatedVehicleValue = randomlyGeneratedVehicle.Value;
        
        Assert.True(generatedVehicleValue >= 0);
    }
    
    [Fact]
    public void FactoryMethod_GenerateRandomVehicle_HasNonZeroSeatCount()
    {
        var randomlyGeneratedVehicle = FactoryMethod.GenerateRandomVehicle();

        if (randomlyGeneratedVehicle is null)
        {
            Assert.Fail();
        }
        
        var generatedVehicleSeatCount = randomlyGeneratedVehicle.SeatCount;
        
        Assert.True(generatedVehicleSeatCount >= 0);
    }
}