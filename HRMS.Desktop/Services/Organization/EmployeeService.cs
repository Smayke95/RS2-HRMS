using AutoMapper;
using HRMS.Desktop.Interfaces;
using HRMS.Desktop.ViewModels;
using HRMS.Model;

namespace HRMS.Desktop.Services
{
    public class EmployeeService : ApiService<Employee, EmployeeViewModel>, IEmployeeService
    {
        public EmployeeService(IMapper mapper) : base(mapper) { }
    }
}