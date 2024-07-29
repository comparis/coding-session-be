public class ListingGenerator
{
    private static readonly Random _random = new Random();

    private static readonly List<(int, string)> _cities = new List<(int, string)>
    {
        (8000, "Zurich"),
        (8003, "Zurich"),
        (8004, "Zurich"),
        (8005, "Zurich"),
        (8037, "Zurich"),
        (8038, "Zurich"),
        (8000, "Zurich"),
        (7000, "Chur"),
        (4000, "Basel"),
        (3000, "Bern"),
        (1000, "Lausanne"),
        (1200, "Geneva"),
        (6000, "Luzern"),
        (8000, "St. Gallen"),
        (6900, "Lugano")
    };

    public static Listing GenerateListing(int index)
    {
        ListingType listingType = _random.NextSingle() < 0.8 ? ListingType.Flat : ListingType.House;
        DealType dealType = _random.NextSingle() < 0.5 ? DealType.Buy : DealType.Rent;
        string title = "Title " + index;
        int basePrice = _random.Next(8, 60) * 100;
        int price = dealType == DealType.Buy ? basePrice * 100 : basePrice;
        float rooms = _random.Next(2, 12) / 2.0f;

        var randomCity = _cities[_random.Next(_cities.Count)];
        int zipcode = randomCity.Item1;
        string city = randomCity.Item2;

        return new Listing(listingType, dealType, title, price, rooms, city, zipcode);
    }
}