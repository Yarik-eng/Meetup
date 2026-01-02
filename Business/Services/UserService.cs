using System;
using System.Collections.Generic;
using Core.DTOs;
using Core.Entities;
using Core.Interfaces.Repositories;

namespace Business.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User GetUser(int id)
        {
            var user = _userRepository.GetById(id);
            if (user == null)
            {
                throw new Exception($"User with id {id} not found");
            }

            return user;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _userRepository.GetAll();
        }

        public User CreateUser(CreateUserDto userDto)
        {
            var user = new User
            {
                FirstName = userDto.FirstName,
                LastName = userDto.LastName,
                Email = userDto.Email,
                CreatedAt = DateTime.Now
            };

            return _userRepository.Add(user);
        }

        public void UpdateUser(int id, UpdateUserDto userDto)
        {
            var existingUser = _userRepository.GetById(id);
            if (existingUser == null)
            {
                throw new Exception($"User with id {id} not found");
            }

            existingUser.FirstName = userDto.FirstName;
            existingUser.LastName = userDto.LastName;
            existingUser.Email = userDto.Email;

            _userRepository.Update(existingUser);
        }

        public void DeleteUser(int id)
        {
            var existingUser = _userRepository.GetById(id);
            if (existingUser == null)
            {
                throw new Exception($"User with id {id} not found");
            }

            _userRepository.Delete(id);
        }
    }
}
