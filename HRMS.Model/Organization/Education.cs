namespace HRMS.Model
{
    public class Education
    {
        public int Id { get; set; }

        public string ISCED { get; set; }

        public int EQF { get; set; }

        public string Qualification { get; set; }

        public string FinishedEducation { get; set; }

        public string QualificationOld { get; set; }

        public string FinishedEducationOld { get; set; }
    }
}