using AutoMapper;
using HRMS.Interfaces;
using HRMS.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace HRMS.Services
{
    public class CrudService<DBM, M> : ICrudService<DBM, M>
        where DBM : class
        where M : class, new()
    {
        private readonly HRMS_Context Context;
        private readonly IMapper Mapper;

        protected CrudService(
            HRMS_Context context,
            IMapper mapper)
        {
            Context = context;
            Mapper = mapper;
        }

        public virtual M Get(int id)
        {
            var isNew = id == 0;

            if (!isNew)
            {
                var entity = Context
                    .Set<DBM>()
                    .Find(id);

                return Mapper.Map<M>(entity);
            }

            return new M();
        }

        public M GetWhere(
            Expression<Func<DBM, bool>> where,
            Expression<Func<DBM, object>> include1 = null,
            Expression<Func<DBM, object>> include2 = null,
            Expression<Func<DBM, object>> include3 = null)
        {
            IQueryable<DBM> query = Context.Set<DBM>();

            if (include1 != null)
                query = query.Include(include1);

            if (include2 != null)
                query = query.Include(include2);

            if (include3 != null)
                query = query.Include(include3);

            var result = query.FirstOrDefault(where);

            return Mapper.Map<M>(result);
        }

        public virtual IEnumerable<M> GetAll()
        {
            var list = Context
                .Set<DBM>()
                .ToList();

            return Mapper.Map<IEnumerable<M>>(list);
        }

        public virtual M Insert(M model)
        {
            var entity = Mapper.Map<DBM>(model);

            var addedEntity = Context
                .Set<DBM>()
                .Add(entity);

            Context.SaveChanges();

            return Mapper.Map<M>(addedEntity.Entity);
        }

        public virtual M Update(M model)
        {
            var entity = Mapper.Map<DBM>(model);

            var updatedEntity = Context
                .Set<DBM>()
                .Update(entity);

            Context.SaveChanges();

            return Mapper.Map<M>(updatedEntity.Entity);
        }

        public virtual bool Delete(int id)
        {
            var entity = Context
                .Set<DBM>()
                .Find(id);

            Context.Set<DBM>().Remove(entity);
            Context.SaveChanges();

            return true;
        }
    }
}