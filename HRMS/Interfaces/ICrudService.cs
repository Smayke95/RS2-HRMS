using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace HRMS.Interfaces
{
    public interface ICrudService<DBM, M>
        where DBM : class
        where M : class
    {
        M Get(int id);
        M GetWhere(
            Expression<Func<DBM, bool>> where,
            Expression<Func<DBM, object>> include1 = null,
            Expression<Func<DBM, object>> include2 = null,
            Expression<Func<DBM, object>> include3 = null);
        IEnumerable<M> GetAll();
        M Insert(M model);
        M Update(M model);
        bool Delete(int id);
    }
}