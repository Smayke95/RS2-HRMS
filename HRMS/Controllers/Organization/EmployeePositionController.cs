using HRMS.Interfaces;
using HRMS.Models;

namespace HRMS.Controllers
{
    public class EmployeePositionController : CrudController<EmployeePosition, Model.EmployeePosition>
    {
        public EmployeePositionController(IEmployeePositionService employeePositionService) : base(employeePositionService) { }
    }
}