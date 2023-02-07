using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Yien_Express.Data;
using Yien_Express.DTO;
using Yien_Express.Model;

namespace Yien_Express.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        public IEmployeeRepo employeeRepo;
        public IMapper mapper;

        public EmployeesController(IEmployeeRepo eRepo, IMapper eMapper)
        {
            employeeRepo = eRepo;
            mapper = eMapper;
        }
        [HttpGet]
        public ActionResult<IEnumerable<EmployeeReadDTO>> GetEmployee()
        {
            var employees = employeeRepo.GetEmployees();
            return Ok(mapper.Map<IEnumerable<EmployeeReadDTO>>(employees));
        }
        [HttpGet("{code}", Name = "GetEmployee")]
        public ActionResult<EmployeeReadDTO> GetEmployee(int code)
        {
            var employee = employeeRepo.GetEmployee(code);
            if (employee != null)
                return Ok(mapper.Map<EmployeeReadDTO>(employee));
            else
                return NotFound();
        }
        [HttpPost]
        public ActionResult<EmployeeCreateDTO> CreateEmployee(EmployeeCreateDTO employee)
        {
            var modelEmployee = mapper.Map<Employee>(employee);
            employeeRepo.CreateEmployee(modelEmployee);
            employeeRepo.Save();
            var newEmployee = mapper.Map<EmployeeReadDTO>(modelEmployee);
            return CreatedAtRoute(nameof(GetEmployee),
                new { code = newEmployee.ID }, newEmployee);
        }
        [HttpPut("{code}")]
        public ActionResult Update(int code, EmployeeCreateDTO employee)
        {
            var employeeToUpdate = mapper.Map<Employee>(employee);
            employeeToUpdate.ID = code;
            if (employeeRepo.Update(employeeToUpdate))
                return Ok();
            else
                return NotFound();
        }
        [HttpDelete("{code}")]
        public ActionResult Delete(int code)
        {
            var employeeToDelete = employeeRepo.GetEmployee(code);

            if (employeeToDelete != null)
            {
                employeeRepo.Delete(employeeToDelete);
                return Ok();
            }

            else
                return NotFound();
        }
    }
}
