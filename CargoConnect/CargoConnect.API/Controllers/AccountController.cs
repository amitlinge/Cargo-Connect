using CargoConnect.Application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace CargoConnect.API.Controllers
{
    [ApiController]
    [Route("Api/[controller]")]
    public class AccountController : ControllerBase
    {
        IUserService _userService;
        IDriverService _driverService;
        public AccountController(IUserService userService, IDriverService driverService)
        {
            _userService = userService;
            _driverService = driverService;
        }

        [HttpPost("Register-User")]
        public async Task<IActionResult> RegisterUser(UserCreateDTO userCreateDto)
        {
            if(ModelState.IsValid)
            {
                bool status = await _userService.CreateAsync(userCreateDto);
                if (status)
                {
                    return Created("",userCreateDto);
                }
                return BadRequest();
            }
            return BadRequest();
        }

        [HttpPost("Register-Driver")]
        public async Task<IActionResult> RegisterDriver(DriverCreateDTO driverCreateDto)
        {
            if (ModelState.IsValid)
            {
                bool status = await _driverService.CreateAsync(driverCreateDto);
                if (status)
                {
                    return Created("", driverCreateDto);
                }
                return BadRequest();
            }
            return BadRequest();
        }
    }
}
