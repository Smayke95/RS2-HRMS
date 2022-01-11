using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRMS.Models
{
    [Table("TaskTypes")]
    public class TaskType
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }



        // Relations
        public virtual ICollection<Task> Tasks { get; set; }
    }
}