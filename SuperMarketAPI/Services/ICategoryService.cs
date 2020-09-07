using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SuperMarketAPI.Domain.Models;

namespace SuperMarketAPI.Services
{
    public interface ICategoryService
    {
         Task<IEnumerable<Category>> GetAllAsync();
    }
}




