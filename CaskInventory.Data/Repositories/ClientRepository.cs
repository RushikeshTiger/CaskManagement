using CaskInventory.Data.Interfaces;
using CaskInventory.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaskInventory.Data.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly CaskdbContext _dbContext;

        public ClientRepository(CaskdbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Client> AddClient(Client client)
        {
            var result = _dbContext.Clients.Add(client);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<int> DeleteClient(int ClientId)
        {
            var filteredData = _dbContext.Clients.Where(x => x.ClientId == ClientId).FirstOrDefault();
            _dbContext.Clients.Remove(filteredData);
            return await _dbContext.SaveChangesAsync();
        }

        public async Task<Client> GetClient(int ClientId)
        {
            return await _dbContext.Clients.Where(x => x.ClientId == ClientId).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Client>> GetClients()
        {
            return (IEnumerable<Client>)await _dbContext.Clients.ToListAsync();
        }

        public async Task<int> UpdateClient(Client client)
        {
            _dbContext.Clients.Update(client);
            return await _dbContext.SaveChangesAsync();
        }
    }
}
