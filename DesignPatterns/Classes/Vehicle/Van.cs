namespace DesignPatterns.Classes.Vehicle;

public class Van(
    string manufacturer,
    string nameOfVehicle,
    int numberOfWheels,
    DriveType typeOfDrive,
    int mileage,
    double value,
    int seatCount,
    double storageCapacity,
    bool foldableSeat) : IVehicle
{
    public string Manufacturer { get; set; } = manufacturer;

    public string NameOfVehicle { get; set; } = nameOfVehicle;

    public int NumberOfWheels { get; set; } = numberOfWheels;

    public DriveType TypeOfDrive { get; set; } = typeOfDrive;

    public int Mileage { get; set; } = mileage;

    public double Value { get; set; } = value;

    public int SeatCount { get; set; } = seatCount;

    private double StorageCapacity { get; set; } = storageCapacity;

    private bool FoldableSeat { get; set; } = foldableSeat;
    
    public IVehicle GetRandomizedVehicle()
    {
        throw new NotImplementedException();
    }

    public override string? ToString()
    {
        var advertisementString =
            $"YEEHAW!! We got a {Manufacturer} {NameOfVehicle} with {TypeOfDrive}" + 
            $"with only a mileage of {Mileage} KMs and a value at ${Value}!" +
            $"Also not to mention the storage capacity of {StorageCapacity}inches squared.";

        if (FoldableSeat)
        {
            advertisementString += "This also comes with a row of foldable seats!";
        }
        
        Console.WriteLine(advertisementString);
        return null;
    }
}