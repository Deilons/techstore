using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using techstore.DTOs;
using techstore.Models;

namespace techstore.Repositories
{
    public interface IOrderRepository
    {
        Task<IEnumerable<Order>> GetAll();

        Task<Order> GetById(int id);

        Task<Order> Add(Order order);

        Task<Order> Update(Order order);

        Task<Order> Delete(int id);

        Task<Order> Patch(int id, OrderDTO order);

        Task<bool> CheckIfExists(int id);
    }
}