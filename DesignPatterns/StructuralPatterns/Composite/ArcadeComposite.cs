using DesignPatterns.Classes.Arcade;

namespace DesignPatterns.StructuralPatterns.Composite;

/// <summary>
/// Implementation influenced by
/// Geekific. “ The Composite Pattern Explained and Implemented in Java | Structural Design Patterns | Geekific .” YouTube, YouTube, 4 Dec. 2021, www.youtube.com/watch?v=oo9AsGqnisk. 
/// </summary>
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