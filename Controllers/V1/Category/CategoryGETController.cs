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
    public class CategoryGETController : CategoryController
    {
        public CategoryGETController(ICategoryRepository categoryRepository) : base(categoryRepository)
        {
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var categories = await services.GetAll();
            return Ok(categories);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var category = await services.GetById(id);
            return Ok(category);
        }
    }
}