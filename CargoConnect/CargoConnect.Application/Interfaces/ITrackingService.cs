using CargoConnect.Application.DTOs.Tracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoConnect.Application.Interfaces
{
    public interface ITrackingService
    {
        Task<List<TrackingViewDTO>> GetAllAsync();
        Task<TrackingViewDTO> GetByIdAsync(Guid id);
        Task<bool> UpdateAsync(TrackingUpdateDTO trackingUpdateDto);
        Task<bool> DeleteAsync(Guid id);


    }
}
