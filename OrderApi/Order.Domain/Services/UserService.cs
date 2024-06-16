using Order.Domain.Interfaces.Services;
using Order.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Domain.Services
{
    public class UserService : IUserService
    {
        public Task<bool> AuthenticationAsync(UserModel user)
        {
            throw new NotImplementedException();
        }

        public Task CreateAsync(UserModel user)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<UserModel> GetByIdasync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserModel>> ListByFilterAsync(string? userId, string? name)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(UserModel user)
        {
            throw new NotImplementedException();
        }
    }
}
