using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Order.Domain.Models;

namespace Order.Domain.Interfaces.Services
{
    public interface IUserService
    {
        Task CreateAsync(UserModel user);
        Task UpdateAsync(UserModel user);
        Task DeleteAsync(string userId);
        Task<bool> AuthenticationAsync(UserModel user);
        Task<UserModel> GetByIdasync(string userId);
        Task<List<UserModel>> ListByFilterAsync(string? userId, string? name);

    }
}
