using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRMS.Models
{
    [Table("Countries")]
    public class Country
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }



        // Relations
        public virtual ICollection<City> Cities { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}