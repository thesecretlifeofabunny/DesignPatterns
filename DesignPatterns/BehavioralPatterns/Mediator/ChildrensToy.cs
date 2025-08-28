namespace DesignPatterns.BehavioralPatterns.Mediator;

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