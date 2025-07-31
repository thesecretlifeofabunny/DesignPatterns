namespace DesignPatterns.Classes.Vehicle;

public interface IVehicle
{
    public string Manufacturer { get; set; }
    
    public string NameOfVehicle { get; set; }
    
    public int NumberOfWheels { get; set; }
    
    public DriveType TypeOfDrive { get; set; }
    
    public int Mileage { get; set; }
    
    public double Value { get; set; }

    public int SeatCount { get; set; }
    
    public string? ToString();

    public IVehicle GetRandomizedVehicle();
}