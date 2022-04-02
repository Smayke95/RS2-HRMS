using System.Threading.Tasks;

namespace HRMS.Desktop.Interfaces
{
    public interface IAuthService
    {
        Task<bool> Login(string email, string password);
    }
}
