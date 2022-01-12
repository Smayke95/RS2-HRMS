using HRMS.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HRMS.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService EmployeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            EmployeeService = employeeService;
        }

        [HttpGet]
        public IEnumerable<Model.Employee> Get()
        {
            return EmployeeService.GetAll();
        }
    }
}