namespace DesignPatterns.BehavioralPatterns.State;

public class LockedState(Phone phoneOfState) : IPhoneState
{
    public Phone Phone { get; set; } = phoneOfState;

    public void PressPowerButton()
    {
        Phone.IsPhoneOn = false;
        Phone.State = new OffState(Phone);
    }

    public void PressHomeButton() => Phone.IsPhoneOn = true;

    public void UnlockPhone()
    {
        Phone.IsPhoneLocked = false;
        Phone.State = new UnlockedState(Phone);
    }
}