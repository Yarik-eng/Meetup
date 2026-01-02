using System.Collections.Generic;
using Core.Entities;

namespace Core.Interfaces.Repositories
{
    public interface IUserRepository
    {
        User GetById(int id);
        IEnumerable<User> GetAll();
        User Add(User user);
        void Update(User user);
        void Delete(int id);
    }
}

// визначає інтерфейс репозиторію користувачів з методами для отримання, додававання, оновлення та видалення користувачів.