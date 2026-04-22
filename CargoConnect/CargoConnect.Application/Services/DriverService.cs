using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CargoConnect.Application.Interfaces.ExternalServices;
using CargoConnect.Application.Interfaces.Repositories;
using CargoConnect.Application.Interfaces.Services;
using CargoConnect.Domain.Entities;

namespace CargoConnect.Application.Services
{
    public class DriverService : IDriverService
    {
        IGenericRepository<DriverEntity> _driverRepository;
        IMappingService _mapper;

        public DriverService(IGenericRepository<DriverEntity> driverRepository, IMappingService mapper)
        {
            _driverRepository = driverRepository;
            _mapper = mapper;
        }

        public async Task<bool> CreateAsync(DriverCreateDTO driverCreateDto)
        {
            bool status = await _driverRepository.CreateAsync(_mapper.Map<DriverCreateDTO, DriverEntity>(driverCreateDto));
            return status;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            bool status = await _driverRepository.DeleteAsync(id);
            return status;
        }

        public async Task<List<DriverViewDTO>> GetAllAsync()
        {
            var drivers = _mapper.MapList<DriverEntity, DriverViewDTO>(await _driverRepository.GetAllAsync());
            return drivers;
        }

        public async Task<DriverViewDTO> GetByIdAsync(Guid id)
        {
            var driver = _mapper.Map<DriverEntity, DriverViewDTO>(await _driverRepository.GetByIdAsync(id));
            return driver;
        }

        public async Task<bool> UpdateAsync(DriverUpdateDTO driverUpdateDto)
        {
            bool status = await _driverRepository.UpdateAsync(_mapper.Map<DriverUpdateDTO, DriverEntity>(driverUpdateDto));
            return status;
        }
    }
}
