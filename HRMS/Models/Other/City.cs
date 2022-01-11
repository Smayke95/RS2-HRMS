using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRMS.Models
{
    [Table("Cities")]
    public class City
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string ZipCode { get; set; }

        [ForeignKey("Country")]
        public int CountryId { get; set; }
        public virtual Country Country { get; set; }
    }
}