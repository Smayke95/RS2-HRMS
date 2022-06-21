using AutoMapper;
using HRMS.Desktop.Interfaces;
using HRMS.Desktop.ViewModels;
using HRMS.Model;

namespace HRMS.Desktop.Services
{
    public class PositionService : ApiService<Position, PositionViewModel>, IPositionService
    {
        public PositionService(IMapper mapper) : base(mapper) { }
    }
}