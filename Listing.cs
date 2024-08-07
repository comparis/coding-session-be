namespace Models 
{
    public enum ListingType
    {
        Flat, House
    }
    
    public enum DealType
    {
        Rent, Buy
    }
    
    public enum CoordinateAccuracy
    {
        Exact, Street, City, State, Country
    }
    
    public record Listing(
        ListingType RealestateType,
        DealType DealType,
        string Title,
        int Price,
        float Rooms,
        string city,
        int zipcode,
        Coordinates coordinates
    );
    
    public record Coordinates(
        double Latitude,
        double Longitude,
        CoordinateAccuracy Accuracy
    );
}