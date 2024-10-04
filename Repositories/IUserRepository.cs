using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using techstore.DTOs;
using techstore.Models;

namespace techstore.Repositories
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAll();
        Task<User> GetById(int id);
        Task<User> Add(User Users);
        Task<User> Update(User Users);
        Task<User> Delete(int id);
        Task<User> Patch(int id, UserDTO Users);
        Task<bool> CheckIfExists(int id);

    }
}