using AutoMapper;
using HRMS.Desktop.Interfaces;
using HRMS.Desktop.ViewModels;
using HRMS.Model;

namespace HRMS.Desktop.Services
{
    public class EmployeePositionService : ApiService<EmployeePosition, EmployeePositionViewModel>, IEmployeePositionService
    {
        public EmployeePositionService(IMapper mapper) : base(mapper) { }
    }
}