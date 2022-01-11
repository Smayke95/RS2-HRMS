using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HRMS.Models.Data
{
    public static class EmploymentTypeData
    {
        public static void GenerateData(this EntityTypeBuilder<EmploymentType> entity)
        {
            entity.HasData(
                new EmploymentType
                {
                    Id = 1,
                    Name = "Određeno"
                },
                new EmploymentType
                {
                    Id = 2,
                    Name = "Neodređeno"
                }
            );
        }
    }
}