using Xunit.Abstractions;

namespace xUnitTests.CreationalPatterns.FactoryMethod;

public class MotorcycleFactoryTests(ITestOutputHelper testOutputHelper)
{
    [Fact]
    public void MotorcycleFactory_GenerateRandomVehicle_ReturnsNonNullObject()
    {
        var randomlyGeneratedVehicle = DesignPatterns.CreationalPatterns.FactoryMethod.MotorcycleFactory.GenerateRandomVehicle();

        Assert.True(randomlyGeneratedVehicle is not null);
    }

    [Fact]
    public void MotorcycleFactory_GenerateRandomVehicle_ReturnsNonNullToString()
    {
        var randomlyGeneratedVehicle = DesignPatterns.CreationalPatterns.FactoryMethod.MotorcycleFactory.GenerateRandomVehicle();

        var generatedVehicleToString = randomlyGeneratedVehicle.ToString();

        testOutputHelper.WriteLine(generatedVehicleToString);

        Assert.False(string.IsNullOrWhiteSpace(generatedVehicleToString));
    }

    [Fact]
    public void MotorcycleFactory_GenerateRandomVehicle_HasNonNullOrWhitespaceManufacturer()
    {
        var randomlyGeneratedVehicle = DesignPatterns.CreationalPatterns.FactoryMethod.MotorcycleFactory.GenerateRandomVehicle();

        var generatedVehicleManufacturer = randomlyGeneratedVehicle.Manufacturer;

        Assert.False(string.IsNullOrWhiteSpace(generatedVehicleManufacturer));
    }

    [Fact]
    public void MotorcycleFactory_GenerateRandomVehicle_HasNonNullOrWhitespaceName()
    {
        var randomlyGeneratedVehicle = DesignPatterns.CreationalPatterns.FactoryMethod.MotorcycleFactory.GenerateRandomVehicle();

        var generatedVehicleNameOfVehicle = randomlyGeneratedVehicle.NameOfVehicle;

        Assert.False(string.IsNullOrWhiteSpace(generatedVehicleNameOfVehicle));
    }

    [Fact]
    public void FMotorcycleFactory_GenerateRandomVehicle_HasNonZeroAmountOfWheels()
    {
        var randomlyGeneratedVehicle = DesignPatterns.CreationalPatterns.FactoryMethod.MotorcycleFactory.GenerateRandomVehicle();

        var generatedVehicleNumberOfWheels = randomlyGeneratedVehicle.NumberOfWheels;

        Assert.True(generatedVehicleNumberOfWheels > 0);
    }

    [Fact]
    public void MotorcycleFactory_GenerateRandomVehicle_HasNonNullTypeOfDrive()
    {
        var randomlyGeneratedVehicle = DesignPatterns.CreationalPatterns.FactoryMethod.MotorcycleFactory.GenerateRandomVehicle();

        var generatedVehicleTypeOfDrive = randomlyGeneratedVehicle.TypeOfDrive;

        Assert.False(string.IsNullOrWhiteSpace(generatedVehicleTypeOfDrive.ToString()));
    }

    [Fact]
    public void MotorcycleFactory_GenerateRandomVehicle_HasNonNegativeMileage()
    {
        var randomlyGeneratedVehicle = DesignPatterns.CreationalPatterns.FactoryMethod.MotorcycleFactory.GenerateRandomVehicle();

        var generatedVehicleMileage = randomlyGeneratedVehicle.Mileage;

        Assert.True(generatedVehicleMileage >= 0);
    }

    [Fact]
    public void MotorcycleFactory_GenerateRandomVehicle_HasNonNegativeValue()
    {
        var randomlyGeneratedVehicle = DesignPatterns.CreationalPatterns.FactoryMethod.MotorcycleFactory.GenerateRandomVehicle();

        var generatedVehicleValue = randomlyGeneratedVehicle.Value;

        Assert.True(generatedVehicleValue > 0);
    }

    [Fact]
    public void MotorcycleFactory_GenerateRandomVehicle_HasNonZeroSeatCount()
    {
        var randomlyGeneratedVehicle = DesignPatterns.CreationalPatterns.FactoryMethod.MotorcycleFactory.GenerateRandomVehicle();

        var generatedVehicleSeatCount = randomlyGeneratedVehicle.SeatCount;

        Assert.True(generatedVehicleSeatCount > 0);
    }
}