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
    bool foldableSeat)
{
    public string Manufacturer { get; set; } = manufacturer;

    public string NameOfVehicle { get; set; } = nameOfVehicle;

    public int NumberOfWheels { get; set; } = numberOfWheels;

    public DriveType TypeOfDrive { get; set; } = typeOfDrive;

    public int Mileage { get; set; } = mileage;

    public double Value { get; set; } = value;

    public int SeatCount { get; set; } = seatCount;

    public double StorageCapacity { get; set; } = storageCapacity;

    public bool FoldableSeat { get; set; } = foldableSeat;
}