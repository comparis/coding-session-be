public class ListingGenerator
{
    private static readonly Random _random = new Random();

    public static Listing GenerateListing(int index)
    {
        ListingType listingType = _random.NextSingle() < 0.8 ? ListingType.Flat : ListingType.House;
        DealType dealType = _random.NextSingle() < 0.5 ? DealType.Buy : DealType.Rent;
        string title = "Title " + index;
        int basePrice = (int)_random.NextInt64(8, 60) * 100;
        int price = dealType == DealType.Buy ? basePrice * 100 : basePrice;
        float rooms = _random.NextInt64(2, 12) / 2.0f;
        return new Listing(listingType, dealType, title, price, rooms);
    }
}