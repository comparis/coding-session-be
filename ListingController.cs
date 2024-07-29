using Microsoft.AspNetCore.Mvc;


[ApiController]
[Route("[controller]")]
public class ListingController : ControllerBase
{
    private readonly ILogger<ListingController> _logger;
    private readonly Random _random = new Random();

    public ListingController(ILogger<ListingController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<Listing> Get()
    {
        return Enumerable.Range(1, 50)
            .Select(index => ListingGenerator.GenerateListing(index))
            .ToArray();
    }
}
