using HRMS.Model;
using System;

namespace HRMS.Desktop.ViewModels
{
    public class EmployeePositionViewModel
    {
        public int Id { get; set; }

        public EmployeeViewModel Employee { get; set; }

        public PositionViewModel Position { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public decimal Salary { get; set; }

        public int VacationDays { get; set; }

        public EmploymentType EmploymentType { get; set; }

        public string WorkingHours { get; set; }
    }
}