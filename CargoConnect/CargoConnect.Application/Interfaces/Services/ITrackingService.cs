using CargoConnect.Application.DTOs.Tracking;
using CargoConnect.Application.DTOs.Transaction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoConnect.Application.Interfaces.Services
{
    public interface ITrackingService
    {

        Task<List<TrackingViewDTO>> GetAllAsync();

        Task<TrackingViewDTO> GetByIdAsync(Guid id);

        Task<bool> CreateAsync(TrackingCreateDTO trackingCreateDto);

        Task<bool> DeleteAsync(Guid id);

    }
}
