using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Order.Domain.Models;

namespace Order.Domain.Interfaces.Services
{
    internal interface IOrderService
    {
        Task CreateAsync(OrderModel order);
        Task UpdateAsync(OrderModel order);
        Task DeleteAsync(OrderModel orderId);
        Task<OrderModel> GetByIdAsync(string orderId);
        Task<List<OrderModel>> ListByFilterAsync(string? orderId, string? clientId, string? userdId);
    }
}
