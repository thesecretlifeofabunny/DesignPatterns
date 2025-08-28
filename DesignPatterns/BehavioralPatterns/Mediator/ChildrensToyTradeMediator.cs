namespace DesignPatterns.BehavioralPatterns.Mediator;

/// <summary>
/// Learnt from
/// [1]Derek Banas, “Mediator Design Pattern,” YouTube, Oct. 29, 2012.
/// https://www.youtube.com/watch?v=8DxIpdKd41A (accessed Aug. 28, 2025).
/// </summary>
public class ChildrensToyTradeMediator : IChildrensToyTradeMediator
{
    private List<(Child, ChildrensToy)> ListOfCurrentToyOffers { get; } = [];
    public void OfferToy(Child childThatIsOfferingToy, ChildrensToy toyToOffer)
    {
        var childOfferingAToyPotentialListing = (childThatIsOfferingToy, toyToOffer);
        if (ListOfCurrentToyOffers.Contains(childOfferingAToyPotentialListing)) return;
        ListOfCurrentToyOffers.Add(childOfferingAToyPotentialListing);
    }

    public void AcceptToyOffer(Child childThatIsAcceptingToyOffer, ChildrensToy toyToAccept)
    {
        var offeringToAccept =
            ListOfCurrentToyOffers.Find(listedOffer => listedOffer.Item2.Equals(toyToAccept));

        if (offeringToAccept == default) return;

        ListOfCurrentToyOffers.Remove(offeringToAccept);
        childThatIsAcceptingToyOffer.OwnedToys?.Add(offeringToAccept.Item2);
    }
}