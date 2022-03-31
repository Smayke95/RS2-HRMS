using HRMS.Interfaces;
using HRMS.Model;
using Microsoft.AspNetCore.Mvc;

namespace HRMS.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService AuthService;

        public AuthController(IAuthService authService)
        {
            AuthService = authService;
        }

        [HttpPost]
        [Consumes("application/json")]
        [Produces("application/json")]
        public string Login([FromBody] Login login)
        {
            return AuthService.Login(login);
        }
    }
}