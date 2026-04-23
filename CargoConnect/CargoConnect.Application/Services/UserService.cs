using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CargoConnect.Application.Interfaces.ExternalServices;
using CargoConnect.Application.Interfaces.Repositories;
using CargoConnect.Application.Interfaces.Services;
using CargoConnect.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CargoConnect.Application.Services
{
    public class UserService : IUserService
    {
        IMappingService _mapper;
        IGenericRepository<UserEntity> _userRepository;

        public UserService(IMappingService mapper, IGenericRepository<UserEntity> userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            bool status = await _userRepository.DeleteAsync(id);
            return status;
        }

        public async Task<List<UserViewDTO>> GetAllAsync()
        {
            var users = _mapper.MapList<UserEntity,UserViewDTO>(await _userRepository.GetAllAsync());
            return users;
        }

        public async Task<UserViewDTO> GetByIdAsync(Guid id)
        {
            var user = _mapper.Map<UserEntity, UserViewDTO>(await _userRepository.GetByIdAsync(id));
            return user;
        }

        public async Task<bool> UpdateAsync(UserUpdateDTO userUpdateDto)
        {
            bool status = await _userRepository.UpdateAsync(_mapper.Map<UserUpdateDTO, UserEntity>(userUpdateDto));
            return status;
        }
    }
}
