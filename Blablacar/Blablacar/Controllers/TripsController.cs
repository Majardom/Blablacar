using Blablacar.Domain.Core;
using Blablacar.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Blablacar.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TripsController : ControllerBase
    {
        private readonly ITripService _tripsService;

        public TripsController(ITripService tripsService)
        {
            _tripsService = tripsService;
        }

        [HttpGet]
        public IEnumerable<TripDto> Get()
        {
            return _tripsService.GetTrips();
        }

        [HttpPost]
        [Route("add")]
        public void AddTrip(TripDto trip)
        {
            _tripsService.CreateTrip(trip);
        }

        [HttpPost]
        [Route("order/{tripId}")]
        public void OrderTrip(int tripId, [FromBody]CustomerDto customer)
        {
            _tripsService.OrderTrip(tripId, customer);
        }
    }
}