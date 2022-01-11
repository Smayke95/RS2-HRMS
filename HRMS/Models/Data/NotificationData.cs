using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRMS.Models.Data
{
    public static class NotificationData
    {
        public static void GenerateData(this EntityTypeBuilder<Notification> entity)
        {
            entity.HasData(
                    new Notification
                    {
                        Id = 1,
                        Text = "Dobili ste novog kolegu",
                        EmployeeId = 1
                    },
                    new Notification
                    {
                        Id = 2,
                        Text = "Dodani ste na projekat",
                        EmployeeId = 1
                    },
                    new Notification
                    {
                        Id = 3,
                        Text = "Imate novi komentar",
                        EmployeeId = 1
                    }
                );
        }
    }
}