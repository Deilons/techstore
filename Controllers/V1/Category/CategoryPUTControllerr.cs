using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using techstore.Repositories;
using techstore.DTOs;

namespace techstore.Controllers.V1.Category
{
    [ApiController]
    [Route("api/v1/category")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Tags("Category")]
    public class CategoryPUTControllerr : CategoryController
    {
        public CategoryPUTControllerr(ICategoryRepository categoryRepository) : base(categoryRepository)
        {
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCategory(int id, [FromBody] CategoryDTO categoryDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var categoryExists = await services.CheckIfExists(id);
            if (!categoryExists)
            {
                return NotFound();
            }

            var updatedCategory = new techstore.Models.Category
            {
                Id = id,
                Name = categoryDto.Name,
                Description = categoryDto.Description,
                Products = categoryDto.ProductIds.Select(productId => new techstore.Models.Product { Id = productId }).ToList()
            };

            await services.Update(updatedCategory);

            return NoContent();

        }
    }
}