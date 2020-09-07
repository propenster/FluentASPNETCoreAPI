using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SuperMarketAPI.Domain.Models;

namespace SuperMarketAPI.Repositories
{
    public interface ICategoryRepository
    {
         Task<IEnumerable<Category>> GetAllAsync();
         

    }
}