using AutoMapper;
using Yien_Express.DTO;
using Yien_Express.Model;

namespace Yien_Express.Profiles
{
    public class OrderProfile : Profile
    {
        public OrderProfile()
        {
            CreateMap<Order, OrderReadDTO>();
            CreateMap<OrderCreateDTO, Order>();
        }
    }
}
