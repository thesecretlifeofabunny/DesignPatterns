namespace DesignPatterns.BehavioralPatterns.State;

public class Phone()
{
    public IPhoneState? State { get; set; }
    public bool IsPhoneOn { get; set; }
    public bool IsPhoneLocked { get; set; } = true;
}