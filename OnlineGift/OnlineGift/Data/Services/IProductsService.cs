using OnlineGift.Data.Base;
using OnlineGift.Models;
using OnlineGift.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGift.Data.Services
{
    public interface IProductsService
    {
        Task<IEnumerable<Product>> GetAllAsync();
        Task<Product> GetByIdAsync(int id);
        Task AddAsync(Product product);
        Task UpdateProductAsync(Product product);
        Task Delete(int id);
    }
}
