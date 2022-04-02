using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRMS.Models
{
    [Table("Employees")]
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MaidenName { get; set; }

        public string ParentName { get; set; }

        public Gender Gender { get; set; }

        public string RegistrationNumber { get; set; }

        public string PersonalIdentificationNumber { get; set; }

        public string WorkerCode { get; set; }

        public DateTime BirthDate { get; set; }

        [ForeignKey("BirthPlace")]
        public int? BirthPlaceId { get; set; }
        public virtual City BirthPlace { get; set; }

        public string Address { get; set; }

        [ForeignKey("City")]
        public int? CityId { get; set; }
        public virtual City City { get; set; }

        [ForeignKey("Citizenship")]
        public int? CitizenshipId { get; set; }
        public virtual Country Citizenship { get; set; }

        public string Image { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Phone { get; set; }

        public string Mobile { get; set; }

        public string OfficePhone { get; set; }

        public string Profession { get; set; }

        [ForeignKey("Education")]
        public int? EducationId { get; set; }
        public virtual Education Education { get; set; }

        public int PreviousLOSYears { get; set; }

        public int PreviousLOSMonths { get; set; }

        public string BankAccount { get; set; }

        public string Note { get; set; }

        public DateTime CreateDate { get; set; }



        // Relations
        public virtual ICollection<Department> Departments { get; set; }
        public virtual ICollection<EmployeePosition> EmployeePositions { get; set; }
        public virtual ICollection<Event> Events { get; set; }
        public virtual ICollection<Notification> Notifications { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }
        public virtual ICollection<TaskComment> TaskComments { get; set; }
    }
}