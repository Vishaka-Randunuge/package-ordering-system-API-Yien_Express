using Yien_Express.Model;
namespace Yien_Express.Data
{
    public class EmployeeRepo : IEmployeeRepo
    {
        private AppDBContext context;

        public EmployeeRepo(AppDBContext dBContext)
        {
            context = dBContext;
        }
        public void CreateEmployee(Employee employee)
        {
            if (employee == null)
                throw new ArgumentNullException(nameof(employee));
            context.employees.Add(employee);
        }

        public void Delete(Employee employee)
        {
            context.employees.Remove(employee);
            Save();
        }

        public Employee GetEmployee(int id)
        {
            return context.employees.FirstOrDefault(e => e.ID == id);
        }



        public IEnumerable<Employee> GetEmployees()
        {
            return context.employees.ToList();
        }

        public bool Save()
        {
            int count = context.SaveChanges();
            if (count > 0)
                return true;
            else
                return false;
        }

        public bool Update(Employee employee)
        {
            context.employees.Update(employee);
            return Save();
        }


    }
}