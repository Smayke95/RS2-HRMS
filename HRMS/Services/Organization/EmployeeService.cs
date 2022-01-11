using HRMS.Interfaces;
using HRMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HRMS.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly HRMS_Context Context;

        public EmployeeService(HRMS_Context context)
        {
            Context = context;
        }

        public IEnumerable<Employee> GetAll()
        {
            return Context.Employees.ToList();
        }
    }
}