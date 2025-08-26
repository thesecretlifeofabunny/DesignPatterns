using DesignPatterns.Classes.Arcade;
using DesignPatterns.StructuralPatterns.Composite;

namespace xUnitTests.StructuralPatterns.Composite;

/// <summary>
/// Implementation influenced by
/// Geekific. “ The Composite Pattern Explained and Implemented in Java | Structural Design Patterns | Geekific .” YouTube, YouTube, 4 Dec. 2021, www.youtube.com/watch?v=oo9AsGqnisk. 
/// </summary>
public class CompositeTests
{
    [Fact]
    public void ArcadeFranchise_CalculateFranchiseeArcadeGameCost_ReturnsZeroFromEmptyFranchisee()
    {
        ArcadeFranchise babiesFirstFranchise = new();

        var costOfFranchise = babiesFirstFranchise.CalculateFranchiseeArcadeGameCost();
        
        Assert.Equal(0, costOfFranchise);
    }
    
    [Fact]
    public void ArcadeFranchise_CalculateFranchiseeArcadeGameCost_ReturnsOneDollarForOneGameOneComposite()
    {
        const int oneDollar = 1;
        ClawMachine clawMachine = new(oneDollar);
        ArcadeFranchise babiesFirstFranchise = new();
        
        babiesFirstFranchise.CreateFranchisee([clawMachine]);
        var costOfFranchise = babiesFirstFranchise.CalculateFranchiseeArcadeGameCost();
        
        Assert.Equal(1, costOfFranchise);
    }
    
    [Fact]
    public void ArcadeFranchise_CalculateFranchiseeArcadeGameCost_ReturnsTwoDollarForTwoGamesOneComposites()
    {
        const int oneDollar = 1;
        ClawMachine clawMachine = new(oneDollar);
        FightingGame fightingGame = new(oneDollar);
        ArcadeFranchise babiesFirstFranchise = new();
        
        babiesFirstFranchise.CreateFranchisee([fightingGame, clawMachine]);
        var costOfFranchise = babiesFirstFranchise.CalculateFranchiseeArcadeGameCost();
        
        Assert.Equal(2, costOfFranchise);
    }
    
    [Fact]
    public void ArcadeFranchise_CalculateFranchiseeArcadeGameCost_ReturnsTFourDollarForFourGamesTwoComposites()
    {
        const int oneDollar = 1;
        ClawMachine clawMachine = new(oneDollar);
        FightingGame fightingGame = new(oneDollar);
        ArcadeFranchise babiesFirstFranchise = new();
        ArcadeComposite compositeOne = new([]);
        ArcadeComposite compositeTwo = new([]);
        
        compositeOne.AddArcadeGamesToComposite([fightingGame, clawMachine]);
        compositeTwo.AddArcadeGamesToComposite([fightingGame, clawMachine]);
        babiesFirstFranchise.CreateFranchisee([compositeOne, compositeTwo]);
        var costOfFranchise = babiesFirstFranchise.CalculateFranchiseeArcadeGameCost();
        
        Assert.Equal(4, costOfFranchise);
    }
    
    [Fact]
    public void ArcadeFranchise_CalculateFranchiseeArcadeGameCost_ReturnsTFiveDollarForFiveGamesTwoComposites()
    {
        const int oneDollar = 1;
        ClawMachine clawMachine = new(oneDollar);
        FightingGame fightingGameOne = new(oneDollar);
        FightingGame fightingGameTwo = new(oneDollar);
        ArcadeFranchise babiesFirstFranchise = new();
        ArcadeComposite compositeOne = new([]);
        ArcadeComposite compositeTwo = new([]);
        
        compositeOne.AddArcadeGamesToComposite([fightingGameOne, clawMachine]);
        compositeTwo.AddArcadeGamesToComposite([fightingGameOne, clawMachine]);
        babiesFirstFranchise.CreateFranchisee([compositeOne, compositeTwo, fightingGameTwo]);
        var costOfFranchise = babiesFirstFranchise.CalculateFranchiseeArcadeGameCost();
        
        Assert.Equal(5, costOfFranchise);
    }
}