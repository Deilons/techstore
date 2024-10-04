using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using techstore.Data;
using techstore.DTOs;
using techstore.Repositories;

namespace techstore.Controllers.V1.Category
{
    [ApiController]
    [Route("api/v1/category")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Tags("Category")]
    public class CategoryController : ControllerBase
    {
        protected readonly  ICategoryRepository services;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            services = categoryRepository;
        }
    }
}