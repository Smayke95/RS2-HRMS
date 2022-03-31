using Flurl.Http;
using HRMS.Desktop.Interfaces;
using HRMS.Desktop.Properties;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HRMS.Desktop.Services
{
    public abstract class ApiService<M> : IApiService<M>
        where M : class
    {
        public async Task<M> Get(int id)
        {
            return await $"{Settings.Default.ApiURL}/Department/{id}".GetJsonAsync<M>();
        }

        public async Task<IEnumerable<M>> GetAll()
        {
            return await $"{Settings.Default.ApiURL}/Department".WithOAuthBearerToken(Settings.Default.Token).GetJsonAsync<IEnumerable<M>>();
        }

        public Task<M> Insert(M model)
        {
            throw new System.NotImplementedException();
        }

        public Task<M> Update(M model)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> Delete(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}