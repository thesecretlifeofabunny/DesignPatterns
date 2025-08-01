namespace DesignPatterns.Classes.Vehicle;

public class Van : IVehicle
{
    private readonly string[] _randomManufacturerOptions = ["Volkswagen", "Mercedes-Benz", "Kia", "Toyota", "Honda"];
    private readonly Dictionary<string, string[]> _randomNameOfVehicles = new()
    {
        {"Volkswagen", ["ID.Buzz Microbus"]},
        {"Mercedes-Benz", ["Sprinter", "eSprinter" ]},
        {"Kia", ["Carnival"]},
        {"Toyota", ["Sienna Hybrid", "Sienna"]},
        {"Honda", ["Odyssey"]}
    };

    public string Manufacturer { get; set; } = string.Empty;

    public string NameOfVehicle { get; set; } = string.Empty;

    public int NumberOfWheels { get; set; } = 2;

    public DriveType TypeOfDrive { get; set; }

    public int Mileage { get; set; }

    public double Value { get; set; }

    public int SeatCount { get; set; }

    public double StorageCapacity { get; set; }

    private bool FoldableSeat { get; set; }
    
    public void RegenerateVehicle() => SelfRandomizedPopulate();
    
    public void  SelfRandomizedPopulate()
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
        const int randomSeatCountUpperLimit = 9;
        var randomSeatCount = randomGenerator.Next(randomSeatLowerLimit, randomSeatCountUpperLimit);
        
        const int randomStorageSizeLowerLimit = 18;
        const int randomStorageSizeUpperLimit = 30;
        var randomStorageSize = randomGenerator.Next(randomStorageSizeLowerLimit, randomStorageSizeUpperLimit);
        
        var foldableSeat = randomGenerator.Next() % 2 == 0;

            Manufacturer = randomManufacturer;
            NameOfVehicle = randomVehicleName;
            TypeOfDrive = randomDriveType;
            Mileage = randomMileage;
            Value = randomValue;
            SeatCount = randomSeatCount;
            StorageCapacity = randomStorageSize;
            FoldableSeat = foldableSeat;
    }

    public override string ToString()
    {
        var advertisementString =
            $"YEEHAW!! We got a {Manufacturer} {NameOfVehicle} with {TypeOfDrive}" + 
            $" with only a mileage of {Mileage} KMs and a value at ${Value}!" +
            $" Also not to mention the storage capacity of {StorageCapacity}inches squared.";

        if (FoldableSeat)
        {
            advertisementString += "This also comes with a row of foldable seats!";
        }

        return advertisementString;
    }
}