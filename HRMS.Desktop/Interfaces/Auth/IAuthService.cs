using System.Threading.Tasks;

namespace HRMS.Desktop.Interfaces
{
    public interface IAuthService
    {
        Task Login(string email, string password);
    }
}
