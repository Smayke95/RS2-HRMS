using AutoMapper;
using HRMS.Interfaces;
using HRMS.Models;

namespace HRMS.Services
{
    public class PositionService : CrudService<Position, Model.Position>, IPositionService
    {
        public PositionService(
            HRMS_Context context,
            IMapper mapper)
            : base(context, mapper) { }
    }
}