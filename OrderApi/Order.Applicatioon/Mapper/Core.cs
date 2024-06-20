using AutoMapper;
using Order.Applicatioon.DataContract.Request.Client;
using Order.Applicatioon.DataContract.Response.Client;
using Order.Domain.Models;


namespace Order.Applicatioon.Mapper
{
    public class Core : Profile
    {
        public Core()
        {
            ClientMap();
        }

        private void ClientMap()
        {
            CreateMap<CreateClientRequest, ClientModel>();
            CreateMap<ClientModel, ClientResponse>();
        }
    }
}
