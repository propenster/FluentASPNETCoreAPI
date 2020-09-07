using System.Collections.Generic;
using System.Threading.Tasks;
using SuperMarketAPI.Domain.Models;
using SuperMarketAPI.Repositories;

namespace SuperMarketAPI.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository =  categoryRepository;
        }
        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            return await _categoryRepository.GetAllAsync();  
             
        }
    }
}