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
    public class CategoryDELETEController : CategoryController
    {
        public CategoryDELETEController(ICategoryRepository categoryRepository) : base(categoryRepository)
        {
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var category = await services.CheckIfExists(id);
            if (!category)
            {
                return NotFound();
            }

            await services.Delete(id);
            return NoContent();
        }
    }
}