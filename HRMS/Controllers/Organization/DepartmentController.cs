using HRMS.Interfaces;
using HRMS.Models;

namespace HRMS.Controllers
{
    public class DepartmentController : CrudController<Department, Model.Department>
    {
        public DepartmentController(IDepartmentService departmentService) : base(departmentService) { }
    }
}