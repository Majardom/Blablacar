using AutoMapper;
using Blablacar.Dtos;

namespace Blablacar.Automapper
{
    public class WebAPIProfile : Profile
    {
        public WebAPIProfile()
        {
            CreateMap<Domain.Core.Customer, CustomerDto>().ReverseMap();

            CreateMap<Domain.Core.Driver, DriverDto>().ReverseMap();

            CreateMap<Domain.Core.Trip, TripDto>().ReverseMap();
        }
    }
}
