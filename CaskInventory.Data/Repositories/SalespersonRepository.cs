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
    public class SalespersonRepository : ISalespersonRepository
    {
        private readonly CaskdbContext _dbContext;

        public SalespersonRepository(CaskdbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Salesperson> AddSalesperson(Salesperson salesperson)
        {
            var result = _dbContext.Salespeople.Add(salesperson);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Salesperson> GetSalesperson(int SalespersonId)
        {
            return await _dbContext.Salespeople.Where(x => x.SalespersonId == SalespersonId).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Salesperson>> GetSalespersons()
        {
            return (IEnumerable<Salesperson>)await _dbContext.Salespeople.ToListAsync();
        }

    }
}
