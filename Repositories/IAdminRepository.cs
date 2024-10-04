using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using techstore.Models;

namespace techstore.Repositories
{
    public interface IAdminRepository
    {
        Task<Admin> GetAll(string email);

        Task<Admin> AddAdmin(Admin admin);

        Task<Admin> Update(Admin admin);

        Task<Admin> Delete(Admin admin);

        Task<Admin> Patch(Admin admin);

        Task<Admin> GetAdminById(int id);

        Task<bool> CheckIfExists(int id);
    }
}