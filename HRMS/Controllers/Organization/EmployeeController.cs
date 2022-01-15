using HRMS.Interfaces;
using HRMS.Models;

namespace HRMS.Controllers
{
    public class EmployeeController : CrudController<Employee, Model.Employee>
    {
        public EmployeeController(IEmployeeService employeeService) : base(employeeService) { }
    }
}