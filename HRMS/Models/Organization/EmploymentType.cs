using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRMS.Models
{
    [Table("EmploymentTypes")]
    public class EmploymentType
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }



        // Relations
        public virtual ICollection<EmployeePosition> EmployeePositions { get; set; }
    }
}