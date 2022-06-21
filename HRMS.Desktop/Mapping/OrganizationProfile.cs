using AutoMapper;
using HRMS.Desktop.ViewModels;
using HRMS.Model;

namespace HRMS.Desktop.Mapping
{
    public class OrganizationProfile : Profile
    {
        public OrganizationProfile()
        {
            CreateMap<Department, DepartmentViewModel>();
            CreateMap<DepartmentViewModel, Department>()
                .ForMember(x => x.ParentDepartment, opt => opt.Ignore())
                .ForMember(x => x.Supervisor, opt => opt.Ignore())
                .ForMember(x => x.Level, opt => opt.MapFrom(y => y.ParentDepartment == null ? 0 : y.ParentDepartment.Level + 1));

            CreateMap<Employee, EmployeeViewModel>();
            CreateMap<EmployeeViewModel, Employee>()
                .ForMember(x => x.BirthPlace, opt => opt.Ignore())
                .ForMember(x => x.City, opt => opt.Ignore())
                .ForMember(x => x.Citizenship, opt => opt.Ignore())
                .ForMember(x => x.Education, opt => opt.Ignore());

            CreateMap<EmployeePosition, EmployeePositionViewModel>();
            CreateMap<EmployeePositionViewModel, EmployeePosition>()
                .ForMember(x => x.Employee, opt => opt.Ignore())
                .ForMember(x => x.Position, opt => opt.Ignore())
                .ForMember(x => x.EmploymentType, opt => opt.Ignore());

            CreateMap<Position, PositionViewModel>();
            CreateMap<PositionViewModel, Position>()
                .ForMember(x => x.Department, opt => opt.Ignore())
                .ForMember(x => x.PayGrade, opt => opt.Ignore())
                .ForMember(x => x.RequiredEducation, opt => opt.Ignore());
        }
    }
}