namespace DesignPatterns.Classes.Vehicle;

public class Motorcycle(
    string manufacturer,
    string nameOfVehicle,
    int numberOfWheels,
    DriveType typeOfDrive,
    int mileage,
    double value,
    int seatCount,
    bool hasSideCar)
    : IVehicle
{
    public string Manufacturer { get; set; } = manufacturer;

    public string NameOfVehicle { get; set; } = nameOfVehicle;

    public int NumberOfWheels { get; set; } = numberOfWheels;

    public DriveType TypeOfDrive { get; set; } = typeOfDrive;

    public int Mileage { get; set; } = mileage;

    public double Value { get; set; } = value;

    public int SeatCount { get; set; } = seatCount;

    public bool HasSideCar { get; set; } = hasSideCar;
}