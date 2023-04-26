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
    public class CaskFillingRepository : ICaskFillingRepository
    {
        private readonly CaskdbContext _dbContext;

        public CaskFillingRepository(CaskdbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Caskfilling> AddCaskfilling(Caskfilling caskfilling)
        {
            var result = _dbContext.Caskfillings.Add(caskfilling);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Caskfilling> GetCaskfilling(int CfId)
        {

            return await _dbContext.Caskfillings.Where(x => x.CfId == CfId).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Caskfilling>> GetCaskfillings()
        {
            return (IEnumerable<Caskfilling>)await _dbContext.Caskfillings.ToListAsync();
        }
    }
}
