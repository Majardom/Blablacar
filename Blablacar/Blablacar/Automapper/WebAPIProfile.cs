using AutoMapper;
using Blablacar.Dtos;
using System;

namespace Blablacar.Automapper
{
    public class WebAPIProfile : Profile
    {
        public WebAPIProfile()
        {
            CreateMap<Domain.Core.Customer, CustomerDto>().ReverseMap();

            CreateMap<Domain.Core.Driver, DriverDto>().ReverseMap();

            CreateMap<TripDto, Domain.Core.Trip>().ForMember(x => x.DepartureTime, m => m.MapFrom(s =>
                DateTime.Parse(s.DepartureTime)));


            CreateMap<Domain.Core.Trip, TripDto>().ForMember(x => x.DepartureTime, m => m.MapFrom(s =>
                s.DepartureTime.ToString()));
        }
    }
}
