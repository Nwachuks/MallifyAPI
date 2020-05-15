using System.Collections.Generic;
using System.Threading.Tasks;
using Mallify.API.Models;
using Mallify.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace Mallify.API.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class CategoriesController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IEnumerable<Category>> GetAllCategoriesAsync()
        {
            var categories = await _categoryService.ListAsync();
            return categories;
        }
    }
}
