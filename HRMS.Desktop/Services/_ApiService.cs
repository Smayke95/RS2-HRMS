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
            => await $"{Settings.Default.ApiURL}/{typeof(M).Name}/{id}"
                .WithOAuthBearerToken(Settings.Default.Token)
                .GetJsonAsync<M>();

        public async Task<IEnumerable<M>> GetAll()
            => await $"{Settings.Default.ApiURL}/{typeof(M).Name}"
                .WithOAuthBearerToken(Settings.Default.Token)
                .GetJsonAsync<IEnumerable<M>>();

        public async Task<M> Insert(M model)
            => await $"{Settings.Default.ApiURL}/{typeof(M).Name}"
                .WithOAuthBearerToken(Settings.Default.Token)
                .PostJsonAsync(model)
                .ReceiveJson<M>();

        public async Task<M> Update(M model)
            => await $"{Settings.Default.ApiURL}/{typeof(M).Name}"
                .WithOAuthBearerToken(Settings.Default.Token)
                .PutJsonAsync(model)
                .ReceiveJson<M>();

        public async Task<bool> Delete(int id)
            => await $"{Settings.Default.ApiURL}/{typeof(M).Name}/{id}"
                .WithOAuthBearerToken(Settings.Default.Token)
                .DeleteAsync()
                .ReceiveJson<bool>();
    }
}