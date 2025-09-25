namespace DesignPatterns.BehavioralPatterns.State;

public interface IPhoneState
{
    protected Phone Phone { get; set; }

    public abstract void PressPowerButton();
    public abstract void PressHomeButton();

    // I know I should either create a new interface for this but im tired and that's not the point of this 
    // learning moment
    public abstract void UnlockPhone();
}