namespace DesignPatterns.Classes.Vehicle;

public class Motorcycle(
    string manufacturer,
    string nameOfVehicle,
    DriveType typeOfDrive,
    int mileage,
    double value,
    int seatCount,
    bool hasSideCar)
    : IVehicle
{
    public string Manufacturer { get; set; } = manufacturer;

    public string NameOfVehicle { get; set; } = nameOfVehicle;

    public int NumberOfWheels { get; set; } = 2;

    public DriveType TypeOfDrive { get; set; } = typeOfDrive;

    public int Mileage { get; set; } = mileage;

    public double Value { get; set; } = value;

    public int SeatCount { get; set; } = seatCount;

    private bool HasSideCar { get; } = hasSideCar;

    public IVehicle GetRandomizedVehicle()
    {
        throw new NotImplementedException();
    }

    public override string? ToString()
    {
        var advertisementString =
            $"YEEHAW!! We got a {Manufacturer} {NameOfVehicle} with {TypeOfDrive}" + 
            $"with only a mileage of {Mileage} KMs and a value at ${Value}";

        if (HasSideCar)
        {
            advertisementString += $"and side car!!!";
        }

        advertisementString += "!";
        
        Console.WriteLine(advertisementString);
        return null;
    }
}