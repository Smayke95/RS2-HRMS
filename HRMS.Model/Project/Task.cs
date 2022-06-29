namespace HRMS.Model
{
    public class Task
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
       
        public virtual Project Project { get; set; }
      
        public virtual TaskStatus Status { get; set; }
       
        public virtual TaskType Type { get; set; }
     
        public virtual Employee Employee { get; set; }
    }
}
