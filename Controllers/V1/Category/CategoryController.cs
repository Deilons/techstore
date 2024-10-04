using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using techstore.Data;
using techstore.DTOs;

namespace techstore.Controllers.V1.Category
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CategoryController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var categories = await _context.Categories.ToListAsync();
            return Ok(categories);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var category = await _context.Categories.FirstOrDefaultAsync(x => x.Id == id);
            return Ok(category);
        }

        [HttpPost]
        public async Task<IActionResult> Post(CategoryDTO category)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Add(category);
            await _context.SaveChangesAsync();
            return Ok(category);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, CategoryDTO category)
        {
            if (id != category.Id)
            {
                return BadRequest();
            }

            _context.Update(category);
            await _context.SaveChangesAsync();
            return Ok(category);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var category = await _context.Categories.FirstOrDefaultAsync(x => x.Id == id);
            if (category == null)
            {
                return NotFound();
            }
            else
            {
                _context.Categories.Remove(category);
                await _context.SaveChangesAsync();
                return Ok(category);
            }
        }

        [HttpPatch("{id}")]

        public async Task<IActionResult> Patch(int id, CategoryDTO category)
        {
            _context.Update(category);
            await _context.SaveChangesAsync();
            return Ok(category);
        }
    }
}