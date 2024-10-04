using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using techstore.Data;
using techstore.DTOs;
using techstore.Models;
using techstore.Services;

namespace techstore.Repositories
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetAll();
        Task<Category> GetById(int id);
        Task<Category> Add(Category category);
        Task<Category> Update(Category category);
        Task<Category> Delete(int id);
        Task<Category> Patch(int id, CategoryDTO category);
        Task<bool> CheckIfExists(int id);

    }
}