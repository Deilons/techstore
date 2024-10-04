using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using techstore.DTOs;
using techstore.Models;

namespace techstore.Repositories
{
    public interface IClientRepository
    {

        Task<IEnumerable<Client>> GetAll();

        Task<Client> GetById(int id);

        Task<Client> Add(Client client);

        Task<Client> Update(Client client);

        Task<Client> Delete(int id);

        Task<Client> Patch(int id, ClientDTO client);

        Task<bool> CheckIfExists(int id);

    }
}