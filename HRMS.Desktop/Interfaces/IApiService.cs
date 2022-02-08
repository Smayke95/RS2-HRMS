using System.Collections.Generic;
using System.Threading.Tasks;

namespace HRMS.Desktop.Interfaces
{
    public interface IApiService<M>
        where M : class
    {
        Task<M> Get(int id);
        Task<IEnumerable<M>> GetAll();
        Task<M> Insert(M model);
        Task<M> Update(M model);
        Task<bool> Delete(int id);
    }
}