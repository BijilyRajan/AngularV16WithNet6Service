using LocationServices.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LocationServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Location>> Get()
        {
            var locations = GetHousingLocations();
            return Ok(locations);
        }


        [HttpGet("{id}")]
        public ActionResult<Location> GetLocationById(int id)
        {
            var location = GetHousingLocations().FirstOrDefault(x => x.Id == id);

            if (location == null)
            {
                return NotFound(); // Returns a 404 Not Found result
            }

            return location;
        }

        private IEnumerable<Location> GetHousingLocations()
        {
            return new List<Location>()
            {
                new Location
                {
                    Id = 0,
                    Name = "Acme Fresh Start Housing",
                    City = "Chicago",
                    State = "IL",
                    Photo = "https:/angular.dev/assets/tutorials/common/bernard-hermant-CLKGGwIBTaY-unsplash.jpg",
                    AvailableUnits = 4,
                    Wifi = true,
                    Laundry = true
                },
                new Location
                {
                    Id = 1,
                    Name = "A113 Transitional Housing",
                    City = "Santa Monica",
                    State = "CA",
                    Photo = "https:/angular.dev/assets/tutorials/common/brandon-griggs-wR11KBaB86U-unsplash.jpg",
                    AvailableUnits = 0,
                    Wifi = false,
                    Laundry = true
                },
                new Location
                {
                    Id = 2,
                    Name = "Warm Beds Housing Support",
                    City = "Juneau",
                    State = "AK",
                    Photo = "https:/angular.dev/assets/tutorials/common/i-do-nothing-but-love-lAyXdl1-Wmc-unsplash.jpg",
                    AvailableUnits = 1,
                    Wifi = false,
                    Laundry = false
                },
                new Location
                {
                    Id = 3,
                    Name = "Homesteady Housing",
                    City = "Chicago",
                    State = "IL",
                    Photo = "https:/angular.dev/assets/tutorials/common/ian-macdonald-W8z6aiwfi1E-unsplash.jpg",
                    AvailableUnits = 1,
                    Wifi = true,
                    Laundry = false
                },
                new Location
                {
                    Id = 4,
                    Name = "Happy Homes Group",
                    City = "Gary",
                    State = "IN",
                    Photo = "https:/angular.dev/assets/tutorials/common/krzysztof-hepner-978RAXoXnH4-unsplash.jpg",
                    AvailableUnits = 1,
                    Wifi = true,
                    Laundry = false
                },
                new Location
                {
                    Id = 5,
                    Name = "Hopeful Apartment Group",
                    City = "Oakland",
                    State = "CA",
                    Photo = "https:/angular.dev/assets/tutorials/common/r-architecture-JvQ0Q5IkeMM-unsplash.jpg",
                    AvailableUnits = 2,
                    Wifi = true,
                    Laundry = true
                },
                new Location
                {
                    Id = 6,
                    Name = "Seriously Safe Towns",
                    City = "Oakland",
                    State = "CA",
                    Photo = "https:/angular.dev/assets/tutorials/common/phil-hearing-IYfp2Ixe9nM-unsplash.jpg",
                    AvailableUnits = 5,
                    Wifi = true,
                    Laundry = true
                },
                new Location
                {
                    Id = 7,
                    Name = "Hopeful Housing Solutions",
                    City = "Oakland",
                    State = "CA",
                    Photo = "https:/angular.dev/assets/tutorials/common/r-architecture-GGupkreKwxA-unsplash.jpg",
                    AvailableUnits = 2,
                    Wifi = true,
                    Laundry = true
                },
                new Location
                {
                    Id = 8,
                    Name = "Seriously Safe Towns",
                    City = "Oakland",
                    State = "CA",
                    Photo = "https:/angular.dev/assets/tutorials/common/saru-robert-9rP3mxf8qWI-unsplash.jpg",
                    AvailableUnits = 10,
                    Wifi = false,
                    Laundry = false
                },
                new Location
                {
                    Id = 9,
                    Name = "Capital Safe Towns",
                    City = "Portland",
                    State = "OR",
                    Photo = "https:/angular.dev/assets/tutorials/common/webaliser-_TPTXZd9mOo-unsplash.jpg",
                    AvailableUnits = 6,
                    Wifi = true,
                    Laundry = true
                },
            };
        }
    }
}
