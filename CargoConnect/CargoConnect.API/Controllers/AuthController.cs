using CargoConnect.Application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace CargoConnect.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IDriverService _driverService;

        public AuthController(IUserService userService, IDriverService driverService)
        {
            _userService = userService;
            _driverService = driverService;
        }

        // POST: api/auth/register/user
        [HttpPost("register/user")]
        public async Task<IActionResult> RegisterUser(UserCreateDTO dto)
        {
            var result = await _userService.CreateAsync(dto);

            if (result == null)
                return BadRequest("User registration failed");

            return Ok(result); // or return token later
        }

        // POST: api/auth/register/driver
        [HttpPost("register/driver")]
        public async Task<IActionResult> RegisterDriver(DriverCreateDTO dto)
        {
            var result = await _driverService.CreateAsync(dto);

            if (result == null)
                return BadRequest("Driver registration failed");

            return Ok(result);
        }
    }
}