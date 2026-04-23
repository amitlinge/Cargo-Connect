using CargoConnect.Application.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CargoConnect.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriverController : ControllerBase
    {
        private readonly IDriverService _driverService;

        public DriverController(IDriverService driverService)
        {
            _driverService = driverService;
        }

        //GET: api/drivers
        [HttpGet()]
        public async Task<IActionResult> GetAll()
        {
            var drivers = await _driverService.GetAllAsync();
            return Ok(drivers);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Details(Guid id)
        {
            var driver = await _driverService.GetByIdAsync(id);

            if (driver == null)
                return NotFound("Driver not found");

            return Ok(driver);
        }

        //PUT: api/drivers
        [Obsolete("currently unavailable",true)]
        [HttpPut]
        public async Task<IActionResult> Update(DriverUpdateDTO driverUpdatedto)
        {
            if (ModelState.IsValid)
            {
                bool status = await _driverService.UpdateAsync(driverUpdatedto);
                if (status)
                {
                    return Ok("Driver updated successfully");
                }
                return BadRequest();
            }
            return BadRequest();
        }

        //DELETE: api/drivers
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            bool status = await _driverService.DeleteAsync(id);
            if (status)
            {
                return Ok("Driver deleted successfully");
            }
            return NotFound("Driver not found");
        }
    }
}
