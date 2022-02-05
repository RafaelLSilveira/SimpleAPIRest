using API.Entities;
using System.Collections.Generic;

namespace API.Interfaces
{
    public interface IClientsService : IService<Clients>
    {
        /// <summary>
        /// Busca uma lista de clientes registrados em banco
        /// </summary>
        /// <returns></returns>
        List<Clients> GetAllClients();
    }
}