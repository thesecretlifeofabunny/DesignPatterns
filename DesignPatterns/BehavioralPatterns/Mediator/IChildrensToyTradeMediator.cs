namespace DesignPatterns.BehavioralPatterns.Mediator;

/// <summary>
/// Learnt from
/// [1]Derek Banas, “Mediator Design Pattern,” YouTube, Oct. 29, 2012.
/// https://www.youtube.com/watch?v=8DxIpdKd41A (accessed Aug. 28, 2025).
/// </summary>
public interface IChildrensToyTradeMediator
{
    public void OfferToy(Child childThatIsOfferingToy, ChildrensToy toyToOffer);

    public void AcceptToyOffer(Child childThatIsAcceptingToyOffer, ChildrensToy toyToAccept);
}