namespace DesignPatterns.Classes.Arcade;

public class FightingGame(int costToPlay) : IArcadeGame
{
    public bool IsDigital { get; } = true;
    public int CostToPlay { get; } = costToPlay;

    public int CalculatePrice() => CostToPlay;
}