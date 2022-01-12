namespace HRMS.Model
{
    public class Notification
    {
        public int Id { get; set; }

        public Employee Employee { get; set; }

        public string Text { get; set; }

        public bool IsReaded { get; set; }
    }
}