namespace Api
{
    using Microsoft.AspNetCore.Mvc;
    using Models;
    using Persistence;

    [ApiController]
    [Route("[controller]")]
    public class ListingController : ControllerBase
    {
        private readonly ILogger<ListingController> _logger;
        private readonly Random _random = new Random();
        private readonly ListingDataSource _listingDataSource;
    
        public ListingController(ILogger<ListingController> logger, ListingDataSource? listingDataSource = null)
        {
            _logger = logger;
            _listingDataSource = listingDataSource ?? new ListingDataSource();
        }
    
        [HttpGet]
        public IEnumerable<Listing> Get() => _listingDataSource.GetListings(50);
    }
}