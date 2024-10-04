using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using techstore.DTOs;
using techstore.Repositories;

namespace techstore.Controllers.V1.Category
{
    [ApiController]
    [Route("api/v1/category")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Tags("Category")]
    public class CategoryPATCHControllerr : CategoryController
    {
        public CategoryPATCHControllerr(ICategoryRepository categoryRepository) : base(categoryRepository)
        {
        }

        [HttpPatch("{id}")]
        public async Task<IActionResult> PatchCategory(int id, [FromBody] CategoryDTO categoryDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var updatedCategory = await services.Patch(id, categoryDto);

            if (updatedCategory == null)
            {
                return NotFound();
            }

            return Ok(updatedCategory);
        }

    }
}