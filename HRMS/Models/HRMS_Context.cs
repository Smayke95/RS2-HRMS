using System;
using HRMS.Models.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace HRMS.Models
{
    public class HRMS_Context : DbContext
    {
        // Calendar
        public DbSet<Event> Events { get; set; }
        public DbSet<EventType> EventTypes { get; set; }

        // Chat
        public DbSet<Message> Messages { get; set; }

        // Organization
        public DbSet<Education> Educations { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeePosition> EmployeePositions { get; set; }
        public DbSet<EmploymentType> EmploymentTypes { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<PayGrade> PayGrades { get; set; }
        public DbSet<Position> Positions { get; set; }

        // Other
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Log> Logs { get; set; }
        public DbSet<Notification> Notifications { get; set; }

        //Project
        public DbSet<Project> Projects { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<TaskStatus> TaskStatuses { get; set; }
        public DbSet<TaskType> TaskTypes { get; set; }
        public DbSet<TaskComment> TaskComments { get; set; }

        public HRMS_Context(DbContextOptions<HRMS_Context> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Employee>()
                   .HasOne(x => x.BirthPlace)
                   .WithMany()
                   .IsRequired(false);

            modelBuilder.Entity<Employee>()
                   .HasOne(x => x.City)
                   .WithMany()
                   .IsRequired(false);

            modelBuilder.Entity<Log>()
                   .Property(x => x.Type)
                   .HasConversion(
                        x => x.ToString(),
                        x => (LogType)Enum.Parse(typeof(LogType), x)
                   );

            modelBuilder.Entity<Country>().GenerateData();
            modelBuilder.Entity<City>().GenerateData();
            modelBuilder.Entity<Department>().GenerateData();
            modelBuilder.Entity<Education>().GenerateData();
            modelBuilder.Entity<PayGrade>().GenerateData();
            modelBuilder.Entity<Position>().GenerateData();
            modelBuilder.Entity<Employee>().GenerateData();
            modelBuilder.Entity<Notification>().GenerateData();
            modelBuilder.Entity<EventType>().GenerateData();
            modelBuilder.Entity<Event>().GenerateData();
            modelBuilder.Entity<EmploymentType>().GenerateData();
            modelBuilder.Entity<EmployeePosition>().GenerateData();
            modelBuilder.Entity<Project>().GenerateData();
            modelBuilder.Entity<Task>().GenerateData();
            modelBuilder.Entity<TaskStatus>().GenerateData();
            modelBuilder.Entity<TaskType>().GenerateData();
            modelBuilder.Entity<TaskComment>().GenerateData();

            modelBuilder.Entity<Log>().GenerateData();
        }
    }
}