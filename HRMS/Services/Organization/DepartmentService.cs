using AutoMapper;
using HRMS.Interfaces;
using HRMS.Models;

namespace HRMS.Services
{
    public class DepartmentService : CrudService<Department, Model.Department>, IDepartmentService
    {
        public DepartmentService(
            HRMS_Context context,
            IMapper mapper)
            : base(context, mapper) { }
    }
}