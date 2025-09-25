namespace DesignPatterns.BehavioralPatterns.State;

public class UnlockedState(Phone phoneOfState) : IPhoneState
{
    public Phone Phone { get; set; } = phoneOfState;

    public void PressPowerButton()
    {
        Phone.IsPhoneOn = false;
        Phone.IsPhoneLocked = true;
        Phone.State = new OffState(Phone);
    }

    public void PressHomeButton() => Phone.IsPhoneOn = true;

    // I know I should either create a new interface for this but im tired and that's not the point of this 
    // learning moment
    public void UnlockPhone()
    {
        throw new NotImplementedException();
    }
}