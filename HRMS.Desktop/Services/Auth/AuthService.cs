using Flurl.Http;
using HRMS.Desktop.Interfaces;
using HRMS.Desktop.Properties;
using HRMS.Model;
using System.Threading.Tasks;

namespace HRMS.Desktop.Services
{
    public class AuthService : IAuthService
    {
        public async Task<bool> Login(string email, string password)
        {
            var token = await $"{Settings.Default.ApiURL}/Auth/Login"
                .PostJsonAsync(new Login(email, password))
                .ReceiveJson<string>();

            if (token == "Wrong credentials!") return false;

            Settings.Default.Token = token;
            Settings.Default.Save();

            return true;
        }
    }
}