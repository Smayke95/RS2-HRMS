using HRMS.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HRMS.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public abstract class CrudController<DBM, M> : ControllerBase
        where DBM : class
        where M : class
    {
        private readonly ICrudService<DBM, M> CrudService;

        protected CrudController(ICrudService<DBM, M> crudService)
        {
            CrudService = crudService;
        }

        [HttpGet("{id}")]
        [Produces("application/json")]
        public virtual M Get(int id) => CrudService.Get(id);

        [HttpGet]
        [Produces("application/json")]
        public virtual IEnumerable<M> GetAll() => CrudService.GetAll();

        [HttpPost]
        [Consumes("application/json")]
        [Produces("application/json")]
        public virtual M Insert([FromBody] M model) => CrudService.Insert(model);

        [HttpPut("{id}")]
        [Consumes("application/json")]
        [Produces("application/json")]
        public virtual M Update([FromBody] M model) => CrudService.Update(model);

        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        [Produces("application/json")]
        public virtual bool Delete(int id) => CrudService.Delete(id);
    }
}