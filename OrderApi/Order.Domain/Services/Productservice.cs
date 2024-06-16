using Order.Domain.Interfaces.Services;
using Order.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Domain.Services
{
    public class Productservice : IProductService
    {
        public Task CreateAsync(ProductModel product)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(string productId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistByIdAsync(string productId)
        {
            throw new NotImplementedException();
        }

        public Task<ProductModel> GetByIdasync(string productId)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProductModel>> ListByFilterAsync(string? productId, string? description)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(ProductModel product)
        {
            throw new NotImplementedException();
        }
    }
}
