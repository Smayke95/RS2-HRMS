using AutoMapper;
using HRMS.Models;

namespace HRMS.Mapping
{
    public class OrganizationProfile : Profile
    {
        public OrganizationProfile()
        {
            CreateMap<Department, Model.Department>();

            CreateMap<Education, Model.Education>();

            CreateMap<Employee, Model.Employee>()
                .ForMember(x => x.Image, opt => opt.MapFrom(y => string.IsNullOrEmpty(y.Image) ? "/img/avatars/default.png" : y.Image));
            CreateMap<Model.Employee, Employee>()
                .ForMember(x => x.BirthPlace, opt => opt.Ignore())
                .ForMember(x => x.City, opt => opt.Ignore())
                .ForMember(x => x.Citizenship, opt => opt.Ignore())
                .ForMember(x => x.Education, opt => opt.Ignore());

            CreateMap<EmployeePosition, Model.EmployeePosition>();

            CreateMap<EmploymentType, Model.EmploymentType>();

            CreateMap<PayGrade, Model.PayGrade>();

            CreateMap<Position, Model.Position>();
        }
    }
}