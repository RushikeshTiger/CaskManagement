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
    public class DistilleryRepository : IDistilleryRepository
    {
        private readonly CaskdbContext _dbContext;

        public DistilleryRepository(CaskdbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Distillery> AddDistillery(Distillery distillery)
        {
            var result = _dbContext.Distilleries.Add(distillery);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<int> DeleteDistillery(int DistilleryId)
        {
            var filteredData = _dbContext.Distilleries.Where(x => x.DistilleryId == DistilleryId).FirstOrDefault();
            _dbContext.Distilleries.Remove(filteredData);
            return await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Distillery>> GetDistilleries()
        {
            return (IEnumerable<Distillery>)await _dbContext.Distilleries.ToListAsync();
        }

        public async Task<Distillery> GetDistillery(int DistilleryId)
        {
            return await _dbContext.Distilleries.Where(x => x.DistilleryId == DistilleryId).FirstOrDefaultAsync();
        }

        public async Task<int> UpdateDistillery(Distillery distillery)
        {
            _dbContext.Distilleries.Update(distillery);
            return await _dbContext.SaveChangesAsync();
        }
    }
}
