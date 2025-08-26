namespace DesignPatterns.Classes.Arcade;

/// <summary>
/// Implementation influenced by
/// Geekific. “ The Composite Pattern Explained and Implemented in Java | Structural Design Patterns | Geekific .” YouTube, YouTube, 4 Dec. 2021, www.youtube.com/watch?v=oo9AsGqnisk. 
/// </summary>
public class FightingGame(int costToPlay) : IArcadeGame
{
    public bool IsDigital { get; } = true;
    public int CostToPlay { get; } = costToPlay;

    public int CalculatePrice() => CostToPlay;
}