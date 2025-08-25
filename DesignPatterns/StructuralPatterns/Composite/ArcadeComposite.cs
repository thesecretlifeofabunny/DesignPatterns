using DesignPatterns.Classes.Arcade;

namespace DesignPatterns.StructuralPatterns.Composite;

public class ArcadeComposite(List<IArcade> allArcadeGames) : IArcade
{
    private List<IArcade> AllArcadeGames { get; } = allArcadeGames;

    public void AddArcadeGamesToComposite(List<IArcade> listOfGamesToAdd)
    {
        foreach (var game in from gameToCheck 
                     in listOfGamesToAdd 
                 where !AllArcadeGames.Contains(gameToCheck) 
                     select gameToCheck) AllArcadeGames.Add(game);
    }

    public int CalculatePrice() => AllArcadeGames.Select(game =>  game.CalculatePrice()).Sum();
    
}