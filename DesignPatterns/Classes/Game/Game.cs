namespace DesignPatterns.Classes.Game;

public class Game(string name, double price, string genreOfGame, string producerName, string distributorName)
{
    private string Name { get; init; } = name;
    private double Price { get; init; } = price;
    public string GenreOfGame { get; init; } = genreOfGame;
    public string ProducerName { get; init; } = producerName;
    public string DistributorName { get; init; } = distributorName;
}