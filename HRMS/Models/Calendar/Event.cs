using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRMS.Models
{
    [Table("Events")]
    public class Event
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        [ForeignKey("EventType")]
        public int EventTypeId { get; set; }
        public virtual EventType EventType { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string Description { get; set; }

        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
    }
}