namespace DesignPatterns.Classes.Appliances;

public class Dishwasher : IDishwasher
{
    public static string PutTheDishesIn()
    {
        const string outputMessage = "Putting the clothes in...";
        Console.WriteLine("Putting the clothes in...");
        return outputMessage;
    }

    public static string StartTheDishwasher()
    {
        const string outputMessage = "Starting the dishwasher...";
        Console.WriteLine("Starting the dishwasher...");
        return outputMessage;
    }

    public static string TakeTheDishesOut()
    {
        const string outputMessage = "Taking the dishes out";
        Console.WriteLine("Taking the dishes out");
        return outputMessage;
   } 
}