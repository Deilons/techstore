using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using techstore.Repositories;

namespace techstore.Controllers.V1.Category
{
    [ApiController]
    [Route("api/v1/category")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Tags("Category")]
    public class CategoryDELETEController : ControllerBase
    {
    private readonly ICategoryRepository _categoryRepository;
        public CategoryDELETEController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var category = await _categoryRepository.CheckIfExists(id);
            if (!category)
            {
                return NotFound();
            }

            await _categoryRepository.Delete(id);
            return NoContent();
        }
    }
}