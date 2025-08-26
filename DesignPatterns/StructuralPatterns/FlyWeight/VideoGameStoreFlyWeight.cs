using DesignPatterns.Classes.Game;

namespace DesignPatterns.StructuralPatterns.FlyWeight;

/// <summary>
/// Heavily influenced implementation by
/// [1] Geekific, “The Flyweight Pattern Explained and Implemented in Java | Structural Design Patterns |
///     Geekific,” YouTube, Jan. 22, 2022. https://www.youtube.com/watch?v=qscOsQV-K14 (accessed Aug. 26, 2025).‌
/// </summary>
public class VideoGameStoreFlyWeight
{
    public readonly List<GameWithFlyWeightType> _sellingGames = [];

    public void SellNewVideoGame(string name, double price, string genreOfGame, string producerName,
        string distributorName)
    {
        _sellingGames.Add(new GameWithFlyWeightType(
            name,
            price,
            GameSupplementalInformationFlyweightFactory.GetGameSupplementalInformation(
                genreOfGame,
                producerName,
                distributorName
                )
            ));
    }
}