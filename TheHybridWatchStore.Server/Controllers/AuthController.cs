using Microsoft.AspNetCore.Mvc;
using TheHybridWatchStore.Server.Data.Models;
using TheHybridWatchStore.Server.Services;

namespace TheHybridWatchStore.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : Controller
    {
        private readonly AuthService _authService;

        public AuthController(AuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("register")]
        public IActionResult Register([FromBody] RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var user = _authService.Register(model.Email, model.Password);
            if (user == null)
            {
                return BadRequest("User already exists.");
            }

            return Ok(new { user.Email });
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var user = _authService.Authenticate(model.Email, model.Password);
            if (user == null)
            {
                return Unauthorized();
            }

            return Ok(new { user.Email });
        }
    }
}
