namespace DesignPatterns.BehavioralPatterns.State;

public class OffState(Phone phoneOfState) : IPhoneState
{
    public Phone Phone { get; set; } = phoneOfState;

    public void PressPowerButton()
    {
        Phone.IsPhoneOn = true;
        Phone.IsPhoneLocked = true;
        Phone.State = new LockedState(Phone);
    }

    // I know I should either create a new interface for this but im tired and that's not the point of this 
    // learning moment
    public void PressHomeButton() => Phone.IsPhoneOn = true;
    public void UnlockPhone()
    {
        throw new NotImplementedException();
    }
}