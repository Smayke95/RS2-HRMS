using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRMS.Models.Data
{
    public static class TaskCommentData
    {
        public static void GenerateData(this EntityTypeBuilder<TaskComment> entity)
        {
            entity.HasData(
                   new TaskComment
                   {
                       Id = 1,
                       Content = "Task preuzet dana 19.8. i stavljen 'In progress'.",
                       Time = DateTime.Now,
                       TaskId = 1,                       
                       EmployeeId = 1
                   },
                   new TaskComment
                   {
                       Id = 2,
                       Content = "Task zavrsen.",
                       Time = DateTime.Now,
                       TaskId = 2,
                       EmployeeId = 2
                   }                  
               );
        }
    }
}