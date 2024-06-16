using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Domain.Models.Interfaces.Repositories
{
    public interface IOrderRepository
    {
        Task CreateAsync(OrderModel order);
        Task CreateItemAsync(OrderItemModel item);
        Task UpdateAsync(OrderModel order);
        Task UpdateItemAsync(OrderItemModel item);
        Task DeleteAsync(string orderId);
        Task DeleteItemAsync(string itemId);

        Task<OrderModel> GetByIdAsync(string orderId);
        Task<List<OrderModel>> ListByFilterAsync(string? orderId, string? clientId, string? userId);
        Task<List<OrderItemModel>> ListByFilterAsync(string? orderId);
        Task<bool> ExistByIdAsync(string orderId);
    }
}
