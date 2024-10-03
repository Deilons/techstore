using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using techstore.Data;
using techstore.Models;
using techstore.Services;

namespace techstore.Repositories
{
    public class CategoryRepository
{
    private readonly ApplicationDbContext _context;

    public CategoryRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public IEnumerable<Category> GetAll()
    {
        return _context.Categortes.ToList();
    }

    public Category GetById(int id)
    {
        return _context.Categories.Find(id);
    }

    public Category Add(Category category)
    {
        _context.Categories.Add(category);
        _context.SaveChanges();
        return category;
    }

    public Category Update(Category category)
    {
        _context.Categories.Update(category);
        _context.SaveChanges();
        return category;
    }

    public bool Delete(int id)
    {
        var category = GetById(id);
        if (category == null) return false;

        _context.Categories.Remove(category);
        _context.SaveChanges();
        return true;
    }
}
}