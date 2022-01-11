using HRMS.Models;
using System.Collections.Generic;

namespace HRMS.Interfaces
{
    public interface IEmployeeService
    {
        public IEnumerable<Employee> GetAll();
    }
}