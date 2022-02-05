using API.Entities;
using API.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace API.Services
{
    public class ClientsService : Service<Clients>, IClientsService
    {
        private readonly IClientsRepository _clientsRepository;
        private readonly IServiceProvider _provider;

        public ClientsService(IServiceProvider provider) : base(provider.GetService<IClientsRepository>())
        {
            _provider = provider;
            _clientsRepository = provider.GetService<IClientsRepository>();
        }

        /// <summary>
        /// Busca uma lista de clientes registrados em banco
        /// </summary>
        /// <returns></returns>
        public List<Clients> GetAllClients()
        {
            try
            {
                var clients = this
                    .GetAll()
                    .ToList();

                Console.WriteLine(clients);

                return clients;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}