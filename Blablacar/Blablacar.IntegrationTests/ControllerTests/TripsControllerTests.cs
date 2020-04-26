using Blablacar.Domain.Core;
using Blablacar.Dtos;
using FluentAssertions;
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using Xunit;

namespace Blablacar.IntegrationTests.ControllerTests
{
    public class TripsControllerTests
        : IClassFixture<BlablacarWebAppFactory<Startup>>
    {
        private readonly BlablacarWebAppFactory<Startup> _factory;

        public TripsControllerTests(
            BlablacarWebAppFactory<Startup> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task Get_ReturnsOkResult()
        {
            var client = _factory.CreateClient();
            var res = await client.GetAsync("/Trips");
            res.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Fact]
        public async Task Post_ReturnsOkResult()
        {
            var trip = new TripDto() { From = "Kyiv",To = "Poltava" };
            var client = _factory.CreateClient();
            var res = await client.PostAsJsonAsync("/Trips", trip);
            res.StatusCode.Should().Be(HttpStatusCode.OK);
        }
    }
}
