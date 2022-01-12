using AutoMapper;
using HRMS.Interfaces;
using HRMS.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace HRMS.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly HRMS_Context Context;
        private readonly IMapper Mapper;

        public EmployeeService(
            HRMS_Context context,
            IMapper mapper)
        {
            Context = context;
            Mapper = mapper;
        }

        public IEnumerable<Model.Employee> GetAll()
        {
            var employees = Context
                .Employees
                .Include(x => x.BirthPlace)
                .Include(x => x.City)
                .OrderBy(x => x.FirstName)
                .ThenBy(x => x.LastName)
                .ToList();

            return Mapper.Map<IEnumerable<Model.Employee>>(employees);
        }
    }
}