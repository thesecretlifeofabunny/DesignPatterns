namespace DesignPatterns.Classes.Game;

/// <summary>
/// Heavily influenced implementation by
/// [1] Geekific, “The Flyweight Pattern Explained and Implemented in Java | Structural Design Patterns |
///     Geekific,” YouTube, Jan. 22, 2022. https://www.youtube.com/watch?v=qscOsQV-K14 (accessed Aug. 26, 2025).‌
/// </summary>
public class GameWithFlyWeightType(string name, double price, GameSupplementalInformation gameSupplementalInformation)
{
    private string Name { get; init; } = name;
    private double Price { get; init; } = price;
    private GameSupplementalInformation GameSupplementalInformation { get; init; } = gameSupplementalInformation;
}