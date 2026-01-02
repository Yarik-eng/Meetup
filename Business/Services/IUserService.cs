using System.Collections.Generic;
using Core.DTOs;
using Core.Entities;

namespace Business.Services
{
    public interface IUserService
    {
        User GetUser(int id);
        IEnumerable<User> GetAllUsers();
        User CreateUser(CreateUserDto createUserDto);
        void UpdateUser(int id, UpdateUserDto userDto);
        void DeleteUser(int id);
    }
}