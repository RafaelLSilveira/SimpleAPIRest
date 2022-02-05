using API.Entities;
using API.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace API.Data
{
    public class ClientsRepository : Repository<DataContext, Clients>, IClientsRepository
    {
        public ClientsRepository(DataContext context) : base(context)
        {
            
        }

        // public override IEnumerable<Clients> GetAll()
        // {
        //     return _db.Clients
        //         .FromSql("SELECT * FROM clients;")
        //         .ToList();
        // }
    }
}