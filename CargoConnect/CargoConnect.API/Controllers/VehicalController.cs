using CargoConnect.Application.DTOs.Vehical;
using CargoConnect.Application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace CargoConnect.API.Controllers
{
    [ApiController]
    [Route("Api/[controller]")]
    public class VehicalController : ControllerBase
    {
        IVehicalService _vehicalsService;

        public VehicalController(IVehicalService vehicalsService)
        {
            _vehicalsService = vehicalsService;
        }

        [HttpGet("Get-Vehicals")]
        public async Task<IActionResult> Index()
        {
            var vehicals = await _vehicalsService.GetAllAsync();
            if(vehicals != null)
            {
                return Ok(vehicals);
            }
            return NotFound();
        }

        [HttpGet("Get-Vehical-{id}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            var vehical = await _vehicalsService.GetByIdAsync(id);
            if (vehical != null)
            {
                return Ok(vehical);
            }
            return NotFound();
        }

        [HttpPost("Add-Vehical")]
        public async Task<IActionResult> CreateVehical([FromBody] VehicalCreateDTO vehicalCreateDTO)
        {
            if(ModelState.IsValid)
            {
                bool status = await _vehicalsService.CreateAsync(vehicalCreateDTO);
                if (status)
                {
                    return Created("", vehicalCreateDTO);
                }
                return BadRequest();
            }
            return BadRequest();
        }

        [HttpDelete("Delete-vehical-details-{id}")]
        public async Task<IActionResult> DeleteVehical([FromRoute] Guid id)
        {
            bool status = await _vehicalsService.DeleteAsync(id);
            if (status)
            {
                return Ok();
            }
            return BadRequest();
        }
    }
}
