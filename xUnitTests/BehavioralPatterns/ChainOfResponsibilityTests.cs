using DesignPatterns.BehavioralPatterns.ChainOfResponsibility;

namespace xUnitTests.BehavioralPatterns;

/// <summary>
/// Implementation Idea modified version of
/// [1] Derek Banas, “Chain of Responsibility Design Pattern,”
/// YouTube, Oct. 20, 2012. https://www.youtube.com/watch?v=jDX6x8qmjbA‌
/// </summary>
public class ChainOfResponsibilityTests
{
    private const string BarkYapCommand = "bark";
    private const string MeowYapCommand = "meow";
    private const string HissYapCommand = "hiss";
    private const string CluckYapCommand = "cluck";

    private const string BarkYap = "Bark yap";
    private const string MeowYap = "Meow yap";
    private const string HissYap = "Hiss yap";
    private const string CluckYap = "Cluck yap";

    [Fact]
    public void IChainOfYaps_Yap_ReturnsEmptyStringWithEmptyString()
    {
        // Arrange
        Bark barkYap = new();
        Meow meowYap = new();
        Hiss hissYap = new();
        Cluck cluckYap = new();
        barkYap.SetNextChain(meowYap);
        meowYap.SetNextChain(hissYap);
        hissYap.SetNextChain(cluckYap);

        // Act
        var yapReturned = barkYap.Yap(string.Empty);

        // Assert
        Assert.Equal(string.Empty, yapReturned);
    }

    [Fact]
    public void IChainOfYaps_Yap_ReturnsBarkYapWithBarkCommand()
    {
        Bark barkYap = new();
        Meow meowYap = new();
        Hiss hissYap = new();
        Cluck cluckYap = new();
        barkYap.SetNextChain(meowYap);
        meowYap.SetNextChain(hissYap);
        hissYap.SetNextChain(cluckYap);

        var yapReturned = barkYap.Yap(BarkYapCommand);

        Assert.Equal(BarkYap, yapReturned);
    }

    [Fact]
    public void IChainOfYaps_Yap_ReturnsMeowYapWithMeowCommand()
    {
        Bark barkYap = new();
        Meow meowYap = new();
        Hiss hissYap = new();
        Cluck cluckYap = new();
        barkYap.SetNextChain(meowYap);
        meowYap.SetNextChain(hissYap);
        hissYap.SetNextChain(cluckYap);

        var yapReturned = barkYap.Yap(MeowYapCommand);

        Assert.Equal(MeowYap, yapReturned);
    }

    [Fact]
    public void IChainOfYaps_Yap_ReturnsHissYapWithHissCommand()
    {
        Bark barkYap = new();
        Meow meowYap = new();
        Hiss hissYap = new();
        Cluck cluckYap = new();
        barkYap.SetNextChain(meowYap);
        meowYap.SetNextChain(hissYap);
        hissYap.SetNextChain(cluckYap);

        var yapReturned = barkYap.Yap(HissYapCommand);

        Assert.Equal(HissYap, yapReturned);
    }

    [Fact]
    public void IChainOfYaps_Yap_ReturnsCluckYapWithCluckCommand()
    {
        Bark barkYap = new();
        Meow meowYap = new();
        Hiss hissYap = new();
        Cluck cluckYap = new();
        barkYap.SetNextChain(meowYap);
        meowYap.SetNextChain(hissYap);
        hissYap.SetNextChain(cluckYap);

        var yapReturned = barkYap.Yap(CluckYapCommand);

        Assert.Equal(CluckYap, yapReturned);
    }
}