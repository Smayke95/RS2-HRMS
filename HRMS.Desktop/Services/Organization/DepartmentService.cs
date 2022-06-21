using AutoMapper;
using HRMS.Desktop.Interfaces;
using HRMS.Desktop.ViewModels;
using HRMS.Model;

namespace HRMS.Desktop.Services
{
    public class DepartmentService : ApiService<Department, DepartmentViewModel>, IDepartmentService
    {
        public DepartmentService(IMapper mapper) : base(mapper) { }
    }
}