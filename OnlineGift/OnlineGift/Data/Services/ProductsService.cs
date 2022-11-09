using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineGift.Data.Base;
using OnlineGift.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGift.Data.Services
{
    public class ProductsService : IProductsService
    {
        private readonly AppDbContext _context;
        public ProductsService(AppDbContext context)
        {
            _context = context;
        }
        public  async Task AddAsync(Product product)
        {
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            var result =await  _context.Products.ToListAsync();
            return result;
        }

        public async Task<Product> GetByIdAsync(int id)
        { 
            var r = await _context.Products.FirstOrDefaultAsync(n => n.Id == id);
            return r;
        }
        public async Task UpdateProductAsync(Product data)
        {
            var dbProduct = await _context.Products.FirstOrDefaultAsync(n => n.Id == data.Id);
            if (dbProduct != null)
            {
                dbProduct.Name = data.Name;
                dbProduct.Desc = data.Desc;
                dbProduct.Prize = data.Prize;
                dbProduct.ImgUrl = data.ImgUrl;
                await _context.SaveChangesAsync();
            }
        }
        public async Task Delete(int id)
        {
            var r = await _context.Products.FirstOrDefaultAsync(n => n.Id == id);
            _context.Products.Remove(r);
            await _context.SaveChangesAsync();

        } 
    }
}
