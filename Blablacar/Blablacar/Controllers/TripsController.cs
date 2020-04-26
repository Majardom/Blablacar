using AutoMapper;
using Blablacar.Domain.Core;
using Blablacar.Dtos;
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
        private readonly IMapper _mapper;

        public TripsController(ITripService tripsService, IMapper mapper)
        {
            _tripsService = tripsService;
            _mapper = mapper;
        }

        [HttpGet]
        public IEnumerable<TripDto> Get()
        {
            return _mapper.Map<IEnumerable<TripDto>>( _tripsService.GetTrips());
        }

        [HttpPost]
        public void AddTrip([FromBody]TripDto trip)
        {
            _tripsService.CreateTrip(_mapper.Map<Trip>(trip));
        }

        [HttpPost]
        [Route("order/{tripId}")]
        public void OrderTrip(int tripId, [FromBody]CustomerDto customer)
        {
            _tripsService.OrderTrip(tripId, _mapper.Map<Customer>(customer));
        }
    }
}