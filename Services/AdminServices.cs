using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using techstore.Models;
using techstore.Repositories;

namespace techstore.Services
{
    public class AdminServices : IAdminRepository
    {
        public Task<Admin> AddAdmin(Admin admin)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CheckIfExists(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Admin> Delete(Admin admin)
        {
            throw new NotImplementedException();
        }

        public Task<Admin> GetAdminById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Admin> GetAll(string email)
        {
            throw new NotImplementedException();
        }

        public Task<Admin> Patch(Admin admin)
        {
            throw new NotImplementedException();
        }

        public Task<Admin> Update(Admin admin)
        {
            throw new NotImplementedException();
        }
    }
}