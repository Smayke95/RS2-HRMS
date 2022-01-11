using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRMS.Models.Data
{
    public static class TaskStatusData
    {
        public static void GenerateData(this EntityTypeBuilder<TaskStatus> entity)
        {
            entity.HasData(
                 new TaskStatus
                 {
                     Id = 1,
                     Name = "Kreiran"
                 },
                 new TaskStatus
                 {
                     Id = 2,
                     Name = "Aktivan"
                 },
                 new TaskStatus
                 {
                     Id = 3,
                     Name = "Riješen"
                 },
                 new TaskStatus
                 {
                     Id = 4,
                     Name = "Zatvoren"
                 }
             );
        }
    }
}