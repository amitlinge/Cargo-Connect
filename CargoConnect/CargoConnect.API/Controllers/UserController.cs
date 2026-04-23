using CargoConnect.Application.Interfaces.Repositories;
using CargoConnect.Application.Interfaces.Services;
using CargoConnect.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CargoConnect.API.Controllers
{
    [ApiController]
    [Route("Api/[controller]")]
    public class UserController : ControllerBase
    {
        IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("Get-All-Users")]
        public async Task<IActionResult> GetAllAsync()
        {
            var users = await _userService.GetAllAsync();
            if (users != null)
                return Ok(User);

            return NotFound();
        }

        [HttpGet("Get-User-{id}")]
        public async Task<IActionResult> GetByIdAsync([FromRoute]Guid id)
        {
            var user = await _userService.GetByIdAsync(id);

            if (user != null)
                return Ok(user);

            return NotFound();
        }

        [HttpDelete("Delete-user-{id}")]
        public async Task<IActionResult> DeleteAsync([FromRoute] Guid id)
        {
            bool status = await _userService.DeleteAsync(id);

            if (status)
                return Ok();

            return NotFound();
        }
    }
}
