namespace DesignPatterns.Classes.Arcade;

public class ClawMachine(int costToPlay) : IArcadeGame
{
    public bool IsDigital { get; } = false;
    public int CostToPlay { get; } = costToPlay;

    public int CalculatePrice() => CostToPlay;
}