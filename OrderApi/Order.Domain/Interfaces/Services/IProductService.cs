using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Order.Domain.Models;

namespace Order.Domain.Interfaces.Services
{
    public interface IProductService
    {
        Task CreateAsync(ProductModel product);
        Task UpdateAsync(ProductModel product);
        Task DeleteAsync(string productId);
        Task<ProductModel> GetByIdasync(string productId);
        Task<List<ProductModel>> ListByFilterAsync(string? productId, string? description);
        Task<bool> ExistByIdAsync(string productId);
    }
}
