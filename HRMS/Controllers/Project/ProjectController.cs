using HRMS.Interfaces;
using HRMS.Models;

namespace HRMS.Controllers
{
    public class ProjectController : CrudController<Project, Model.Project>
    {
        public ProjectController(IProjectService projectService) : base(projectService) { }
    }
}