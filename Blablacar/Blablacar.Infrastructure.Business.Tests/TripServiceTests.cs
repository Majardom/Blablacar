using AutoMapper;
using Blablacar.Domain.Core;
using Blablacar.Domain.Interfaces;
using FluentAssertions;
using NSubstitute;
using System;
using System.Collections.Generic;
using Xunit;

namespace Blablacar.Infrastructure.Business.Tests
{
    public class TripServiceTests
    {
        private readonly IUnitOfWork<Data.Driver, Data.Customer, Data.Trip> _unitOfWork;
        private readonly IMapper _mapper;

        public TripServiceTests()
        {
            _unitOfWork = Substitute.For<IUnitOfWork<Data.Driver, Data.Customer, Data.Trip>>();
            _mapper = Substitute.For<IMapper>();
        }

        [Theory]
        [InlineData(null, null)]
        public void Constructor_ThrowsExceptionWhenNullParameter(
            IUnitOfWork<Data.Driver, Data.Customer, Data.Trip> unitOfWork,
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
            var customer = new Domain.Core.Customer().WithName("Dan").Is(Gender.Male) as Domain.Core.Customer;
            var trip = new Domain.Core.Trip().IsFrom("Kyiv").IsTo("Brovary");
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
            var trip = new Domain.Core.Trip().IsFrom("Kyiv").IsTo("Brovary").WithDriver(new Domain.Core.Driver());
            _unitOfWork.Trips.GetAll().Returns(new List<Domain.Core.Trip> { trip });

            var service = new TripService(_unitOfWork, _mapper);
            Action action = () => service.CreateTrip(trip);

            action.Should().Throw<InvalidOperationException>();
        }

        private IEnumerable<Domain.Core.Trip> CreateTrips() =>
            new List<Domain.Core.Trip>
            {
                new Domain.Core.Trip().IsFrom("Kyiv").IsTo("Lviv"),
                new Domain.Core.Trip().IsFrom("Lviv").IsTo("Kyiv"),
                new Domain.Core.Trip().IsFrom("Kharkiv").IsTo("Ternopil"),
            };
    }
}
