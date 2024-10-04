using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using techstore.DTOs;
using techstore.Models;
using techstore.Repositories;

namespace techstore.Controllers.V1.Category
{
    [ApiController]
    [Route("api/v1/category")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Tags("Category")]
    public class CategoryPOSTController : CategoryController
    {
        public CategoryPOSTController(ICategoryRepository categoryRepository) : base(categoryRepository)
        {
        }
        [HttpPost]
        public async Task<IActionResult> CreateCategory([FromBody] CategoryDTO categoryDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var newCategory = new techstore.Models.Category
            {
                Name = categoryDto.Name,
                Description = categoryDto.Description,
                Products = categoryDto.ProductIds.Select(id => new techstore.Models.Product { Id = id }).ToList()
            };


            var createdCategory = await services.Add(newCategory);

            return CreatedAtAction("GetById", "CategoryGET", new { id = createdCategory.Id }, createdCategory);
        }
    }
}