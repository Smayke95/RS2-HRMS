namespace HRMS.Desktop.ViewModels
{
    public class DepartmentViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DepartmentViewModel ParentDepartment { get; set; }

        public int Level { get; set; }

        public EmployeeViewModel Supervisor { get; set; }
    }
}