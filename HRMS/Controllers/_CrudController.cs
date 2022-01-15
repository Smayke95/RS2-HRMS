using HRMS.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HRMS.Controllers
{
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
        public virtual M Get(int id) => CrudService.Get(id);

        [HttpGet]
        public virtual IEnumerable<M> GetAll() => CrudService.GetAll();

        [HttpPost]
        public virtual M Insert([FromBody] M model) => CrudService.Insert(model);

        [HttpPut("{id}")]
        public virtual M Update([FromBody] M model) => CrudService.Update(model);

        [HttpDelete("{id}")]
        public virtual bool Delete(int id) => CrudService.Delete(id);
    }
}