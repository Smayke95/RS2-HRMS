using System.Collections.Generic;

namespace HRMS.Interfaces
{
    public interface IEmployeeService
    {
        public IEnumerable<Model.Employee> GetAll();
    }
}