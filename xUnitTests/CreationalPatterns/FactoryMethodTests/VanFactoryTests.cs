using DesignPatterns.Classes.Vehicle;
using Xunit.Abstractions;

namespace xUnitTests.CreationalPatterns.FactoryMethodTests;

public class VanFactoryTests(ITestOutputHelper testOutputHelper)
{
    [Fact]
    public void VanFactory_GenerateRandomVehicle_ReturnsNonNullObject()
    {
        var randomlyGeneratedVehicle = DesignPatterns.CreationalPatterns.FactoryMethod.VanFactory.GenerateRandomVehicle();

        Assert.True(randomlyGeneratedVehicle is not null);
    }

    [Fact]
    public void VanFactory_GenerateRandomVehicle_ReturnsNonNullToString()
    {
        var randomlyGeneratedVehicle = DesignPatterns.CreationalPatterns.FactoryMethod.VanFactory.GenerateRandomVehicle();

        var generatedVehicleToString = randomlyGeneratedVehicle.ToString();

        testOutputHelper.WriteLine(generatedVehicleToString);

        Assert.False(string.IsNullOrWhiteSpace(generatedVehicleToString));
    }

    [Fact]
    public void VanFactory_GenerateRandomVehicle_HasNonNullOrWhitespaceManufacturer()
    {
        var randomlyGeneratedVehicle = DesignPatterns.CreationalPatterns.FactoryMethod.VanFactory.GenerateRandomVehicle();

        var generatedVehicleManufacturer = randomlyGeneratedVehicle.Manufacturer;

        Assert.False(string.IsNullOrWhiteSpace(generatedVehicleManufacturer));
    }

    [Fact]
    public void VanFactory_GenerateRandomVehicle_HasNonNullOrWhitespaceName()
    {
        var randomlyGeneratedVehicle = DesignPatterns.CreationalPatterns.FactoryMethod.VanFactory.GenerateRandomVehicle();

        var generatedVehicleNameOfVehicle = randomlyGeneratedVehicle.NameOfVehicle;

        Assert.False(string.IsNullOrWhiteSpace(generatedVehicleNameOfVehicle));
    }

    [Fact]
    public void VanFactory_GenerateRandomVehicle_HasNonZeroAmountOfWheels()
    {
        var randomlyGeneratedVehicle = DesignPatterns.CreationalPatterns.FactoryMethod.VanFactory.GenerateRandomVehicle();

        var generatedVehicleNumberOfWheels = randomlyGeneratedVehicle.NumberOfWheels;

        Assert.True(generatedVehicleNumberOfWheels > 0);
    }

    [Fact]
    public void VanFactory_GenerateRandomVehicle_HasNonNullTypeOfDrive()
    {
        var randomlyGeneratedVehicle = DesignPatterns.CreationalPatterns.FactoryMethod.VanFactory.GenerateRandomVehicle();

        var generatedVehicleTypeOfDrive = randomlyGeneratedVehicle.TypeOfDrive;

        Assert.False(string.IsNullOrWhiteSpace(generatedVehicleTypeOfDrive.ToString()));
    }

    [Fact]
    public void VanFactory_GenerateRandomVehicle_HasNonNegativeMileage()
    {
        var randomlyGeneratedVehicle = DesignPatterns.CreationalPatterns.FactoryMethod.VanFactory.GenerateRandomVehicle();

        var generatedVehicleMileage = randomlyGeneratedVehicle.Mileage;

        Assert.True(generatedVehicleMileage >= 0);
    }

    [Fact]
    public void VanFactory_GenerateRandomVehicle_HasNonNegativeValue()
    {
        var randomlyGeneratedVehicle = DesignPatterns.CreationalPatterns.FactoryMethod.VanFactory.GenerateRandomVehicle();

        var generatedVehicleValue = randomlyGeneratedVehicle.Value;

        Assert.True(generatedVehicleValue >= 0);
    }

    [Fact]
    public void VanFactory_GenerateRandomVehicle_HasNonZeroSeatCount()
    {
        var randomlyGeneratedVehicle = DesignPatterns.CreationalPatterns.FactoryMethod.VanFactory.GenerateRandomVehicle();

        var generatedVehicleSeatCount = randomlyGeneratedVehicle.SeatCount;

        Assert.True(generatedVehicleSeatCount > 0);
    }

    [Fact]
    public void VanFactory_GenerateRandomVehicle_HasNonNegativeStorageCapacity()
    {
        var randomlyGeneratedVehicle = (Van)DesignPatterns.CreationalPatterns.FactoryMethod.VanFactory.GenerateRandomVehicle();

        var generatedVehicleStorageCapacity = randomlyGeneratedVehicle.StorageCapacity;

        Assert.True(generatedVehicleStorageCapacity >= 0);
    }
}