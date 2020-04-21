using AutoMapper;
using Blablacar.Domain.Core;
using Blablacar.Domain.Interfaces;
using Blablacar.Infrastructure.Data;
using FluentAssertions;
using NSubstitute;
using System;
using System.Collections.Generic;
using Xunit;

namespace Blablacar.Infrastructure.Business.Tests
{
    public class TripServiceTests
    {
        private readonly IUnitOfWork<DriverDto, CustomerDto, TripDto> _unitOfWork;
        private readonly IMapper _mapper;

        public TripServiceTests()
        {
            _unitOfWork = Substitute.For<IUnitOfWork<DriverDto, CustomerDto, TripDto>>();
            _mapper = Substitute.For<IMapper>();
        }

        [Theory]
        [InlineData(null, null)]
        public void Constructor_ThrowsExceptionWhenNullParameter(
            IUnitOfWork<DriverDto, CustomerDto, TripDto> unitOfWork,
            IMapper mapper)
        {
            Action action = () => new TripService(unitOfWork, mapper);

            object p = action.Should().Throw<ArgumentNullException>();
        }

        [Fact]
        public void GetTrips_ShouldReturnAllTrips()
        {
            // Arrange
            _unitOfWork.Trips.GetAll().Returns(CreateTrips());
            var service = new TripService(_unitOfWork, _mapper);

            // Act
            var res = service.GetTrips();

            // Assert
            res.Should().BeEquivalentTo(CreateTrips());
        }

        [Fact]
        public void OrderTrip_ShouldAttachCustomerToTheTrip()
        {
            // Arrange
            var customer = new Customer().WithName("Dan").Is(Gender.Male) as Customer;
            var trip = new Trip().IsFrom("Kyiv").IsTo("Brovary");
            _unitOfWork.Trips.Get(trip.Id).Returns(trip);

            // Act
            var service = new TripService(_unitOfWork, _mapper);
            service.OrderTrip(trip.Id, customer);

            // Assert
            trip.Customer.Should().BeEquivalentTo(customer);
        }

        [Fact]
        public void CreateTrip_ShoulThrowException_WhenTripIsNull()
        {
            // Arange
            var service = new TripService(_unitOfWork, _mapper);

            // Act
            Action action = () => service.CreateTrip(null);

            // Assert
            action.Should().Throw<ArgumentNullException>();
        }

        [Fact]
        public void CreateTrip_ShoulThrowException_WhenTripExists()
        {
            var trip = new Trip().IsFrom("Kyiv").IsTo("Brovary").WithDriver(new Driver());
            _unitOfWork.Trips.GetAll().Returns(new List<Trip> { trip });

            var service = new TripService(_unitOfWork, _mapper);
            Action action = () => service.CreateTrip(trip);

            action.Should().Throw<InvalidOperationException>();
        }

        private IEnumerable<Trip> CreateTrips() =>
            new List<Trip>
            {
                new Trip().IsFrom("Kyiv").IsTo("Lviv"),
                new Trip().IsFrom("Lviv").IsTo("Kyiv"),
                new Trip().IsFrom("Kharkiv").IsTo("Ternopil"),
            };
    }
}
