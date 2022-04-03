using HRMS.Interfaces;
using HRMS.Models;

namespace HRMS.Controllers
{
    public class PositionController : CrudController<Position, Model.Position>
    {
        public PositionController(IPositionService positionService) : base(positionService) { }
    }
}