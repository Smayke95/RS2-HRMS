using System.Collections.Generic;
using System.Threading.Tasks;

namespace HRMS.Desktop.Interfaces
{
    public interface IApiService<M, VM>
        where M : class
        where VM : class
    {
        Task<VM> Get(int id);
        Task<IEnumerable<VM>> GetAll();
        Task<VM> Insert(VM model);
        Task<VM> Update(VM model);
        Task<bool> Delete(int id);
    }
}