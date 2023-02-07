using Yien_Express.Model;

namespace Yien_Express.Data
{
    public interface ICustomerRepo
    {
        void CreateCustomer(Customer customer);
        void Delete(Customer customer);
        bool Update(Customer customer);

        Customer GetCustomer(int id);
        IEnumerable<Customer> GetCustomers();

        bool Save();
    }
}
