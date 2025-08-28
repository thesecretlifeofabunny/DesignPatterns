using DesignPatterns.Classes.Vehicle;
using Xunit.Abstractions;

namespace xUnitTests.CreationalPatterns.FactoryMethodTests;

public class TruckFactory(ITestOutputHelper testOutputHelper)
{
    [Fact]
    public void TruckFactory_GenerateRandomVehicle_ReturnsNonNullObject()
    {
        var randomlyGeneratedVehicle = DesignPatterns.CreationalPatterns.FactoryMethod.TruckFactory.GenerateRandomVehicle();

        Assert.True(randomlyGeneratedVehicle is not null);
    }

    [Fact]
    public void TruckFactory_GenerateRandomVehicle_ReturnsNonNullToString()
    {
        var randomlyGeneratedVehicle = DesignPatterns.CreationalPatterns.FactoryMethod.TruckFactory.GenerateRandomVehicle();

        var generatedVehicleToString = randomlyGeneratedVehicle.ToString();

        testOutputHelper.WriteLine(generatedVehicleToString);

        Assert.False(string.IsNullOrWhiteSpace(generatedVehicleToString));
    }

    [Fact]
    public void TruckFactory_GenerateRandomVehicle_HasNonNullOrWhitespaceManufacturer()
    {
        var randomlyGeneratedVehicle = DesignPatterns.CreationalPatterns.FactoryMethod.TruckFactory.GenerateRandomVehicle();

        var generatedVehicleManufacturer = randomlyGeneratedVehicle.Manufacturer;

        Assert.False(string.IsNullOrWhiteSpace(generatedVehicleManufacturer));
    }

    [Fact]
    public void TruckFactory_GenerateRandomVehicle_HasNonNullOrWhitespaceName()
    {
        var randomlyGeneratedVehicle = DesignPatterns.CreationalPatterns.FactoryMethod.TruckFactory.GenerateRandomVehicle();

        var generatedVehicleNameOfVehicle = randomlyGeneratedVehicle.NameOfVehicle;

        Assert.False(string.IsNullOrWhiteSpace(generatedVehicleNameOfVehicle));
    }

    [Fact]
    public void TruckFactory_GenerateRandomVehicle_HasNonZeroAmountOfWheels()
    {
        var randomlyGeneratedVehicle = DesignPatterns.CreationalPatterns.FactoryMethod.TruckFactory.GenerateRandomVehicle();

        var generatedVehicleNumberOfWheels = randomlyGeneratedVehicle.NumberOfWheels;

        Assert.True(generatedVehicleNumberOfWheels > 0);
    }

    [Fact]
    public void TruckFactory_GenerateRandomVehicle_HasNonNullTypeOfDrive()
    {
        var randomlyGeneratedVehicle = DesignPatterns.CreationalPatterns.FactoryMethod.TruckFactory.GenerateRandomVehicle();

        var generatedVehicleTypeOfDrive = randomlyGeneratedVehicle.TypeOfDrive;

        Assert.False(string.IsNullOrWhiteSpace(generatedVehicleTypeOfDrive.ToString()));
    }

    [Fact]
    public void TruckFactory_GenerateRandomVehicle_HasNonNegativeMileage()
    {
        var randomlyGeneratedVehicle = DesignPatterns.CreationalPatterns.FactoryMethod.TruckFactory.GenerateRandomVehicle();

        var generatedVehicleMileage = randomlyGeneratedVehicle.Mileage;

        Assert.True(generatedVehicleMileage >= 0);
    }

    [Fact]
    public void TruckFactory_GenerateRandomVehicle_HasNonNegativeValue()
    {
        var randomlyGeneratedVehicle = DesignPatterns.CreationalPatterns.FactoryMethod.TruckFactory.GenerateRandomVehicle();

        var generatedVehicleValue = randomlyGeneratedVehicle.Value;

        Assert.True(generatedVehicleValue >= 0);
    }

    [Fact]
    public void TruckFactory_GenerateRandomVehicle_HasNonZeroSeatCount()
    {
        var randomlyGeneratedVehicle = DesignPatterns.CreationalPatterns.FactoryMethod.TruckFactory.GenerateRandomVehicle();

        var generatedVehicleSeatCount = randomlyGeneratedVehicle.SeatCount;

        Assert.True(generatedVehicleSeatCount > 0);
    }

    [Fact]
    public void TruckFactory_GenerateRandomVehicle_HasNegativeTruckBedSize()
    {
        var randomlyGeneratedVehicle = (Truck)DesignPatterns.CreationalPatterns.FactoryMethod.TruckFactory.GenerateRandomVehicle();

        var generatedVehicleTruckBedSize = randomlyGeneratedVehicle.TruckBedSize;

        Assert.True(generatedVehicleTruckBedSize >= 0);
    }

    [Fact]
    public void TruckFactory_GenerateRandomVehicle_HasNonNegativeTowWeightCapacity()
    {
        var randomlyGeneratedVehicle = (Truck)DesignPatterns.CreationalPatterns.FactoryMethod.TruckFactory.GenerateRandomVehicle();

        var generatedVehicleTowWeightCapacity = randomlyGeneratedVehicle.TowWeightCapacity;

        Assert.True(generatedVehicleTowWeightCapacity >= 0);
    }
}