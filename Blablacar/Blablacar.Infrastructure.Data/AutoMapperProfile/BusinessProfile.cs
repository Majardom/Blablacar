using AutoMapper;

namespace Blablacar.Infrastructure.Data
{
    public class BusinessProfile : Profile
    {
        public BusinessProfile()
        {
            CreateMap<Domain.Core.Customer, Customer>().ReverseMap();

            CreateMap<Domain.Core.Driver, Driver>().ReverseMap();

            CreateMap<Domain.Core.Trip, Trip>().ReverseMap();
        }
    }
}
