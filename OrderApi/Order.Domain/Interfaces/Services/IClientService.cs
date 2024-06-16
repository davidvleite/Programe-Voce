using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Order.Domain.Models;

namespace Order.Domain.Interfaces.Services
{
    public interface IClientService
    {
        Task CreateAsync(ClientModel client);
        Task UpdateAsync(ClientModel client);
        Task DeleteAsync(ClientModel clientId);
        Task<ClientModel> GetByIdAsync(string clientId);
        Task<List<ClientModel>> ListByFilterAsync(ClientModel client);

    }

}
