namespace DesignPatterns.BehavioralPatterns.Mediator;

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