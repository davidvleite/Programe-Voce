using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Order.Domain.Models;

namespace Order.Domain.Interfaces.Repositories
{
    public interface IClientRepository
    {
        Task CreateAsync(ClientModel client);
        Task UpdateAsync(ClientModel client);
        Task DeleteAsync(string clientId);
        Task<bool> ExisById(string clientId);
        Task<ClientModel> GetByIdasync(string clientId);
        Task<List<ClientModel>> ListByFilterAsync(string? clientId, string? name);

    }
}
