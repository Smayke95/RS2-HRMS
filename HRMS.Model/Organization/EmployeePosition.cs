using System;

namespace HRMS.Model
{
    public class EmployeePosition
    {
        public int Id { get; set; }

        public Employee Employee { get; set; }

        public Position Position { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public decimal Salary { get; set; }

        public int VacationDays { get; set; }

        public EmploymentType EmploymentType { get; set; }

        public string WorkingHours { get; set; }
    }
}