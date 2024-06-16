using Order.Domain.Interfaces.Services;
using Order.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Domain.Services
{
    public class OrderService : IOrderService
    {
        public Task CreateAsync(OrderModel order)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(OrderModel orderId)
        {
            throw new NotImplementedException();
        }

        public Task<OrderModel> GetByIdAsync(string orderId)
        {
            throw new NotImplementedException();
        }

        public Task<List<OrderModel>> ListByFilterAsync(string? orderId, string? clientId, string? userdId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(OrderModel order)
        {
            throw new NotImplementedException();
        }
    }
}
