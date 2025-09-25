using DesignPatterns.BehavioralPatterns.State;

namespace xUnitTests.BehavioralPatterns;
/*
 * Implementation from the following
 * [1] Geekific, “The State Pattern Explained and Implemented in Java | Behavioral Design Patterns |
 * Geekific,” YouTube, Sep. 11, 2021. https://www.youtube.com/watch?v=abX4xzaAsoc (accessed Sep. 25, 2025). ‌
 
 * implemented in c# to cement at least an implementation. Concept is fairly simple though. I'm just not creative when
 * im eepy >.>
 */
public class StateTests
{
    [Fact]
    public void Phone_IsPhoneOn_PhoneShouldBeOffByDefault()
    {
        // Arrange
        Phone myCoolPhone = new();
        OffState phoneState = new(myCoolPhone);
        myCoolPhone.State = phoneState;

        // Act

        // Assert
        Assert.False(myCoolPhone.IsPhoneOn);
        Assert.IsType<OffState>(myCoolPhone.State);
    }

    [Fact]
    public void Phone_IsPhoneLocked_PhoneShouldBeLockedByDefault()
    {
        // Arrange
        Phone myCoolPhone = new();
        OffState phoneState = new(myCoolPhone);
        myCoolPhone.State = phoneState;

        // Act

        // Assert
        Assert.True(myCoolPhone.IsPhoneLocked);
    }

    [Fact]
    public void Phone_PressPowerButton_PhoneShouldBeLockedAndOn()
    {
        // Arrange
        Phone myCoolPhone = new();
        OffState phoneState = new(myCoolPhone);
        myCoolPhone.State = phoneState;

        // Act
        myCoolPhone.State.PressPowerButton();

        // Assert
        Assert.True(myCoolPhone.IsPhoneLocked);
        Assert.True(myCoolPhone.IsPhoneOn);
        Assert.IsType<LockedState>(myCoolPhone.State);
    }

    [Fact]
    public void Phone_UnlockPhoneInLockedState_PhoneShouldBeUnlockedAndOn()
    {
        // Arrange
        Phone myCoolPhone = new();
        OffState phoneState = new(myCoolPhone);
        myCoolPhone.State = phoneState;

        // Act
        myCoolPhone.State.PressPowerButton();
        myCoolPhone.State.UnlockPhone();

        // Assert
        Assert.False(myCoolPhone.IsPhoneLocked);
        Assert.True(myCoolPhone.IsPhoneOn);
        Assert.IsType<UnlockedState>(myCoolPhone.State);
    }

    [Fact]
    public void Phone_HomeButtonInUnlockedState_PhoneShouldStayOnAndUnlocked()
    {
        // Arrange
        Phone myCoolPhone = new();
        OffState phoneState = new(myCoolPhone);
        myCoolPhone.State = phoneState;

        // Act
        myCoolPhone.State.PressPowerButton();
        myCoolPhone.State.UnlockPhone();
        myCoolPhone.State.PressHomeButton();

        // Assert
        Assert.False(myCoolPhone.IsPhoneLocked);
        Assert.True(myCoolPhone.IsPhoneOn);
        Assert.IsType<UnlockedState>(myCoolPhone.State);
    }

    [Fact]
    public void Phone_PowerButtonInUnlockedState_PhoneShouldBeLockedAndOff()
    {
        // Arrange
        Phone myCoolPhone = new();
        OffState phoneState = new(myCoolPhone);
        myCoolPhone.State = phoneState;

        // Act
        myCoolPhone.State.PressPowerButton();
        myCoolPhone.State.UnlockPhone();
        myCoolPhone.State.PressPowerButton();

        // Assert
        Assert.True(myCoolPhone.IsPhoneLocked);
        Assert.False(myCoolPhone.IsPhoneOn);
        Assert.IsType<OffState>(myCoolPhone.State);
    }
}