using Yien_Express.Model;

namespace Yien_Express.Data
{
    public interface IUserRepo
    {
        void CreateUser(User user);
        void Delete(User user);
        bool Update(User user);
        User GetUser(int id);
        IEnumerable<User> GetUsers();

        bool Save();
    }
}
