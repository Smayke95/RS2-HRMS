namespace HRMS.Model
{
    public class City
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ZipCode { get; set; }

        public Country Country { get; set; }
    }
}