using AutoMapper;
using HRMS.Interfaces;
using HRMS.Models;

namespace HRMS.Services
{
    public class EmployeePositionService : CrudService<EmployeePosition, Model.EmployeePosition>, IEmployeePositionService
    {
        public EmployeePositionService(
            HRMS_Context context,
            IMapper mapper)
            : base(context, mapper) { }
    }
}