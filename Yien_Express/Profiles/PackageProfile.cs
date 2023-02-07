using AutoMapper;
using Yien_Express.DTO;
using Yien_Express.Model;

namespace Yien_Express.Profiles
{
    public class PackageProfile:Profile
    {
        public PackageProfile()
        {
            CreateMap<Package, PackageReadDTO>();
            CreateMap<PackageCreateDTO, Package>();
        }
    }
}
