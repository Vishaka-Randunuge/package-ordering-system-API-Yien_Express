using AutoMapper;
using Yien_Express.DTO;
using Yien_Express.Model;

namespace Yien_Express.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserReadDTO>();
            CreateMap<UserCreateDTO, User>();

        }
    }
}
