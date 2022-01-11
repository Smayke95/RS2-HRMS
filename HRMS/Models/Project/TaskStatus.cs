using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRMS.Models
{
    [Table("TaskStatuses")]
    public class TaskStatus
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }



        // Relations
        public virtual ICollection<Task> Tasks { get; set; }
    }
}