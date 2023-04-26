using CaskInventory.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaskInventory.Data.Interfaces
{
    public interface IClientRepository
    {
        Task<IEnumerable<Client>> GetClients();

        Task<Client> GetClient(int ClientId);

        Task<Client> AddClient(Client client);

        Task<int> UpdateClient(Client client);

        Task<int> DeleteClient(int ClientId);
    }
}
