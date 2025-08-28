using DesignPatterns.Classes.Vehicle;
using Xunit.Abstractions;

namespace xUnitTests.CreationalPatterns;

public class AbstractFactoryTests(ITestOutputHelper testOutputHelper)
{
    [Fact]
    public void AbstractFactory_GenerateRandomTruck_ReturnsNonNullObject()
    {
        Truck toTestTruckGeneration = new();

        DesignPatterns.CreationalPatterns.AbstractFactory.AbstractFactory.GenerateRandomVehicle(toTestTruckGeneration);

        Assert.True(toTestTruckGeneration is not null);
    }

    [Fact]
    public void AbstractFactory_GenerateRandomVan_ReturnsNonNullToString()
    {
        Van toTestVan = new();

        DesignPatterns.CreationalPatterns.AbstractFactory.AbstractFactory.GenerateRandomVehicle(toTestVan);

        var generatedVehicleToString = toTestVan.ToString();

        testOutputHelper.WriteLine(generatedVehicleToString);

        Assert.False(string.IsNullOrWhiteSpace(generatedVehicleToString));
    }

    [Fact]
    public void AbstractFactory_GenerateRandomMotorcycle_HasNonNullOrWhitespaceManufacturer()
    {
        Motorcycle toTestMotorcycle = new();
        DesignPatterns.CreationalPatterns.AbstractFactory.AbstractFactory.GenerateRandomVehicle(toTestMotorcycle);

        var generatedVehicleManufacturer = toTestMotorcycle.Manufacturer;

        Assert.False(string.IsNullOrWhiteSpace(generatedVehicleManufacturer));
    }

    [Fact]
    public void AbstractFactory_GenerateRandomTruck_HasNonNullOrWhitespaceName()
    {
        Truck toTestTruck = new();
        DesignPatterns.CreationalPatterns.AbstractFactory.AbstractFactory.GenerateRandomVehicle(toTestTruck);

        var generatedVehicleNameOfVehicle = toTestTruck.NameOfVehicle;

        Assert.False(string.IsNullOrWhiteSpace(generatedVehicleNameOfVehicle));
    }

    [Fact]
    public void AbstractFactory_GenerateRandomVan_HasNonZeroAmountOfWheels()
    {
        Van toTestVan = new();
        DesignPatterns.CreationalPatterns.AbstractFactory.AbstractFactory.GenerateRandomVehicle(toTestVan);

        var generatedVehicleNumberOfWheels = toTestVan.NumberOfWheels;

        Assert.True(generatedVehicleNumberOfWheels > 0);
    }

    [Fact]
    public void AbstractFactory_GenerateRandomMotorcycle_HasNonNullTypeOfDrive()
    {
        Motorcycle toTestMotorcycle = new();
        DesignPatterns.CreationalPatterns.AbstractFactory.AbstractFactory.GenerateRandomVehicle(toTestMotorcycle);

        var generatedVehicleTypeOfDrive = toTestMotorcycle.TypeOfDrive;

        Assert.False(string.IsNullOrWhiteSpace(generatedVehicleTypeOfDrive.ToString()));
    }

    [Fact]
    public void AbstractFactory_GenerateRandomTruck_HasNonNegativeMileage()
    {
        Truck toTestTruck = new();
        DesignPatterns.CreationalPatterns.AbstractFactory.AbstractFactory.GenerateRandomVehicle(toTestTruck);

        var generatedVehicleMileage = toTestTruck.Mileage;

        Assert.True(generatedVehicleMileage >= 0);
    }

    [Fact]
    public void AbstractFactory_GenerateRandomVan_HasNonNegativeValue()
    {
        Van toTestVan = new();
        DesignPatterns.CreationalPatterns.AbstractFactory.AbstractFactory.GenerateRandomVehicle(toTestVan);

        var generatedVehicleValue = toTestVan.Value;

        Assert.True(generatedVehicleValue >= 0);
    }

    [Fact]
    public void AbstractFactory_GenerateRandomMotorcycle_HasNonZeroSeatCount()
    {
        Motorcycle toTestMotorcycle = new();
        DesignPatterns.CreationalPatterns.AbstractFactory.AbstractFactory.GenerateRandomVehicle(toTestMotorcycle);

        var generatedVehicleSeatCount = toTestMotorcycle.SeatCount;

        Assert.True(generatedVehicleSeatCount > 0);
    }

    [Fact]
    public void AbstractFactory_ReRollGenerationOnVehicleTruck_ReturnsNonNullObject()
    {
        Truck toTestTruckGeneration = new();

        DesignPatterns.CreationalPatterns.AbstractFactory.AbstractFactory.GenerateRandomVehicle(toTestTruckGeneration);
        DesignPatterns.CreationalPatterns.AbstractFactory.AbstractFactory.ReRollGenerationOnVehicle(toTestTruckGeneration);

        Assert.True(toTestTruckGeneration is not null);
    }

