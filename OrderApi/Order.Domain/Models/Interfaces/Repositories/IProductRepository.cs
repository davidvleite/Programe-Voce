using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Domain.Models.Interfaces.Repositories
{
    public interface IProductRepository
    {
        Task CreateAsync(ProductModel client);
        Task UpdateAsync(ProductModel client);
        Task DeleteAsync(string productId);
        Task<ProductModel> GetByIdasync(string productId);
        Task<List<ProductModel>> ListByFilterAsync(string? productId, string? description);
        Task<bool> ExistByIdAsync(string productId);
    }
}
