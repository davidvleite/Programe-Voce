using Order.Applicatioon.DataContract.Request.Client;
using Order.Domain.Validations.Base;

namespace Order.Applicatioon.Interfaces
{
    public interface IClientAplication
    {
      Task<Response> CreateAsync(CreateClientRequest client);

    }
}
