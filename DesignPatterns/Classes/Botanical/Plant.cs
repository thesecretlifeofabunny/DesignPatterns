namespace DesignPatterns.Classes.Botanical;

public class Plant (string nameOfPlant, bool hasBeenWateredWithinAWeek, Habitat whereItIsPlanted)
{
    public string NameOfPlant { get; } = nameOfPlant;
    public bool HasBeenWateredWithinAWeek { get; set; } = hasBeenWateredWithinAWeek;
    public Habitat WhereItIsPlanted { get; } = whereItIsPlanted;
}