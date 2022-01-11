using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRMS.Models
{
    [Table("Educations")]
    public class Education
    {
        [Key]
        public int Id { get; set; }

        public string ISCED { get; set; }

        public int EQF { get; set; }

        public string Qualification { get; set; }

        public string FinishedEducation { get; set; }

        public string QualificationOld { get; set; }

        public string FinishedEducationOld { get; set; }



        // Relations
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Position> Positions { get; set; }
    }
}