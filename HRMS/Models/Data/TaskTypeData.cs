using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRMS.Models.Data
{
    public static class TaskTypeData
    {
        public static void GenerateData(this EntityTypeBuilder<TaskType> entity)
        {
            entity.HasData(
                 new TaskType
                 {
                     Id = 1,
                     Name = "Bug"
                 },
                 new TaskType
                 {
                     Id = 2,
                     Name = "Feature"
                 }
             );
        }
    }
}