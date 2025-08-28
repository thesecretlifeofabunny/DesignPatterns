namespace DesignPatterns.BehavioralPatterns.Mediator;

/// <summary>
/// Learnt from
/// [1]Derek Banas, “Mediator Design Pattern,” YouTube, Oct. 29, 2012.
/// https://www.youtube.com/watch?v=8DxIpdKd41A (accessed Aug. 28, 2025).
/// </summary>
public class ChildrensToy( string toyName)
{
    private string ToyName { get; } = toyName;
    
    private bool Equals(ChildrensToy other)
    {
        return ToyName == other.ToyName;
    }

    public override bool Equals(object? obj)
    {
        if (obj is null) return false;
        if (ReferenceEquals(this, obj)) return true;
        return obj.GetType() == GetType() && Equals((ChildrensToy)obj);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(ToyName);
    }
}