namespace DesignPatterns.Classes.Appliances;

public class ClothesWasher
{
    public string PutTheClothesIn()
    {
        const string outputMessage = "Putting the clothes in...";
        Console.WriteLine("Putting the clothes in...");
        return outputMessage;
    }

    public string TurnTheClothesWasherOn()
    {
        const string outputMessage = "Turning the clothes washer on...";
        Console.WriteLine(outputMessage);
        return outputMessage;
    }

    public string TakeTheClothesOut()
    {
        const string outputMessage = "Taking the clothes out...";
        Console.WriteLine("Taking the clothes out...");
        return outputMessage;
    }
}