
public enum ListingType
{
    Flat, House
}
public enum DealType
{
    Rent, Buy
}
public record Listing(
    ListingType RealestateType,
    DealType DealType,
    string Title,
    int Price,
    float Rooms,
    string city,
    int zipcode
);
