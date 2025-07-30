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
    public string Manufacturer { get; set; } = manufacturer;

    public string NameOfVehicle { get; set; } = nameOfVehicle;

    public int NumberOfWheels { get; set; } = numberOfWheels;

    public DriveType TypeOfDrive { get; set; } = typeOfDrive;

    public int Mileage { get; set; } = mileage;

    public double Value { get; set; } = value;

    public int SeatCount { get; set; } = seatCount;

    public double TruckBedSize { get; set; } = truckBedSize;

    public double TowWeightCapacity { get; set; } = towWeightCapacity;
}