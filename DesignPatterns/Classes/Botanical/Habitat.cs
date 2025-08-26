namespace DesignPatterns.Classes.Botanical;

public class Habitat(string nameOfHabitat, bool hasRainedWithinAWeek)
{
    public string NameOfHabitat { get; } = nameOfHabitat;
    public bool HasRainedWithinAWeek { get; } = hasRainedWithinAWeek;
}