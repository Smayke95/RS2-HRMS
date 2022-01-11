using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace HRMS.Models.Data
{
    public static class LogData
    {
        public static void GenerateData(this EntityTypeBuilder<Log> entity)
        {
            entity.HasData(
                new Log
                {
                    Id = 1,
                    Date = DateTime.Now,
                    Type = LogType.INFO,
                    Message = ""
                },
                new Log
                {
                    Id = 2,
                    Date = DateTime.Now,
                    Type = LogType.WARNING,
                    Message = ""
                },
                new Log
                {
                    Id = 3,
                    Date = DateTime.Now,
                    Type = LogType.ERROR,
                    Message = ""
                }
            );
        }
    }
}