namespace DesignPatterns.BehavioralPatterns.Mediator;

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