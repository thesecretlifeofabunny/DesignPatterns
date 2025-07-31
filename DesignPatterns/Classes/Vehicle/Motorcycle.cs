namespace DesignPatterns.Classes.Vehicle;

public class Motorcycle : IVehicle
{
    
    private readonly string[] _randomManufacturerOptions = ["BMW", "Royal Enfield", "Triumph", "CFMoto", "Ducati"];
    private readonly Dictionary<string, string[]> _randomNameOfVehicles = new()
    {
        {"BMW", ["M1000RR", "Motorrad Concept RR", "CE04", "R12 nineT", "K1600 Grand America"]},
        {"Royal Enfield", ["PROMOTIONS", "CLASSIC 350 CHROME", "CLASSIC 350 HALYCON" ]},
        {"Triumph", ["SPEED TWIN 1200 RS", "SPEED TWIN 1200 BASE", ""]},
        {"CFMoto", ["PAPIO SS", "PAPIO CL", "300NK"]},
        {"Ducati", ["XDiavel V4", "Ducati Desmo450 MX", "Multistrada V2"]}
    };

    public string Manufacturer { get; set; } = string.Empty;

    public string NameOfVehicle { get; set; } = string.Empty;

    public int NumberOfWheels { get; set; } = 2;

    public DriveType TypeOfDrive { get; set; } = DriveType.RearWheel;

    public int Mileage { get; set; }

    public double Value { get; set; }

    public int SeatCount { get; set; }

    private bool HasSideCar { get; set; }

    public void SelfRandomizedPopulate()
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
        
        const int randomMileageUpperLimit = 1000000;
        var randomMileage = randomGenerator.Next(randomMileageUpperLimit);
        
        const int randomValueUpperLimit = 200000;
        var randomValue = randomGenerator.Next(randomValueUpperLimit);
        
        const int randomSeatLowerLimit = 1;
        const int randomSeatCountUpperLimit = 3;
        var randomSeatCount = randomGenerator.Next(randomSeatLowerLimit, randomSeatCountUpperLimit);
        
        var hasSideCar = randomGenerator.Next() % 2 == 0;

            Manufacturer = randomManufacturer;
            NameOfVehicle = randomVehicleName;
            Mileage = randomMileage;
            Value = randomValue;
            SeatCount = randomSeatCount;
            HasSideCar = hasSideCar;

    }

    public override string ToString()
    {
        var advertisementString =
            $"YEEHAW!! We got a {Manufacturer} {NameOfVehicle} with {TypeOfDrive}" + 
            $" with only a mileage of {Mileage} KMs and a value at ${Value}";

        if (HasSideCar)
        {
            advertisementString += $" and side car!!!";
        }

        advertisementString += "!";
        
        return advertisementString;
    }
}