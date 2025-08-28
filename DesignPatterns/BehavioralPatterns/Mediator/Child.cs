namespace DesignPatterns.BehavioralPatterns.Mediator;

/// <summary>
/// Learnt from
/// [1]Derek Banas, “Mediator Design Pattern,” YouTube, Oct. 29, 2012.
/// https://www.youtube.com/watch?v=8DxIpdKd41A (accessed Aug. 28, 2025).
/// </summary>
public class Child(string nameOfChild, ChildrensToyTradeMediator childrenToyTradeMediator, List<ChildrensToy>? ownedToys = null)
{
    public ChildrensToyTradeMediator ChildrenToyTradeMediator { get; } = childrenToyTradeMediator;
    public string NameOfChild { get; } = nameOfChild;
    public List<ChildrensToy>? OwnedToys { get; set; } = ownedToys;

    public void AddToyToOwnedToys(ChildrensToy toyToAdd)
    {
        OwnedToys ??= [];
        OwnedToys.Add(toyToAdd);
    }

    public void OfferToy(ChildrensToy toyToOffer)
    {
        ChildrenToyTradeMediator.OfferToy(this, toyToOffer);
    }

    public void AcceptToyOffer(ChildrensToy toyToAccept)
    {
        ChildrenToyTradeMediator.OfferToy(this, toyToAccept);
    }
}