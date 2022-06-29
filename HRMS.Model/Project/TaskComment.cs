namespace HRMS.Model
{
    public class TaskComment
    {
        public int Id { get; set; }

        public string Name { get; set; }
       
        public virtual Department ParentDepartment { get; set; }

        public int Level { get; set; }
       
        public virtual Employee Supervisor { get; set; }
    }
}
