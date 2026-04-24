using CargoConnect.Application.DTOs.Tracking;
using CargoConnect.Application.Interfaces;
using CargoConnect.Application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace CargoConnect.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TrackingController : ControllerBase
    {
        private readonly ITrackingService _trackingService;

        public TrackingController(ITrackingService trackingService)
        {
            _trackingService = trackingService;
        }

        // GET: api/tracking
        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var trackingList = await _trackingService.GetAllAsync();
            return Ok(trackingList);
        }

        // GET: api/tracking/{id}
        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetByIdAsync(Guid id)
        {
            var tracking = await _trackingService.GetByIdAsync(id);

            if (tracking == null)
                return NotFound();

            return Ok(tracking);
        }

        // PUT: api/tracking
        [HttpPut]
        public async Task<IActionResult> UpdateAsync([FromBody] TrackingUpdateDTO dto)
        {
            if (dto == null)
                return BadRequest();

            var isUpdated = await _trackingService.UpdateAsync(dto);

            if (!isUpdated)
                return NotFound();

            return NoContent();
        }

        // DELETE: api/tracking/{id}
        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            var isDeleted = await _trackingService.DeleteAsync(id);

            if (!isDeleted)
                return NotFound();

            return NoContent();
        }
    }
}