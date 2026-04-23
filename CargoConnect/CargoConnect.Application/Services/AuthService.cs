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
    public class AuthService : IAuthService
    {
        IGenericRepository<DriverEntity> _driverRepository;
        IGenericRepository<UserEntity> _userRepository;
        IMappingService _mapper;
        IPasswordService _passwordService;

        public AuthService(IGenericRepository<DriverEntity> driverRepository, IGenericRepository<UserEntity> userRepository, IMappingService mapper, IPasswordService passwordService)
        {
            _driverRepository = driverRepository;
            _userRepository = userRepository;
            _mapper = mapper;
            _passwordService = passwordService;
        }

        public async Task<bool> RegisterDriver(DriverCreateDTO driverCreateDTO)
        {
            // hashing password
            driverCreateDTO.Password = _passwordService.HashPassword(driverCreateDTO.Email, driverCreateDTO.Password);
            
            bool status = await _driverRepository.CreateAsync(_mapper.Map<DriverCreateDTO, DriverEntity>(driverCreateDTO));
            return status;
        }

        public async Task<bool> RegisterUser(UserCreateDTO userCreateDTO)
        {
            // hashing password  
            userCreateDTO.Password = _passwordService.HashPassword(userCreateDTO.Email,userCreateDTO.Password);


            bool status = await _userRepository.CreateAsync(_mapper.Map<UserCreateDTO, UserEntity>(userCreateDTO));
            return status;
        }
    }
}
