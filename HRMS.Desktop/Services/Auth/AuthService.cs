using Flurl.Http;
using HRMS.Desktop.Interfaces;
using HRMS.Desktop.Properties;
using HRMS.Model;
using System.Threading.Tasks;

namespace HRMS.Desktop.Services
{
    public class AuthService : IAuthService
    {
        public async Task Login(string email, string password)
        {
            Settings.Default.Token = await $"{Settings.Default.ApiURL}/Auth/Login".PostJsonAsync(new Login(email, password)).ReceiveJson<string>();
            Settings.Default.Save();
        }
    }
}