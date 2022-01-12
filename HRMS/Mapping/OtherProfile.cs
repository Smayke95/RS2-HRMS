using AutoMapper;
using HRMS.Models;

namespace HRMS.Mapping
{
    public class OtherProfile : Profile
    {
        public OtherProfile()
        {
            CreateMap<City, Model.City>().ReverseMap();
            CreateMap<Country, Model.Country>().ReverseMap();
        }
    }
}