using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CargoConnect.Application.DTOs.Booking;

namespace CargoConnect.Application.Interfaces.Services
{
    public interface IBookingService
    {
        Task<List<BookingViewDTO>> GetAllAsync();
        Task<BookingViewDTO> GetByIdAsync(Guid id);

        Task<bool> CreateAsync(BookingCreateDTO bookingCreateDto);
        Task<bool> UpdateAsync(BookingUpdateDTO bookingUpdateDto);
        Task<bool> DeleteAsync(Guid id);
    }
}
