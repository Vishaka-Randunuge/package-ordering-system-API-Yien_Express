using Yien_Express.Model;

namespace Yien_Express.Data
{
    public interface IEmployeeRepo
    {
        void CreateEmployee(Employee employee);
        void Delete(Employee employee);
        bool Update(Employee employee);

        Employee GetEmployee(int id);
        IEnumerable<Employee> GetEmployees();

        bool Save();
    }
}
