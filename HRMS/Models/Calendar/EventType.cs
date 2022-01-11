using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRMS.Models
{
    [Table("EventTypes")]
    public class EventType
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public bool IsApprovalRequired { get; set; }

        public string Color { get; set; }



        // Relations
        public virtual ICollection<Event> Events { get; set; }
    }
}