namespace DesignPatterns.BehavioralPatterns.Command;

/// <summary>
/// Heavily influenced implementation from
/// [1] Derek Banas, “Command Design Pattern,” YouTube,
/// Sep. 24, 2012. https://www.youtube.com/watch?v=7Pj5kAhVBlg (accessed Aug. 27, 2025).‌
/// </summary>
public class TellDogToSit(IPet theDog) : ICommand
{
    private IPet TheDog { get; init; } = theDog;

    public string Execute()
    {
        return TheDog.Sit();
    }
}