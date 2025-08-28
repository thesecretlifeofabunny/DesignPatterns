namespace DesignPatterns.BehavioralPatterns.Mediator;

public interface IChildrensToyTradeMediator
{
    public void OfferToy(Child childThatIsOfferingToy, ChildrensToy toyToOffer);

    public void AcceptToyOffer(Child childThatIsAcceptingToyOffer, ChildrensToy toyToAccept);
}