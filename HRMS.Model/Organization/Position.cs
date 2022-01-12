namespace HRMS.Model
{
    public class Position
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Department Department { get; set; }

        public PayGrade PayGrade { get; set; }

        public Education RequiredEducation { get; set; }

        public bool IsWorkExperienceRequired { get; set; }
    }
}