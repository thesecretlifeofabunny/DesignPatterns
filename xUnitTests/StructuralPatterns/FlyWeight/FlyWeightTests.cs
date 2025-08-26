using DesignPatterns.StructuralPatterns.FlyWeight;

namespace xUnitTests.StructuralPatterns.FlyWeight;

/// <summary>
/// Results:
///     560000000 bytes without flyweight
///     vs
///     400000000 bytes with flyweight.
///
/// Conclusion: FlyWeight does help :D, I'm somewhat surprised by this as I thought the dotnet compiler would apply
/// performance tweaks regarding this, although I just did debug checking and not full release build checking nor did
/// I do any hot tests to bake in memory for real world memory usage.
///  
/// Heavily influenced implementation by
/// [1] Geekific, “The Flyweight Pattern Explained and Implemented in Java | Structural Design Patterns |
///     Geekific,” YouTube, Jan. 22, 2022. https://www.youtube.com/watch?v=qscOsQV-K14 (accessed Aug. 26, 2025).‌
/// </summary>
public class FlyWeightTests
{
    [Fact]
    // DesignPatterns.Classes.Game.Game	10000000	com.intellij.xdebugger.memory.ui.ClassesTable$DiffValue@2ce96fbd	560000000
    public void VideoGameStore_SellNewVideoGame_AddsAllTenMillionGamesUsesMoreMemoryThanFlyWeight()
    {
        // Arrange
        const int numberOfGamesToSell = 5_000_000;
        VideoGameStore videoGameStore= new();

        // ACT

        for (var i = 0; i < numberOfGamesToSell; i++)
        {
            videoGameStore.SellNewVideoGame(
                "Meow", 
                29.99, 
                "cat", 
                "dog",
                "Valhalla"
            );
            
            videoGameStore.SellNewVideoGame(
                "Chirp", 
                9.99, 
                "rabbit", 
                "turtle",
                "Mars"
            );
        }

        // Assert
        
        Assert.Equal(numberOfGamesToSell * 2, videoGameStore._sellingGames.Count);
    }
    
    [Fact]
    // DesignPatterns.Classes.Game.GameWithFlyWeightType	10000000	com.intellij.xdebugger.memory.ui.ClassesTable$DiffValue@5922ad04	400000000
    public void VideoGameStore_SellNewVideoGame_AddsAllTenMillionGamesUsesLessMemoryThanNonFlyWeight()
    {
        // Arrange
        const int numberOfGamesToSell = 5_000_000;
        VideoGameStoreFlyWeight videoGameStoreFlyWeight = new();

        // ACT

        for (var i = 0; i < numberOfGamesToSell; i++)
        {
            videoGameStoreFlyWeight.SellNewVideoGame(
                "Meow", 
                29.99, 
                "cat", 
                "dog",
                "Valhalla"
                );
            
            videoGameStoreFlyWeight.SellNewVideoGame(
                "Chirp", 
                9.99, 
                "rabbit", 
                "turtle",
                "Mars"
            );
        }

        // Assert
        
        Assert.Equal(numberOfGamesToSell * 2, videoGameStoreFlyWeight._sellingGames.Count);
    }
}