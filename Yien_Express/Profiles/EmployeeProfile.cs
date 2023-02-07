using AutoMapper;
using Yien_Express.DTO;
using Yien_Express.Model;

namespace Yien_Express.Profiles
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<Employee, EmployeeReadDTO>();
            CreateMap<EmployeeCreateDTO, Employee>();
        }
    }
}