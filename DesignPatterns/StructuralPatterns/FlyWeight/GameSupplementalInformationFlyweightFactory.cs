using System.Diagnostics;
using DesignPatterns.Classes.Game;

namespace DesignPatterns.StructuralPatterns.FlyWeight;

/// <summary>
/// Heavily influenced implementation by
/// [1] Geekific, “The Flyweight Pattern Explained and Implemented in Java | Structural Design Patterns |
///     Geekific,” YouTube, Jan. 22, 2022. https://www.youtube.com/watch?v=qscOsQV-K14 (accessed Aug. 26, 2025).‌
/// </summary>
public static class GameSupplementalInformationFlyweightFactory
{
    private static readonly Dictionary<string, GameSupplementalInformation> GameInformationDictionary = new();

    public static GameSupplementalInformation GetGameSupplementalInformation(
        string genreOfGame, string producerName, string distributorName)
    {
        if (!GameInformationDictionary.ContainsKey(genreOfGame))
        {
            GameInformationDictionary.Add(genreOfGame,
                new GameSupplementalInformation(
                    genreOfGame,
                    producerName,
                    distributorName
                    ));
        }

        GameInformationDictionary.TryGetValue(genreOfGame, out var gameSupplementalInformation);
        Debug.Assert(gameSupplementalInformation is not null,
            nameof(gameSupplementalInformation) + " is not null");
        return gameSupplementalInformation;
    }
}