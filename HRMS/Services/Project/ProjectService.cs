using AutoMapper;
using HRMS.Interfaces;
using HRMS.Models;

namespace HRMS.Services
{
    public class ProjectService : CrudService<Project, Model.Project>, IProjectService
    {
        public ProjectService(
            HRMS_Context context,
            IMapper mapper)
            : base(context, mapper) { }
    }
}