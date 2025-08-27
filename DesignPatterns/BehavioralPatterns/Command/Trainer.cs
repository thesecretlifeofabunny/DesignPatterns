namespace DesignPatterns.BehavioralPatterns.Command;

/// <summary>
/// Heavily influenced implementation from
/// [1] Derek Banas, “Command Design Pattern,” YouTube,
/// Sep. 24, 2012. https://www.youtube.com/watch?v=7Pj5kAhVBlg (accessed Aug. 27, 2025).‌
/// </summary>
public class Trainer(ICommand command)
{
    private ICommand Command { get; } = command;

    public string TrainCommand()
    {
        return Command.Execute();
    }
}