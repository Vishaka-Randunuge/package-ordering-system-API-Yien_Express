using Yien_Express.Model;

namespace Yien_Express.Data
{
    public class PackageRepo : IPackageRepo
    {
        private AppDBContext context;

        public PackageRepo(AppDBContext dBContext)
        {
            context = dBContext;
        }
        public void CreatePackage(Package package)
        {
            if(package == null)
                throw new ArgumentNullException(nameof(package));
            context.packages.Add(package);
        }

        public void Delete(Package package)
        {
            context.packages.Remove(package);
            Save();
        }

        public Package GetPackage(int id)
        {
            return context.packages.FirstOrDefault(p=> p.ID==id);
        }

        public IEnumerable<Package> GetPackages()
        {
            return context.packages.ToList();
        }

        public bool Save()
        {
            int count = context.SaveChanges();
            if(count>0)
                return true;
            else
                return false;
        }

        public bool Update(Package package)
        {
            context.packages.Update(package);
            return Save();
        }
    }
}
