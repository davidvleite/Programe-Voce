using FluentValidation;
using Order.Domain.Interfaces.Repositories;
using Order.Domain.Interfaces.Services;
using Order.Domain.Models;
using Order.Domain.Validations;

namespace Order.Domain.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public Task CreateAsync(ClientModel client)
        {
            var validation = new ClientValidation();
            var result = validation.Validate(client);

            if(!result.IsValid)
            {
                foreach (var erro in result.Errors) 
                {
                    
                }
            }

            _clientRepository.CreateAsync(client);
            throw new NotImplementedException();
        }

        public Task DeleteAsync(ClientModel clientId)
        {
            throw new NotImplementedException();
        }

        public Task<ClientModel> GetByIdAsync(string clientId)
        {
            throw new NotImplementedException();
        }

        public Task<List<ClientModel>> ListByFilterAsync(ClientModel client)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(ClientModel client)
        {
            throw new NotImplementedException();
        }
    }
}