    [Fact]
    public void AbstractFactory_ReRollGenerationOnVehicleVan_ReturnsNonNullToString()
    {
        Van toTestVan = new();

        DesignPatterns.CreationalPatterns.AbstractFactory.AbstractFactory.GenerateRandomVehicle(toTestVan);
        DesignPatterns.CreationalPatterns.AbstractFactory.AbstractFactory.ReRollGenerationOnVehicle(toTestVan);

        var generatedVehicleToString = toTestVan.ToString();

        testOutputHelper.WriteLine(generatedVehicleToString);

        Assert.False(string.IsNullOrWhiteSpace(generatedVehicleToString));
    }

    [Fact]
    public void AbstractFactory_ReRollGenerationOnVehicleMotorcycle_HasNonNullOrWhitespaceManufacturer()
    {
        Motorcycle toTestMotorcycle = new();

        DesignPatterns.CreationalPatterns.AbstractFactory.AbstractFactory.GenerateRandomVehicle(toTestMotorcycle);
        DesignPatterns.CreationalPatterns.AbstractFactory.AbstractFactory.ReRollGenerationOnVehicle(toTestMotorcycle);

        var generatedVehicleManufacturer = toTestMotorcycle.Manufacturer;

        Assert.False(string.IsNullOrWhiteSpace(generatedVehicleManufacturer));
    }

    [Fact]
    public void AbstractFactory_ReRollGenerationOnVehicleTruck_HasNonNullOrWhitespaceName()
    {
        Truck toTestTruck = new();
        DesignPatterns.CreationalPatterns.AbstractFactory.AbstractFactory.GenerateRandomVehicle(toTestTruck);
        DesignPatterns.CreationalPatterns.AbstractFactory.AbstractFactory.ReRollGenerationOnVehicle(toTestTruck);

        var generatedVehicleNameOfVehicle = toTestTruck.NameOfVehicle;

        Assert.False(string.IsNullOrWhiteSpace(generatedVehicleNameOfVehicle));
    }

    [Fact]
    public void AbstractFactory_ReRollGenerationOnVehicleVan_HasNonZeroAmountOfWheels()
    {
        Van toTestVan = new();
        DesignPatterns.CreationalPatterns.AbstractFactory.AbstractFactory.GenerateRandomVehicle(toTestVan);
        DesignPatterns.CreationalPatterns.AbstractFactory.AbstractFactory.ReRollGenerationOnVehicle(toTestVan);

        var generatedVehicleNumberOfWheels = toTestVan.NumberOfWheels;

        Assert.True(generatedVehicleNumberOfWheels > 0);
    }

    [Fact]
    public void AbstractFactory_ReRollGenerationOnVehicleMotorcycle_HasNonNullTypeOfDrive()
    {
        Motorcycle toTestMotorcycle = new();
        DesignPatterns.CreationalPatterns.AbstractFactory.AbstractFactory.GenerateRandomVehicle(toTestMotorcycle);
        DesignPatterns.CreationalPatterns.AbstractFactory.AbstractFactory.ReRollGenerationOnVehicle(toTestMotorcycle);

        var generatedVehicleTypeOfDrive = toTestMotorcycle.TypeOfDrive;

        Assert.False(string.IsNullOrWhiteSpace(generatedVehicleTypeOfDrive.ToString()));
    }

    [Fact]
    public void AbstractFactory_ReRollGenerationOnVehicleTruck_HasNonNegativeMileage()
    {
        Truck toTestTruck = new();
        DesignPatterns.CreationalPatterns.AbstractFactory.AbstractFactory.GenerateRandomVehicle(toTestTruck);
        DesignPatterns.CreationalPatterns.AbstractFactory.AbstractFactory.ReRollGenerationOnVehicle(toTestTruck);

        var generatedVehicleMileage = toTestTruck.Mileage;

        Assert.True(generatedVehicleMileage >= 0);
    }

    [Fact]
    public void AbstractFactory_ReRollGenerationOnVehicleVan_HasNegativeValue()
    {
        Van toTestVan = new();
        DesignPatterns.CreationalPatterns.AbstractFactory.AbstractFactory.GenerateRandomVehicle(toTestVan);
        DesignPatterns.CreationalPatterns.AbstractFactory.AbstractFactory.ReRollGenerationOnVehicle(toTestVan);

        var generatedVehicleValue = toTestVan.Value;

        Assert.True(generatedVehicleValue >= 0);
    }

    [Fact]
    public void AbstractFactory_ReRollGenerationOnVehicleMotorcycle_HasNonZeroSeatCount()
    {
        Motorcycle toTestMotorcycle = new();
        DesignPatterns.CreationalPatterns.AbstractFactory.AbstractFactory.GenerateRandomVehicle(toTestMotorcycle);
        DesignPatterns.CreationalPatterns.AbstractFactory.AbstractFactory.ReRollGenerationOnVehicle(toTestMotorcycle);

        var generatedVehicleSeatCount = toTestMotorcycle.SeatCount;

        Assert.True(generatedVehicleSeatCount > 0);
    }
}