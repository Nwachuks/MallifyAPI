using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Mallify.API.Models;
using Mallify.API.Resources;
using Mallify.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace Mallify.API.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class CategoriesController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoriesController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<CategoryResource>> GetAllCategoriesAsync()
        {
            var categories = await _categoryService.ListAsync();
            var resources = _mapper.Map<IEnumerable<Category>, IEnumerable<CategoryResource>>(categories);

            return resources;
        }
    }
}
