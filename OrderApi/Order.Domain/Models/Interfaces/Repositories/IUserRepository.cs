using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Domain.Models.Interfaces.Repositories
{
    public interface IUserRepository
    {
        Task CreateAsync(UserModel user);
        Task UpdateAsync(UserModel user);
        Task DeleteAsync(string userId);
        Task<UserModel> GetByIdasync(string userId);
        Task<List<UserModel>> ListByFilterAsync(string? userId, string? name);
        Task<bool> ExistByIdAsync(string userId);
        Task<bool> ExistByLoginAsync(string login);
    }
}
