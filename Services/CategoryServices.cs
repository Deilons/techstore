using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using techstore.DTOs;
using techstore.Models;
using techstore.Repositories;

namespace techstore.Services
{
    public class CategoryService : ICategoryServices
{
    private readonly ICategoryRepository _categoryRepository;

    public CategoryService(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    public IEnumerable<CategoryDTO> GetAllCategories()
    {
        // Lógica para obtener todas las categorías
    }

    public CategoryDTO GetCategoryById(int id)
    {
        // Lógica para obtener una categoría por ID
    }

    public CategoryDTO CreateCategory(CategoryDTO categoryDto)
    {
        // Lógica para crear una nueva categoría
    }

    public CategoryDTO UpdateCategory(int id, CategoryDTO categoryDto)
    {
        // Lógica para actualizar una categoría
    }

    public bool DeleteCategory(int id)
    {
        // Lógica para eliminar una categoría
    }
}
}