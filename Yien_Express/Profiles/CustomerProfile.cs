using AutoMapper;
using Yien_Express.DTO;
using Yien_Express.Model;

namespace Yien_Express.Profiles
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<Customer, CustomerReadDTO>();
            CreateMap<CustomerCreateDTO, Customer>();
        }
    }
}
