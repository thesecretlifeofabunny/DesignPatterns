namespace DesignPatterns.Classes.Game;

/// <summary>
/// Heavily influenced implementation by
/// [1] Geekific, “The Flyweight Pattern Explained and Implemented in Java | Structural Design Patterns |
///     Geekific,” YouTube, Jan. 22, 2022. https://www.youtube.com/watch?v=qscOsQV-K14 (accessed Aug. 26, 2025).‌
/// </summary>
public class GameSupplementalInformation(string genreOfGame, string producerName, string distributorName)
{
    public string GenreOfGame { get; init; } = genreOfGame;
    public string ProducerName { get; init; } = producerName;
    public string DistributorName { get; init; } = distributorName;
}