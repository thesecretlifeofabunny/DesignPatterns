namespace DesignPatterns.Classes.Vehicle;

public class Truck(
    string manufacturer,
    string nameOfVehicle,
    int numberOfWheels,
    DriveType typeOfDrive,
    int mileage,
    double value,
    int seatCount,
    double truckBedSize,
    double towWeightCapacity)
    : IVehicle
{

    private readonly string[] _randomManufacturerOptions = ["GMC", "Ford", "Toyota", "Dodge", "Rivian"];
    private readonly Dictionary<string, string[]> _randomNameOfVehicles = new()
    {
        {"GMC", ["Sierra", "Denalli"]},
        {"Ford", ["F-150", "F-150 Platinum", "F-150 Limited" ]},
        {"Toyota", ["Tundra", "Tacoma", "Land Cruiser"]},
        {"Dodge", ["RAM 1500", "RAM 2500", "RAM 3500"]},
        {"Rivian", ["R1T"]}
    };
    private readonly int[] _randomWheelOptions = [4, 6, 8];
    
    public string Manufacturer { get; set; } = manufacturer;

    public string NameOfVehicle { get; set; } = nameOfVehicle;

    public int NumberOfWheels { get; set; } = numberOfWheels;

    public DriveType TypeOfDrive { get; set; } = typeOfDrive;

    public int Mileage { get; set; } = mileage;

    public double Value { get; set; } = value;

    public int SeatCount { get; set; } = seatCount;

    private double TruckBedSize { get; set; } = truckBedSize;

    private double TowWeightCapacity { get; set; } = towWeightCapacity;
    
    public IVehicle GetRandomizedVehicle()
    {
        Random randomGenerator = new();
        var randomManufacturerSeed = randomGenerator.Next() % _randomManufacturerOptions.Length;
        var randomManufacturer = _randomManufacturerOptions[randomManufacturerSeed];

        var resultOfDictionaryRandomGet = _randomNameOfVehicles.TryGetValue(randomManufacturer, out var arrayOfVehicles);

        if (!resultOfDictionaryRandomGet)
        {
            throw new KeyNotFoundException();
        }
        
        if (arrayOfVehicles is null)
        {
            throw new NullReferenceException();
        }

        var randomVehicleNameSeed = randomGenerator.Next() % arrayOfVehicles.Length;
        var randomVehicleName = arrayOfVehicles[randomVehicleNameSeed];

        var randomWheelCountSeed = randomGenerator.Next() % _randomWheelOptions.Length;
        var randomWheelCount = _randomWheelOptions[randomWheelCountSeed];
        
        var typeOfDriveArray = Enum.GetValues(typeof(DriveType));
        var randomDriveTypeSeed = randomGenerator.Next() % typeOfDriveArray.Length;
        var randomDriveTypeInt = typeOfDriveArray.GetValue(randomDriveTypeSeed);
        if (randomDriveTypeInt is null)
        {
            throw new NullReferenceException();
        }

        var randomDriveType = (DriveType)randomDriveTypeInt;

        const int randomMileageUpperLimit = 1000000;
        var randomMileage = randomGenerator.Next(randomMileageUpperLimit);
        
        const int randomValueUpperLimit = 200000;
        var randomValue = randomGenerator.Next(randomValueUpperLimit);
        
        const int randomSeatLowerLimit = 5;
        const int randomSeatCountUpperLimit = 7;
        var randomSeatCount = randomGenerator.Next(randomSeatLowerLimit, randomSeatCountUpperLimit);
        
        const int randomTruckBedSizeLowerLimit = 18;
        const int randomTruckBedSizeUpperLimit = 30;
        var randomTruckBedSize = randomGenerator.Next(randomTruckBedSizeLowerLimit, randomTruckBedSizeUpperLimit);
        
        const int randomTowWeightCapacityLowerLimit = 2000;
        const int randomTowWeightCapacityUpperLimit = 15000;
        var randomTowWeightCapacity = randomGenerator.Next(randomTowWeightCapacityLowerLimit, randomTowWeightCapacityUpperLimit);
        
        return new Truck(
            randomManufacturer,
            randomVehicleName,
            randomWheelCount,
            randomDriveType,
            randomMileage,
            randomValue,
            randomSeatCount,
            randomTruckBedSize,
            randomTowWeightCapacity
            );
    }

    public override string? ToString()
    {
        var advertisementString =
            $"YEEHAW!! We got a {Manufacturer} {NameOfVehicle} with {TypeOfDrive} and {NumberOfWheels} wheels" + 
            $"with only a mileage of {Mileage} KMs and a value at ${Value}!" +
            $"Also not to mention the truck bed size of {TruckBedSize}feet squared," +
            $" and a tow capacity of {TowWeightCapacity}kg!!!";
        
        Console.WriteLine(advertisementString);
        return null;
    }
}