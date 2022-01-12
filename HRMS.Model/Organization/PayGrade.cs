namespace HRMS.Model
{
    public class PayGrade
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal MinAmount { get; set; }

        public decimal MaxAmount { get; set; }
    }
}