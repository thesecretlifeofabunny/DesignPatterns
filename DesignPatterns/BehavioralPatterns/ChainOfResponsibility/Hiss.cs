namespace DesignPatterns.BehavioralPatterns.ChainOfResponsibility;

/// <summary>
/// Implementation Idea modified version of
/// [1] Derek Banas, “Chain of Responsibility Design Pattern,”
/// YouTube, Oct. 20, 2012. https://www.youtube.com/watch?v=jDX6x8qmjbA‌
/// </summary>
public class Hiss : IChainOfYaps
{
    private IChainOfYaps? NextInYap { get; set; }

    private const string MyYapCommand = "hiss";
    private const string MyYap = "Hiss yap";

    public void SetNextChain(IChainOfYaps chainOfYaps)
    {
        NextInYap = chainOfYaps;
    }

    public string Yap(string yapCommand)
    {
        if (!string.Equals(MyYapCommand, yapCommand))
            return NextInYap is not null ? NextInYap.Yap(yapCommand) : string.Empty;
        
        Console.WriteLine(MyYap);
        return MyYap;
    }
}