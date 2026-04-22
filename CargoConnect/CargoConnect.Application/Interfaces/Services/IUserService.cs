using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoConnect.Application.Interfaces.Services
{
    public interface IUserService
    {
        Task<List<UserViewDTO>> GetAllAsync();
        Task<UserViewDTO> GetByIdAsync(Guid id);
        Task<bool> CreateAsync(UserCreateDTO userCreateDto);
        Task<bool> UpdateAsync(UserUpdateDTO userUpdateDto);
        Task<bool> DeleteAsync(Guid id);
    }
}
