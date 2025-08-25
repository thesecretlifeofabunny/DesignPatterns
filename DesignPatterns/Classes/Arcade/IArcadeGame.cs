namespace DesignPatterns.Classes.Arcade;

public interface IArcadeGame : IArcade
{
    public bool IsDigital { get; }

    public int CostToPlay { get; }

}