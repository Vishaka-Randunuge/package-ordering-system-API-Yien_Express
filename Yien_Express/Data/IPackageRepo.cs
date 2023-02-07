using Yien_Express.Model;
using Yien_Express.Profiles;

namespace Yien_Express.Data
{
    public interface IPackageRepo
    {
        void CreatePackage(Package package);
        void Delete(Package package);
        bool Update(Package package);

        Package GetPackage(int id);
        IEnumerable<Package> GetPackages();
    
        bool Save();

    }
}
