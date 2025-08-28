using DesignPatterns.BehavioralPatterns.Command;

namespace xUnitTests.BehavioralPatterns.Command;

/// <summary>
/// Heavily influenced implementation from
/// [1] Derek Banas, “Command Design Pattern,” YouTube,
/// Sep. 24, 2012. https://www.youtube.com/watch?v=7Pj5kAhVBlg (accessed Aug. 27, 2025).‌
/// </summary>
public class CommandTests
{
    private const string SpeakOutput = "Bark";
    private const string SitOutput = "I Sit";
    private const string SpinOutput = "I Spin";
    private const string GoDoItOutput = "I Pee";

    [Fact]
    public void ICommand_TrainCommand_SpeakCommandGivesSpeakOutput()
    {
        // Arrange
        IPet doggyDogWhatNow = new DogPet();
        TellDogToSpeak commandToSpeak = new(doggyDogWhatNow);
        Trainer trainerOfDog = new(commandToSpeak);

        // Act
        var commandOutput = trainerOfDog.TrainCommand();

        // Assert
        Assert.Equal(SpeakOutput, commandOutput);
    }

    [Fact]
    public void ICommand_TrainCommand_SitCommandGivesSitOutput()
    {
        // Arrange
        IPet doggyDogWhatNow = new DogPet();
        TellDogToSit commandToSit = new(doggyDogWhatNow);
        Trainer trainerOfDog = new(commandToSit);

        // Act
        var commandOutput = trainerOfDog.TrainCommand();

        // Assert
        Assert.Equal(SitOutput, commandOutput);
    }

    [Fact]
    public void ICommand_TrainCommand_SpinCommandGivesSpinOutput()
    {
        // Arrange
        IPet doggyDogWhatNow = new DogPet();
        TellDogToSpin commandToSpin = new(doggyDogWhatNow);
        Trainer trainerOfDog = new(commandToSpin);

        // Act
        var commandOutput = trainerOfDog.TrainCommand();

        // Assert
        Assert.Equal(SpinOutput, commandOutput);
    }

    [Fact]
    public void ICommand_TrainCommand_GoDoItCommandGivesGoDoItOutput()
    {
        // Arrange
        IPet doggyDogWhatNow = new DogPet();
        TellDogToGoDoIt commandToGoDoIt = new(doggyDogWhatNow);
        Trainer trainerOfDog = new(commandToGoDoIt);

        // Act
        var commandOutput = trainerOfDog.TrainCommand();

        // Assert
        Assert.Equal(GoDoItOutput, commandOutput);
    }

}