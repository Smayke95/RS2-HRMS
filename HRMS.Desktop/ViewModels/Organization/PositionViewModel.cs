using HRMS.Model;

namespace HRMS.Desktop.ViewModels
{
    public class PositionViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DepartmentViewModel Department { get; set; }

        public PayGrade PayGrade { get; set; }

        public Education RequiredEducation { get; set; }

        public bool IsWorkExperienceRequired { get; set; }
    }
}