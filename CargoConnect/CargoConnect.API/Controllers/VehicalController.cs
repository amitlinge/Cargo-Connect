using CargoConnect.Application.DTOs.Vehical;
using CargoConnect.Application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace CargoConnect.API.Controllers
{
    [ApiController]
    [Route("Api/[controller]")]
    public class VehicalController : ControllerBase
    {
        private readonly IVehicalService _vehicalsService;

        public VehicalController(IVehicalService vehicalsService)
        {
            _vehicalsService = vehicalsService;
        }

        // GET: api/vehicals
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var vehicals = await _vehicalsService.GetAllAsync();
            if(vehicals != null)
            {
                return Ok(vehicals);
            }
            return NotFound();
        }

        // GET: api/vehicals/{id}
        [HttpGet("{id:Guid}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            var vehical = await _vehicalsService.GetByIdAsync(id);
            if (vehical != null)
            {
                return Ok(vehical);
            }
            return NotFound();
        }

        //POST: api/vehicals
        [HttpPost()]
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

        //DELETE: api/vehicals
        [HttpDelete("{id:Guid}")]
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
