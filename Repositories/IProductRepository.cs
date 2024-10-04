using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using techstore.DTOs;
using techstore.Models;

namespace techstore.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAll();

        Task<Product> GetById(int id);

        Task add(Product product);

        Task Update(Product product);

        Task Delete(int id);

        Task Patch(int id, ProductDTO product);

        Task<bool> CheckIfExists(int id);



    }
}