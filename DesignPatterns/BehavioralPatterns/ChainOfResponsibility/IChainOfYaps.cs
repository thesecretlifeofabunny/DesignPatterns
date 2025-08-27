namespace DesignPatterns.BehavioralPatterns.ChainOfResponsibility;

/// <summary>
/// Implementation Idea modified version of
/// [1] Derek Banas, “Chain of Responsibility Design Pattern,”
/// YouTube, Oct. 20, 2012. https://www.youtube.com/watch?v=jDX6x8qmjbA‌
/// </summary>
public interface IChainOfYaps
{
    public void SetNextChain(IChainOfYaps chainOfYaps);

    public string Yap(string yapCommand);
}