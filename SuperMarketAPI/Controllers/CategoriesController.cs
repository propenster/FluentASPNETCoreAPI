using AutoMapper;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SuperMarketAPI.Domain.Models;
using SuperMarketAPI.Services;
using SuperMarketAPI.Resources;

namespace SuperMarketAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapping;
        public CategoriesController(ICategoryService categoryService, IMapper mapping)
        {
            _categoryService = categoryService;
            _mapping = mapping;
        }

        [HttpGet]
        public async Task<IEnumerable<CategoryResource>> GetAllAsync()
        {
            var categories = await _categoryService.GetAllAsync();
            // return CreateAtAction(nameof(GetAllAsync), categories;
            var resources = _mapping.Map<IEnumerable<Category>, IEnumerable<CategoryResource>>(categories);
            return resources;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] SaveCategoryResource resource)
        {
            // if(!ModelState.IsValid) return BadRequest(); if you were not using [ApiContoller] atttribute.
            var category = _mapping.Map<SaveCategoryResource, Category>(resource);
        }
        
    }
}