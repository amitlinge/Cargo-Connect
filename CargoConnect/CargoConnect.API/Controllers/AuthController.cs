using CargoConnect.Application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace CargoConnect.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        // POST: api/auth/register/user
        [HttpPost("register/user")]
        public async Task<IActionResult> RegisterUser(UserCreateDTO dto)
        {
            var result = await _authService.RegisterUser(dto);

            if (result == null)
                return BadRequest("User registration failed");

            return Ok(result); // or return token later
        }

        // POST: api/auth/register/driver
        [HttpPost("register/driver")]
        public async Task<IActionResult> RegisterDriver(DriverCreateDTO dto)
        {
            var result = await _authService.RegisterDriver(dto);

            if (result == null)
                return BadRequest("Driver registration failed");

            return Ok(result);
        }
    }
}