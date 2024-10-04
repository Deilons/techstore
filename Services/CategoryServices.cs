using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using techstore.Data;
using techstore.DTOs;
using techstore.Models;
using techstore.Repositories;

namespace techstore.Services
{
    public class CategoryService : ICategoryRepository
    {
        private readonly ApplicationDbContext _context;

        public CategoryService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Category> Add(Category category)
        {
            if (category == null)
            {
                throw new ArgumentNullException(nameof(category), "Category cannot be null");
            }
            try
            {
                await _context.Categories.AddAsync(category);
                await _context.SaveChangesAsync();
                return category;
            }
            catch (DbUpdateException e)
            {
                throw new DbUpdateException("Error occurred while adding category", e);
            }
            catch (Exception ex)
            {
                throw new Exception("Error occurred while adding category", ex);
            }
        }

        public async Task<bool> CheckIfExists(int id)
        {
            try
            {
                return await _context.Categories.AnyAsync(x => x.Id == id);
            }
            catch (DbUpdateException e)
            {
                throw new DbUpdateException("Error occurred while checking if category exists", e);
            }
            catch (Exception ex)
            {
                throw new Exception("Error occurred while checking if category exists", ex);
            }
        }

        public async Task<Category> Delete(int id)
        {
            var category = await _context.Categories.FirstOrDefaultAsync(x => x.Id == id);
            if (category == null)
            {
                return null;
            }
            try
            {
                _context.Categories.Remove(category);
                await _context.SaveChangesAsync();
                return category;
            }
            catch (DbUpdateException e)
            {
                throw new DbUpdateException("Error occurred while deleting category", e);
            }
            catch (Exception ex)
            {
                throw new Exception("Error occurred while deleting category", ex);
            }
        }

        public async Task<IEnumerable<Category>> GetAll()
        {
            return await _context.Categories.ToListAsync();
        }

        public async Task<Category> GetById(int id)
        {
            return await _context.Categories.FindAsync(id);
        }

        public async Task<Category> Patch(int id, CategoryDTO categoryDto)
        {
            var category = await _context.Categories.FindAsync(id);
            if (category == null)
            {
                return null;
            }

            if (!string.IsNullOrEmpty(categoryDto.Name))
            {
                category.Name = categoryDto.Name;
            }

            if (!string.IsNullOrEmpty(categoryDto.Description))
            {
                category.Description = categoryDto.Description;
            }

            if (categoryDto.ProductIds != null)
            {
                category.Products = categoryDto.ProductIds.Select(productId => new Product { Id = productId }).ToList();
            }

            await _context.SaveChangesAsync();

            return category; 
        }

        public async Task<Category> Update(Category category)
        {
            if (category == null)
            {
                throw new ArgumentNullException(nameof(category), "Category cannot be null");
            }
            try
            {
                _context.Categories.Update(category);
                await _context.SaveChangesAsync();
                return category;
            }
            catch (DbUpdateException e)
            {
                throw new DbUpdateException("Error occurred while updating category", e);
            }
            catch (Exception ex)
            {
                throw new Exception("Error occurred while updating category", ex);
            }
        }
    }
}