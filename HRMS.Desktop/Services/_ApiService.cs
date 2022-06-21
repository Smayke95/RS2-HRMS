using AutoMapper;
using Flurl.Http;
using HRMS.Desktop.Interfaces;
using HRMS.Desktop.Properties;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HRMS.Desktop.Services
{
    public abstract class ApiService<M, VM> : IApiService<M, VM>
        where M : class
        where VM : class
    {
        private readonly IMapper Mapper;

        public ApiService(IMapper mapper)
        {
            Mapper = mapper;
        }

        public async Task<VM> Get(int id)
            => Mapper.Map<VM>(
                await $"{Settings.Default.ApiURL}/{typeof(M).Name}/{id}"
                    .WithOAuthBearerToken(Settings.Default.Token)
                    .GetJsonAsync<M>()
                );

        public async Task<IEnumerable<VM>> GetAll()
            => Mapper.Map<IEnumerable<VM>>(
                await $"{Settings.Default.ApiURL}/{typeof(M).Name}"
                    .WithOAuthBearerToken(Settings.Default.Token)
                    .GetJsonAsync<IEnumerable<M>>()
                );

        public async Task<VM> Insert(VM model)
            => Mapper.Map<VM>(
                await $"{Settings.Default.ApiURL}/{typeof(M).Name}"
                    .WithOAuthBearerToken(Settings.Default.Token)
                    .PostJsonAsync(model)
                    .ReceiveJson<M>()
                );

        public async Task<VM> Update(VM model)
            => Mapper.Map<VM>(
                await $"{Settings.Default.ApiURL}/{typeof(M).Name}"
                    .WithOAuthBearerToken(Settings.Default.Token)
                    .PutJsonAsync(model)
                    .ReceiveJson<M>()
                );

        public async Task<bool> Delete(int id)
            => await $"{Settings.Default.ApiURL}/{typeof(M).Name}/{id}"
                .WithOAuthBearerToken(Settings.Default.Token)
                .DeleteAsync()
                .ReceiveJson<bool>();
    }
}