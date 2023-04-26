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
    public class CaskRepository : ICaskRepository
    {

        private readonly CaskdbContext _dbContext;

        public CaskRepository(CaskdbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Cask> AddCask(Cask cask)
        {
            var result = _dbContext.Casks.Add(cask);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<int> DeleteCask(int CaskId)
        {
            var filteredData = _dbContext.Casks.Where(x => x.CaskId == CaskId).FirstOrDefault();
            _dbContext.Casks.Remove(filteredData);
            return await _dbContext.SaveChangesAsync();
        }

        public async Task<Cask> GetCask(int CaskId)
        {
            return await _dbContext.Casks.Where(x => x.CaskId == CaskId).FirstOrDefaultAsync();
        }

        public async Task<Cask> GetCask(string CaskType)
        {
            return await _dbContext.Casks.Where(x => x.CaskType == CaskType).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Cask>> GetCasks()
        {
            return (IEnumerable<Cask>)await _dbContext.Casks.ToListAsync();
        }

        public async Task<int> UpdateCask(Cask cask)
        {
            _dbContext.Casks.Update(cask);
            return await _dbContext.SaveChangesAsync();
        }
    }
}
