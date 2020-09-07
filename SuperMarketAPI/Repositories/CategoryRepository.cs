using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using SuperMarketAPI.Domain.Models;
using SuperMarketAPI.Persistence;
using Microsoft.EntityFrameworkCore;

namespace SuperMarketAPI.Repositories
{
    public class CategoryRepository : BaseRepository, ICategoryRepository
    {
        // private IList<Category> categories;
        public CategoryRepository(AppDbContext context) : base(context)
        {
            // categories = new List<Category>();

        }
        public async Task<IEnumerable<Category>> GetAllAsync(){
           return await _context.Categories.ToListAsync();
        } 
    }
}